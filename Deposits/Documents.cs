using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposits
{
    public partial class Documents : Form
    {
        List<string> paths = new List<string>();
        DataTable backup = new DataTable();
        string sharePath = "\\\\BJ01\\DepositDocuments";
        public Documents()
        {
            InitializeComponent();
            BindDropdowns();

            if (PropertyDatatable.id > 0)
            {
                DdlAccount.SelectedValue = PropertyDatatable.id;
                PropertyDatatable.id = 0;
            }
        }

        public void BindDropdowns()
        {
            SqlConnection con = new SqlConnection(Connection.InvAdminConn());
            SqlCommand cmd = new SqlCommand("GetDepositAccounts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            DataRow row = dataTable.NewRow();
            row["AccountNo"] = "-Select-";
            row["Active"] = true;
            dataTable.Rows.InsertAt(row, 0);
            DdlAccount.DataSource = new DataView(dataTable);
            DdlAccount.DisplayMember = "AccountNo";
            DdlAccount.ValueMember = "AccountId";
            DdlAccount.SelectedIndex = 0;

        }

        [DllImport("advapi32.DLL", SetLastError = true)]
        public static extern int LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

        private void button1_Click(object sender, EventArgs e)
        {
            if (DdlAccount.SelectedIndex < 1)
            {
                MessageBox.Show("Please select Account");
                DdlAccount.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtDocuName.Text))
            {
                MessageBox.Show("Please enter Document Name");
                TxtDocuName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtDocuments.Text))
            {
                MessageBox.Show("Please select Document Name");
                BtnAddDocuments.Focus();
                return;
            }

            string pathToSave = string.Empty;
            bool copied = false;
            foreach (string path in paths)
            {
                if (string.IsNullOrEmpty(path))
                {
                    continue;
                }



                IntPtr admin_token = default(IntPtr);
                WindowsIdentity wid_current = WindowsIdentity.GetCurrent();
                WindowsIdentity wid_admin = null;
                WindowsImpersonationContext wic = null;
                try
                {
                    //if (LogonUser("ShareUser", "RAGHU-NEWOFFICE", "sharing", 9, 0, ref admin_token) != 0)
                    //{
                        //pathToSave += "\\\\RAGHU-NEWOFFICE\\PropertyDocuments" + "\\" + TxtDocuName.Text + "_" + DateTime.Now.ToString("dd/MMM/yyyy_HH_mm") + "_" + path.Split('\\')[path.Split('\\').Count() - 1];


                    pathToSave += sharePath + "\\" + TxtDocuName.Text + "_" + DateTime.Now.ToString("dd/MMM/yyyy_HH_mm") + "_" + path.Split('\\')[path.Split('\\').Count() - 1];


                        //pathToSave += "D:\\Manoj\\DocumentsData\\" + path.Split('\\')[path.Split('\\').Count() - 1];
                        //System.IO.Directory.CreateDirectory("D:\\Manoj\\DocumentsData");

                        //wid_admin = new WindowsIdentity(admin_token);
                        //wic = wid_admin.Impersonate();

                        if (pathToSave != path)
                        {
                            NetworkShare.DisconnectFromShare(sharePath, true); //Remove this line
                            NetworkShare.ConnectToShare(sharePath, "ShareUser", "sharing"); //Connect with the new credentials
                            System.IO.File.Copy(path, pathToSave, true);
                            NetworkShare.DisconnectFromShare(sharePath, false); //Remove this line also

                            copied = true;
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Copy Failed");
                    //}
                }
                catch (System.Exception se)
                {
                    int ret = Marshal.GetLastWin32Error();
                    MessageBox.Show(ret.ToString(), "Error code: " + ret.ToString());
                    MessageBox.Show(se.Message);
                }
                finally
                {
                    if (wic != null)
                    {
                        wic.Undo();
                    }
                }
            }

            if (copied)
            {
                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                SqlCommand cmd = new SqlCommand("InsertDepositDocumnets", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PropertyID", DdlAccount.SelectedValue);
                cmd.Parameters.AddWithValue("@DocumnetName", TxtDocuName.Text);
                cmd.Parameters.AddWithValue("@Path", pathToSave);
                cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
                cmd.Parameters.AddWithValue("@CD", DateTime.Now);
                con.Open();
               
                 if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Document Saved Succesfully"); BindGrid();
                    clear();
                }
                 else
                 {
                     MessageBox.Show("Document name already exists. please change Document name");
                 }
            }

            //const string cSplitString = "target="; // word "target" might differ in other languages

            //var targets = new List<string>();
            //var proc = new Process // We need separate process to get the output
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = "cmdkey.exe",
            //        Arguments = "/list",
            //        UseShellExecute = false,
            //        RedirectStandardOutput = true,
            //        CreateNoWindow = true
            //    }
            //};
            //proc.Start();

            // reading output from the process
            //while (!proc.StandardOutput.EndOfStream)
            //{
            //    string line = proc.StandardOutput.ReadLine();
            //    if (line.Contains(cSplitString))
            //        targets.Add(line.Substring(line.IndexOf(cSplitString) + cSplitString.Length));
            //}

            //string deleteTarget = "RAGHU-NEWOFFICE";
            //if (targets.Any(a => a.Contains(deleteTarget)))
            //{
            //    Process.Start("cmdkey.exe", "/delete:" + targets.First(a => a.Contains(deleteTarget)));
            //}
        }

        private void clear()
        {
            TxtDocuments.Text = string.Empty;
            TxtRemarks.Text = string.Empty;
            TxtDocuName.Text = string.Empty;
        }

        private void BindGrid()
        {

            if (DdlAccount.SelectedIndex > 0)
            {
                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                SqlCommand cmd = new SqlCommand("GetDepositDocuments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PropertyID", DdlAccount.SelectedValue);
                con.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                GvTranport.Columns.Clear();
                GvTranport.DataSource = dataTable;
                backup = dataTable;
                this.GvTranport.AllowUserToAddRows = false;
                con.Close();

                GvTranport.Columns["Path"].Visible = false;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                GvTranport.Columns.Add(btn);
                btn.HeaderText = "View Documents";
                btn.Text = "View";
                btn.Name = "btnView";
                btn.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                GvTranport.Columns.Add(btnDelete);
                btnDelete.HeaderText = "Delete Documents";
                btnDelete.Text = "Delete";
                btnDelete.Name = "btnDelete";
                btnDelete.UseColumnTextForButtonValue = true;
            }
            else
            {
                GvTranport.DataSource = null;
                GvTranport.Columns.Clear();
                backup = null;
            }
        }

        private void BtnAddDocuments_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.ShowDialog();
            paths = new List<string>();
            for (int i = 0; i < op.FileNames.Count(); i++)
            {
                TxtDocuments.Text = op.SafeFileNames[i] + Environment.NewLine;
                paths.Add(Convert.ToString(op.FileNames[i]));
            }
        }

        private void BtnViewDocuments_Click(object sender, EventArgs e)
        {
            if (paths.Count > 0 && (!string.IsNullOrEmpty(TxtDocuments.Text)))
            {
                PropertyDatatable.PdFPath = paths[0];
                //OStDatatable.paths = paths;
                //Slider Slider = new Slider();
                //Slider.Show();
                PDFViwer PDFViwer = new PDFViwer();
                PDFViwer.Show();
            }
            else
            {
                MessageBox.Show("Please select documents to view");
            }
        }

        private void DdlProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void GvTranport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GvTranport.Columns[e.ColumnIndex].HeaderText == "View Documents" && e.RowIndex >= 0)
            {
              string path=Convert.ToString( GvTranport["Path",e.RowIndex].Value);

              if ((!string.IsNullOrEmpty(path)))
                {
                    PropertyDatatable.PdFPath = path;
                    PDFViwer PDFViwer = new PDFViwer();
                    PDFViwer.Show();
                }
                else
                {
                    MessageBox.Show("Document not found");
                }
            }
            else if (GvTranport.Columns[e.ColumnIndex].HeaderText == "Delete Documents" && e.RowIndex >= 0)
            {
                DialogResult ans = MessageBox.Show("Do you want to delete thid Document ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.No)
                {
                    return;
                }

                string documentID = Convert.ToString(GvTranport[0, e.RowIndex].Value);

                if ((!string.IsNullOrEmpty(documentID)))
                {
                    SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                    SqlCommand cmd = new SqlCommand("UpdateDepositDocument ", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DocumentID", documentID);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Document Deleted Succesfully");
                        BindGrid();
                        clear();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Document not found");
                }
            }
        }

        private void TxtTransportSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtTransportSearch.Text))
            {
                GvTranport.DataSource = backup.Select("[DocumentName] Like '%" + TxtTransportSearch.Text + "%'").Any() ? backup.Select("[DocumentName] Like '%" + TxtTransportSearch.Text + "%'").CopyToDataTable() : backup.Clone();
            }
            else
            {
                GvTranport.DataSource = backup;
            }
        }
    }
}
