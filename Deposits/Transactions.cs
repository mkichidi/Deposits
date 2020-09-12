using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using OfficeOpenXml;



namespace Deposits
{
    public partial class Transactions : Form
    {
        string EditId = string.Empty;
        int flag = 0;
        DataTable backup = new DataTable();
        decimal balance = 0M;

        public Transactions()
        {
            InitializeComponent();
            BindDropdowns();
            IncrementShipment();
            BindGrid();
        }

        public void IncrementShipment()
        {
            SqlConnection con = new SqlConnection(Connection.InvAdminConn());
            SqlCommand cmd = new SqlCommand("GetMaxDepositId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            TxtShipmentID.Text = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
       {
            bool res;
            if (keyData == (System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Control) || (keyData == System.Windows.Forms.Keys.S) || (keyData == System.Windows.Forms.Keys.R))
            {
                if (keyData == (System.Windows.Forms.Keys.ControlKey | System.Windows.Forms.Keys.Control)){
                    flag = 1;
                    return false;
                }
                if (flag == 1)
                {
                    if ((keyData == System.Windows.Forms.Keys.S))
                    {
                        toolStrip1.Items["tsBtnSave"].PerformClick();
                        flag = 0;
                         res = base.ProcessCmdKey(ref msg, keyData);
                        return true;
                    }
                    else if ((keyData == System.Windows.Forms.Keys.R))
                    {
                        toolStrip1.Items["tsBtnRefresh"].PerformClick();
                        flag = 0;
                         res = base.ProcessCmdKey(ref msg, keyData);
                        return true;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
                else
                {
                    flag = 0;
                }
            }
            else
            {
                flag = 0;
            }
             res = base.ProcessCmdKey(ref msg, keyData);
            return res;
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

            DDLAccountSearch.DataSource = new DataView(dataTable);
            DDLAccountSearch.DisplayMember = "AccountNo";
            DDLAccountSearch.ValueMember = "AccountId";
            DDLAccountSearch.SelectedIndex = 0;

            DdlTDSAccount.DataSource = new DataView(dataTable);
            DdlTDSAccount.DisplayMember = "AccountNo";
            DdlTDSAccount.ValueMember = "AccountId";
            DdlTDSAccount.SelectedIndex = 0;

        }

        private void clear()
        {
            txtBalance.Text = string.Empty;
            TxtAmount.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            DdlAccount.SelectedIndex = 0;
            DdlTDSAccount.SelectedIndex = 0;
            balance = 0;
        }

        public void BindGrid()
        {
            if (DdlAccount.SelectedIndex > 0) 
            { 
            SqlConnection con = new SqlConnection(Connection.InvAdminConn());
            SqlCommand cmd = new SqlCommand("GetDepositTransaction", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Account", DdlAccount.SelectedValue);
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            GvShipment.DataSource = dataTable;
            backup = dataTable;
            this.GvShipment.AllowUserToAddRows = false;
            con.Close();
            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            int a = 0;
            decimal b = 0M;
            if (DdlAccount.SelectedIndex < 1)
            {
                MessageBox.Show("Please select account");
                DdlAccount.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtAmount.Text))
            {
                MessageBox.Show("Please enter Amount");
                TxtAmount.Focus();
                return;
            }
            else if (!decimal.TryParse(TxtAmount.Text, out b))
            {
                MessageBox.Show("Please enter Correct Amount");
                TxtAmount.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtBalance.Text))
            {
                MessageBox.Show("Please enter Balance");
                txtBalance.Focus();
                return;
            }
            else if (!decimal.TryParse(txtBalance.Text, out b))
            {
                MessageBox.Show("Please enter Correct Balance");
                txtBalance.Focus();
                return;
            }
            else if (RdTDS.Checked && DdlTDSAccount.SelectedIndex < 1)
            {
                MessageBox.Show("Please select TDS deduction account");
                DdlTDSAccount.Focus();
                return;
            }

            if (string.IsNullOrEmpty(EditId))
            {
                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                SqlCommand cmd = new SqlCommand("InsertDeposit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountID", DdlAccount.SelectedValue);

                if (RdDeposit.Checked)
                {
                    cmd.Parameters.AddWithValue("@DepositeAmount", TxtAmount.Text);
                }
                else if (RdTDS.Checked)
                {
                    cmd.Parameters.AddWithValue("@TDSAmount", TxtAmount.Text);
                    cmd.Parameters.AddWithValue("@TDSDeductionAccount", DdlTDSAccount.SelectedValue);
                }
                else if (RdIntrest.Checked)
                {
                    cmd.Parameters.AddWithValue("@IntrestAmount", TxtAmount.Text);
                }
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                cmd.Parameters.AddWithValue("@Date", DtFrom.Value.Date);
                cmd.Parameters.AddWithValue("@Balance", txtBalance.Text);

                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Transaction Entry Saved Succesfully");
                    IncrementShipment();
                    BindGrid();
                    clear();
                }
                else
                {
                    MessageBox.Show("Transaction Entry already exists");
                }
                con.Close();
            }
            else if (!string.IsNullOrEmpty(EditId))
            {
                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                SqlCommand cmd = new SqlCommand("UpdateDeposit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepositID", TxtShipmentID.Text);
                cmd.Parameters.AddWithValue("@AccountID", DdlAccount.SelectedValue);

                if (RdDeposit.Checked)
                {
                    cmd.Parameters.AddWithValue("@DepositeAmount", TxtAmount.Text);
                }
                else if (RdTDS.Checked)
                {
                    cmd.Parameters.AddWithValue("@TDSAmount", TxtAmount.Text);
                    cmd.Parameters.AddWithValue("@TDSDeductionAccount", DdlTDSAccount.SelectedValue);
                }
                else if (RdIntrest.Checked)
                {
                    cmd.Parameters.AddWithValue("@IntrestAmount", TxtAmount.Text);
                }
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                cmd.Parameters.AddWithValue("@Date", DtFrom.Value.Date);
                cmd.Parameters.AddWithValue("@Balance", txtBalance.Text);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Transaction Entry Edited Succesfully");
                    IncrementShipment();
                    BindGrid();
                    clear();
                    EditId = string.Empty;
                }
                con.Close();
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EditId))
            {
                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                SqlCommand cmd = new SqlCommand("GetDepositOnID", con);
                cmd.Parameters.AddWithValue("@DepositID", EditId);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                con.Close();

                if (dataTable.Rows.Count > 0)
                {
                    TxtShipmentID.Text = Convert.ToString(dataTable.Rows[0]["DepositID"]);
                    DdlAccount.SelectedValue = Convert.ToInt32(dataTable.Rows[0]["AccountID"]);
                    DtFrom.Value = Convert.ToDateTime(dataTable.Rows[0]["Date"]).Date;
                    txtRemarks.Text = Convert.ToString(dataTable.Rows[0]["Remarks"]);
                    txtBalance.Text = Convert.ToString(dataTable.Rows[0]["Balance"]);

                    if (dataTable.Rows[0]["DepositeAmount"] != DBNull.Value)
                    {
                        TxtAmount.Text = Convert.ToString(dataTable.Rows[0]["DepositeAmount"]);
                        RdDeposit.Checked = true;
                    }
                    else if (dataTable.Rows[0]["IntrestAmount"] != DBNull.Value)
                    {
                        TxtAmount.Text = Convert.ToString(dataTable.Rows[0]["IntrestAmount"]);
                        RdIntrest.Checked = true;
                    }
                    else if (dataTable.Rows[0]["TDSAmount"] != DBNull.Value)
                    {
                        TxtAmount.Text = Convert.ToString(dataTable.Rows[0]["TDSAmount"]);
                        RdTDS.Checked = true;
                        DdlTDSAccount.SelectedValue = Convert.ToInt32(dataTable.Rows[0]["TDSDeductionAccount"]);
                    }
                }
            }
        }

        private void GvShipment_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GvShipment.SelectedRows)
            {
                EditId = row.Cells[0].Value.ToString();
            }
        }


        public static DataTable ConvertExcelToDataTable(string FileName)
        {
            string sSheetName = null;
            string sConnection = null;
            DataTable dtTablesList = default(DataTable);
            OleDbCommand oleExcelCommand = default(OleDbCommand); 
            OleDbDataReader oleExcelReader = default(OleDbDataReader);
            OleDbConnection oleExcelConnection = default(OleDbConnection);
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
            oleExcelConnection = new OleDbConnection(sConnection); 
            oleExcelConnection.Open();
            dtTablesList = oleExcelConnection.GetSchema("Tables"); 
            if (dtTablesList.Rows.Count > 0) 
            {
                sSheetName = "Passbook$";
            }
            dtTablesList.Clear(); 
            dtTablesList.Dispose(); 
            if (!string.IsNullOrEmpty(sSheetName)) {
                oleExcelCommand = oleExcelConnection.CreateCommand();
                oleExcelCommand.CommandText = "Select * From [" + sSheetName + "]";
                oleExcelCommand.CommandType = CommandType.Text;
                oleExcelReader = oleExcelCommand.ExecuteReader();
                 dtTablesList = new DataTable();
                 dtTablesList.Load(oleExcelReader);
                oleExcelReader.Close(); 
            }
            oleExcelConnection.Close();

            return dtTablesList;
        }

        //private void BtnBrowse_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog op = new OpenFileDialog();
        //    op.Multiselect = true;
        //    op.ShowDialog();
        //    TxtUploadfile.Text = op.FileName ;
        //}

        //private void BtnUpload_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(TxtUploadfile.Text))
        //    {
        //        DataTable dt = ConvertExcelToDataTable(TxtUploadfile.Text);


        //        string error = string.Empty;
        //        string correct = string.Empty;
        //        DateTime datetime;
        //        decimal dec = 0m;


        //        for (int row=0;row<dt.Rows.Count;row++)
        //        {
        //            int errorBit = 0;

        //            try
        //            {
        //                if (!DateTime.TryParse(Convert.ToString(dt.Rows[row]["Date"]), out datetime))
        //                {
        //                    if (errorBit == 0)
        //                    {
        //                        error += "Line No " + (row + 2) + Environment.NewLine;
        //                        errorBit = 1;
        //                    }
        //                    error += "    Please enter correct Date" + Environment.NewLine;
        //                }

        //                if ((string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Deposit"]))) && (string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Withdraw"]))))
        //                {
        //                    if (errorBit == 0)
        //                    {
        //                        error += "Line No " + (row + 2) + Environment.NewLine;
        //                        errorBit = 1;
        //                    }
        //                    error += "    Please enter Deposit or Withdraw" + Environment.NewLine;
        //                }

        //                else if (((string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Deposit"]))) && (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Withdraw"])))) && (!decimal.TryParse(Convert.ToString(dt.Rows[row]["Withdraw"]), out dec)))
        //                {
        //                    if (errorBit == 0)
        //                    {
        //                        error += "Line No " + (row + 2) + Environment.NewLine;
        //                        errorBit = 1;
        //                    }
        //                    error += "    Please enter correct Withdraw" + Environment.NewLine;
        //                }

        //               else if (((string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Withdraw"])))&&(!string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Deposit"])))) && (!decimal.TryParse(Convert.ToString(dt.Rows[row]["Deposit"]), out dec)))
        //                {
        //                    if (errorBit == 0)
        //                    {
        //                        error += "Line No " + (row + 2) + Environment.NewLine;
        //                        errorBit = 1;
        //                    }
        //                    error += "    Please enter correct Deposit" + Environment.NewLine;
        //                }

        //                if ((string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Balance"]))) && (!decimal.TryParse(Convert.ToString(dt.Rows[row]["Balance"]), out dec)))
        //                {
        //                    if (errorBit == 0)
        //                    {
        //                        error += "Line No " + (row + 2) + Environment.NewLine;
        //                        errorBit = 1;
        //                    }
        //                    error += "    Please enter correct Balance" + Environment.NewLine;
        //                }



        //                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
        //                SqlCommand cmd = new SqlCommand("GetAccountNoonName", con);
        //                cmd.Parameters.AddWithValue("@accountno", dt.Rows[row]["Account No"]);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                con.Open();
        //                if (Convert.ToInt32(cmd.ExecuteScalar()) < 1)
        //                {
        //                    if (errorBit == 0)
        //                    {
        //                        error += "Line No " + (row + 2) + Environment.NewLine;
        //                        errorBit = 1;
        //                    }
        //                    error += "    Please check Account No in Account Master" + Environment.NewLine;
                         
        //                }
        //                con.Close();

        //                con = new SqlConnection(Connection.InvAdminConn());
        //                cmd = new SqlCommand("GetBankGroupOnName", con);
        //                cmd.Parameters.AddWithValue("@group", dt.Rows[row]["Group"]);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                con.Open();
        //                if (Convert.ToInt32(cmd.ExecuteScalar()) < 1)
        //                {
        //                    if (errorBit == 0)
        //                    {
        //                        error += "Line No " + (row + 2) + Environment.NewLine;
        //                        errorBit = 1;
        //                    }
        //                    error += "    Please check Group in Group Master" + Environment.NewLine;
        //                }
        //                con.Close();

        //                con = new SqlConnection(Connection.InvAdminConn());
        //                cmd = new SqlCommand("CheckPassbookTransactionBeforeUpload", con);
        //                cmd.Parameters.AddWithValue("@ChequeNo", dt.Rows[row]["Cheque No"]);
        //                cmd.Parameters.AddWithValue("@Particular", dt.Rows[row]["Particular"]);
        //                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Withdraw"])))
        //                {
        //                    TxtWithdraw.Text = Convert.ToString(dt.Rows[row]["Withdraw"]);
        //                }

        //                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Deposit"])))
        //                {
        //                    TxtDeposit.Text = Convert.ToString(dt.Rows[row]["Deposit"]);
        //                }

        //                cmd.Parameters.AddWithValue("@Deposit", dt.Rows[row]["Deposit"]);
        //                cmd.Parameters.AddWithValue("@Withdrawals", dt.Rows[row]["Withdraw"]);
        //                DdlBankGroup.Text = Convert.ToString(dt.Rows[row]["Group"]);
        //                DdlAccount.Text = Convert.ToString(dt.Rows[row]["Account No"]);
        //                cmd.Parameters.AddWithValue("@BankGroup", DdlBankGroup.SelectedValue);
        //                cmd.Parameters.AddWithValue("@BankAccount", DdlAccount.SelectedValue);
        //                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dt.Rows[row]["Date"]).Date);

        //                cmd.CommandType = CommandType.StoredProcedure;
        //                con.Open();
        //                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
        //                {
        //                    if (errorBit == 0)
        //                    {
        //                        error += "Line No " + (row + 2) + Environment.NewLine;
        //                        errorBit = 1;
        //                    }
        //                    error += "    Duplicate Data.Please check and upload." + Environment.NewLine;
        //                }
        //                con.Close();

        //            }    
        //            catch (Exception ex)
        //            {
        //                error += "Line No" + (row + 2) + Environment.NewLine;
        //                error += ex.Message;
        //                continue;
        //            }
        //        }
        //        //if (error.Length > 0 && correct.Length>0)
        //        //{
        //        //    MessageBox.Show("Lines at "+correct.Substring(1)+" uploaded succesfully."+Environment.NewLine+" Error at " + error+Environment.NewLine+"Please correct and upload error data at "+clearExcelUploadSuccess(correct));
        //        //    error = string.Empty;
        //        //    correct = string.Empty;
        //        //}
        //        //else 
        //            if (error.Length > 0)
        //        {
        //            MessageBox.Show(error + Environment.NewLine + "Please correct and upload error data at " + TxtUploadfile.Text);
        //            error = string.Empty;
        //            correct = string.Empty;
        //        }
        //        else
        //        {
        //            for (int row = 0; row < dt.Rows.Count; row++)
        //            {
        //                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
        //                SqlCommand cmd = new SqlCommand("InsertBankTransactionOnUpload", con);
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@ChequeNo", dt.Rows[row]["Cheque No"]);
        //                cmd.Parameters.AddWithValue("@Particular", dt.Rows[row]["Particular"]);
        //                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Withdraw"])))
        //                {
        //                    TxtWithdraw.Text = Convert.ToString(dt.Rows[row]["Withdraw"]);
        //                }

        //                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[row]["Deposit"])))
        //                {
        //                    TxtDeposit.Text = Convert.ToString(dt.Rows[row]["Deposit"]);
        //                }
        //                cmd.Parameters.AddWithValue("@Withdrawals", dt.Rows[row]["Withdraw"]);
        //                cmd.Parameters.AddWithValue("@Deposit", dt.Rows[row]["Deposit"]);
        //                DdlBankGroup.Text = Convert.ToString(dt.Rows[row]["Group"]);
        //                DdlAccount.Text = Convert.ToString(dt.Rows[row]["Account No"]);
        //                cmd.Parameters.AddWithValue("@BankGroup", DdlBankGroup.SelectedValue);
        //                cmd.Parameters.AddWithValue("@BankAccount", DdlAccount.SelectedValue);
        //                cmd.Parameters.AddWithValue("@BalanceCalculated", dt.Rows[row]["Balance"]);
        //                cmd.Parameters.AddWithValue("@Balance", TxtBalance.Text);
        //                cmd.Parameters.AddWithValue("@Description", dt.Rows[row]["Description"]);
        //                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime( dt.Rows[row]["Date"]).Date);
        //                cmd.Parameters.AddWithValue("@CB", JswDatatable.userId);
        //                cmd.Parameters.AddWithValue("@CD", DateTime.Now);
        //                con.Open();
        //                if (cmd.ExecuteNonQuery() > 0)
        //                {
        //                    correct += "," + (row + 2);
        //                }
        //                con.Close();
        //                clear();

        //            }

        //            MessageBox.Show("Shipment details saved succesfully");
        //            error = string.Empty;
        //            correct = string.Empty;
        //        }
        //        IncrementShipment();
        //        BindGrid();
        //        clear();
        //    }
        //}

        //private string clearExcelUploadSuccess(string correct)
        //{
        //    using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(TxtUploadfile.Text)))
        //    {
        //        var worksheet = package.Workbook.Worksheets[1];
        //        string [] corrects=correct.Substring(1).Split(',');
        //        for (int row = 0; row < corrects.Count(); row++)
        //        {
        //            worksheet.DeleteRow(Convert.ToInt32(corrects[row])-row);
        //        }
        //        string filename = "D:\\JSW\\ShipmentDetails\\Shipment_Error_" + DateTime.Today.ToString().Substring(0, 10).Replace('/', '_');
        //        System.IO.FileInfo excel = new System.IO.FileInfo(filename + ".xlsx");

        //        if (excel.Exists)
        //        {
        //            excel.Delete();
        //        }
        //        using (ExcelPackage pac = new ExcelPackage(new System.IO.FileInfo("D:\\JSW\\ShipmentDetails\\Shipment_Error_" + DateTime.Today.ToString().Substring(0, 10).Replace('/', '_') + ".xlsx")))
        //        {
        //            pac.Workbook.Worksheets.Add(("ShipmentDetails"), worksheet);
        //            pac.Save();
        //        }
        //    }
        //    return  ("D:\\JSW\\ShipmentDetails\\Shipment_Error_" + DateTime.Today.ToString().Substring(0, 10).Replace('/', '_') + ".xlsx");
        //}

        //private string ExcelDropdown(DataTable dt, string value)
        //{
        //    string data = string.Empty;
        //    foreach (DataRow datarow in dt.Rows)
        //    {
        //        if (data.Length > 0)
        //        {
        //            data += datarow[value] + ",";
        //        }
        //        else
        //        {
        //            data += "\"" + datarow[value] + ",";
        //        }
        //    }
        //    if (data.Length > 0)
        //    {
        //        data = data.Substring(0, data.Length - 1);
        //        data += "\"";
        //    }
        //    return data;
        //}

        //private void DownloadFile_Click(object sender, EventArgs e)
        //{
        //    string filename = "D:\\Bank\\Passbook\\Passbook_" + DateTime.Today.ToString().Substring(0, 10).Replace('/', '_');
        //    System.IO.Directory.CreateDirectory("D:\\Bank\\Passbook\\Passbook");

        //    System.IO.FileInfo excel = new System.IO.FileInfo( filename + ".xlsx");

        //    if (excel.Exists)
        //    {
        //        excel.Delete();
        //    }
        //    using (var xls = new ExcelPackage(excel))
        //    {
        //        var sheet = xls.Workbook.Worksheets.Add("Passbook");
        //        sheet.Cells["A1"].Value = "Date";
        //        sheet.Cells["B1"].Value = "Cheque No";
        //        sheet.Cells["C1"].Value = "Particular";
        //        sheet.Cells["D1"].Value = "Withdraw";
        //        sheet.Cells["E1"].Value = "Deposit";
        //        sheet.Cells["F1"].Value = "Balance";
        //        sheet.Cells["G1"].Value = "Account No";
        //        sheet.Cells["H1"].Value = "Group";
        //        sheet.Cells["I1"].Value = "Description";

        //        sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

        //        sheet.Column(1).Width = 20;
        //        sheet.Column(2).Width = 20;
        //        sheet.Column(3).Width = 20;
        //        sheet.Column(4).Width = 20;
        //        sheet.Column(5).Width = 20;
        //        sheet.Column(6).Width = 20;
        //        sheet.Column(7).Width = 20;
        //        sheet.Column(8).Width = 20;
        //        sheet.Column(9).Width = 20;


        //        //Get the final row for the column in the worksheet
        //        int finalrows = sheet.Dimension.End.Row;


        //        sheet.Cells["A1:I"+ finalrows.ToString()].Style.WrapText = true;
        //        sheet.Cells["A1:I1"].Style.HorizontalAlignment =OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        //        sheet.Cells["A1:I1"].Style.Font.Size = 12;

        //        sheet.Cells["A1:I1"].Style.Font.Bold = true;
        //        sheet.Cells["A1:I1"].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
        //        sheet.Cells["A1:I1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);


        //        SqlConnection con = new SqlConnection(Connection.InvAdminConn());
        //        SqlCommand cmd = new SqlCommand("GetAccount", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        con.Open();
        //        SqlDataReader reader;
        //        reader = cmd.ExecuteReader();
        //        DataTable dataTable = new DataTable();
        //        dataTable.Load(reader);
               
        //        DdlAccount.DataSource = new DataView(dataTable);
        //        DdlAccount.DisplayMember = "AccountNo";
        //        DdlAccount.ValueMember = "AccountId";
        //        DdlAccount.SelectedIndex = 0;
        //        con.Close();

        //        var AccountHolderName = xls.Workbook.Worksheets.Add("AccountNo");
        //        for (int dr = 1; dr <= dataTable.Rows.Count; dr++)
        //        {
        //            AccountHolderName.Cells["A" + dr].Value = dataTable.Rows[dr - 1]["AccountNo"];
        //        }




        //        con = new SqlConnection(Connection.InvAdminConn());
        //        cmd = new SqlCommand("GetBankGroup", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        con.Open();
        //        reader = cmd.ExecuteReader();
        //        dataTable = new DataTable();
        //        dataTable.Load(reader);
               
        //        DdlBankGroup.DataSource = new DataView(dataTable);
        //        DdlBankGroup.DisplayMember = "BankGroupName";
        //        DdlBankGroup.ValueMember = "BankGroupId";
        //        DdlBankGroup.SelectedIndex = 0;
        //        con.Close();

        //        var Group = xls.Workbook.Worksheets.Add("Group");
        //        for (int dr = 1; dr <= dataTable.Rows.Count; dr++)
        //        {
        //            Group.Cells["A" + dr].Value = dataTable.Rows[dr - 1]["BankGroupName"];
        //        }

               

        //        xls.Save();

        //        DialogResult ans = MessageBox.Show("File Downloaded at " + filename + Environment.NewLine + "Do you want to open?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (ans == DialogResult.Yes)
        //        {
        //            System.Diagnostics.Process.Start(filename + ".xlsx");
        //        }
        //    }
        //}

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        //private void TxtShipmentSearch_TextChanged(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(TxtChequeNoSearch.Text))
        //    {
        //        GvShipment.DataSource = backup.Select("ChequeNo Like '%" + TxtChequeNoSearch.Text + "%'").Any() ? backup.Select("ChequeNo Like '%" + TxtChequeNoSearch.Text + "%'").CopyToDataTable() : backup.Clone();
        //    }
        //    else
        //    {
        //        GvShipment.DataSource = backup;
        //    }
        //}

        //private void TxtDeposit_TextChanged(object sender, EventArgs e)
        //{
        //    decimal b = 0M;
        //    //TxtWithdraw.Text=string.Empty;
        //    if (!decimal.TryParse(TxtDeposit.Text, out b))
        //    {
        //        TxtBalance.Text = balance.ToString();
        //        return;
        //    }

        //    //if (Convert.ToDecimal(balance)>=0)
        //    //{
        //        TxtWithdraw.TextChanged -= TxtWithdraw_TextChanged;
        //        TxtWithdraw.Text = string.Empty;
        //        TxtWithdraw.TextChanged += TxtWithdraw_TextChanged;
        //        TxtBalance.Text =Convert.ToString(balance + Convert.ToDecimal(TxtDeposit.Text));
        //    //}
        //}

        //private void TxtWithdraw_TextChanged(object sender, EventArgs e)
        //{
        //    decimal b = 0M;
        //    //TxtDeposit.Text=string.Empty;

        //    if (!decimal.TryParse(TxtWithdraw.Text, out b))
        //    {
        //        TxtBalance.Text = balance.ToString();
        //        return;
        //    }

        //    //if (Convert.ToDecimal(balance) >= 0)
        //    //{
        //        TxtDeposit.TextChanged -= TxtDeposit_TextChanged;
        //        TxtDeposit.Text = string.Empty;
        //        TxtDeposit.TextChanged += TxtDeposit_TextChanged;
        //        TxtBalance.Text = Convert.ToString(balance - Convert.ToDecimal(TxtWithdraw.Text));
        //    //}
        //}

        //private void DdlAccount_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    decimal b = 0M;
        //    if (DdlAccount.SelectedIndex > 0) 
        //    { 
        //    SqlConnection con = new SqlConnection(Connection.InvAdminConn());
        //    SqlCommand cmd = new SqlCommand("GetAccountBalance", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@BankAccount", DdlAccount.SelectedValue);

        //    con.Open();
            
        //      //balance=  Convert.ToDecimal(cmd.ExecuteScalar());
        //      TxtBalance.Text = Convert.ToString(balance);
        //    con.Close();
        //    }

        //    if (decimal.TryParse(TxtWithdraw.Text, out b))
        //    {
        //        TxtBalance.Text = Convert.ToString(balance - Convert.ToDecimal(TxtWithdraw.Text));
        //    }

        //    if (decimal.TryParse(TxtDeposit.Text, out b))
        //    {
        //        TxtBalance.Text = Convert.ToString(balance + Convert.ToDecimal(TxtDeposit.Text));
        //    }
        //    BindGrid();
        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            IncrementShipment();
            clear();
        }

        private void RdTDS_CheckedChanged(object sender, EventArgs e)
        {
            if (RdTDS.Checked)
            {
                DdlTDSAccount.Enabled = true;
            }
            else
            {
                DdlTDSAccount.Enabled = false;
            }
        }

        private void DdlAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        //private void TxtGroupSearch_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (TxtGroupSearch.SelectedIndex>0)
        //    {
        //        GvShipment.DataSource = backup.Select("BankGroupName Like '%" + TxtGroupSearch.Text + "%'").Any() ? backup.Select("BankGroupName Like '%" + TxtGroupSearch.Text + "%'").CopyToDataTable() : backup.Clone();
        //    }
        //    else
        //    {
        //        GvShipment.DataSource = backup;
        //    }
        //}

        //private void DtFrom_ValueChanged(object sender, EventArgs e)
        //{
        //    if (backup.Rows.Count > 0)
        //    {
        //        GvShipment.DataSource = backup.Select("DummyDate >='" + DtFrom.Value.Date + "' and DummyDate <='" + DtTo.Value.Date + "'").Any() ? backup.Select("DummyDate >='" + DtFrom.Value.Date + "' and DummyDate <='" + DtTo.Value.Date + "'").CopyToDataTable() : backup.Clone();
        //    }
        //}

        //private void DtTo_ValueChanged(object sender, EventArgs e)
        //{
        //    if (backup.Rows.Count > 0)
        //    {
        //        GvShipment.DataSource = backup.Select("DummyDate >='" + DtFrom.Value.Date + "' and DummyDate <='" + DtTo.Value.Date + "'").Any() ? backup.Select("DummyDate >='" + DtFrom.Value.Date + "' and DummyDate <='" + DtTo.Value.Date + "'").CopyToDataTable() : backup.Clone();
        //    }
        //}

    }
}
