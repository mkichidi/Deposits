using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Deposits
{
    public partial class Accounts : Form
    {
        string EditId = string.Empty;
        DataTable backup = new DataTable();
        public Accounts()
        {
            InitializeComponent();
            IncrementDestination();
            BindGrid();
            BindDropdown();
            clear();
        }

        public void IncrementDestination()
        {
            SqlConnection con = new SqlConnection(Connection.InvAdminConn());
            SqlCommand cmd = new SqlCommand("GetMaxDepositAccountsID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            TxtBankID.Text = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
        }

        private void BindDropdown()
        {
            SqlConnection con = new SqlConnection(Connection.InvAdminConn());
            SqlCommand cmd = new SqlCommand("GetBank", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            DataRow row = dataTable.NewRow();
            row["BankName"] = "-Select-";
            row["Active"] = true;
            dataTable.Rows.InsertAt(row, 0);
            DDLBank.DataSource = new DataView(dataTable);
            DDLBank.DisplayMember = "BankName";
            DDLBank.ValueMember = "BankId";
            DDLBank.SelectedIndex = 0;


            con = new SqlConnection(Connection.InvAdminConn());
            cmd = new SqlCommand("GetPropertyOwner", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            var adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            con.Close();

            row = ds.Tables[0].NewRow();
            row["Name"] = "-Select-";
            ds.Tables[0].Rows.InsertAt(row, 0);
            DdlAccountHolder.DataSource = new DataView(ds.Tables[0]);
            DdlAccountHolder.DisplayMember = "Name";
            DdlAccountHolder.ValueMember = "PropertyOwnerID";
            DdlAccountHolder.SelectedIndex = 0;
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            decimal b = 0M;
            int a = 0;
             if (DdlAccountHolder.SelectedIndex<1)
            {
                MessageBox.Show("Please select Account Holder Name");
                DdlAccountHolder.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtAccountNo.Text))
            {
                MessageBox.Show("Please enter Account No ");
                TxtAccountNo.Focus();
                return;
            }
            else if (DDLBank.SelectedIndex<1)
            {
                MessageBox.Show("Please select Bank");
                DDLBank.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtBondNo.Text))
            {
                MessageBox.Show("Please enter Bond No ");
                TxtBondNo.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtROI.Text))
            {
                MessageBox.Show("Please enter Rate of Intrest");
                TxtROI.Focus();
                return;
            }
            else if (!decimal.TryParse(TxtROI.Text, out b))
            {
                MessageBox.Show("Please enter Correct Rate of Intrest");
                TxtROI.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDuration.Text))
            {
                MessageBox.Show("Please enter Duration");
                txtDuration.Focus();
                return;
            }
            else if (!int.TryParse(txtDuration.Text, out a))
            {
                MessageBox.Show("Please enter Correct Duration");
                txtDuration.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtMaturityAmount.Text))
            {
                MessageBox.Show("Please enter Maturity Amount");
                TxtMaturityAmount.Focus();
                return;
            }
            else if (!decimal.TryParse(TxtMaturityAmount.Text, out b))
            {
                MessageBox.Show("Please enter Correct Maturity Amount");
                TxtMaturityAmount.Focus();
                return;
            }

            if (string.IsNullOrEmpty(EditId))
            {
                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                SqlCommand cmd = new SqlCommand("InsertDepositAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountHolderName", DdlAccountHolder.SelectedValue);
                cmd.Parameters.AddWithValue("@AccountNo", TxtAccountNo.Text);
                cmd.Parameters.AddWithValue("@Bank", DDLBank.SelectedValue);
                cmd.Parameters.AddWithValue("@Description", TxtDescription.Text);
                cmd.Parameters.AddWithValue("@NickName", TxtNickName.Text);
                cmd.Parameters.AddWithValue("@Branch", txtBranch.Text);

                cmd.Parameters.AddWithValue("@ROI", TxtROI.Text);
                cmd.Parameters.AddWithValue("@Duration", txtDuration.Text);
                cmd.Parameters.AddWithValue("@NameOfScheme", TxtNameOFScheme.Text);
                cmd.Parameters.AddWithValue("@IssueDate", DtIssueDate.Value.Date);
                cmd.Parameters.AddWithValue("@MaturityDate", DtMaturityDate.Value.Date);
                cmd.Parameters.AddWithValue("@MaturityAmount", TxtMaturityAmount.Text);
                cmd.Parameters.AddWithValue("@BondNo", TxtBondNo.Text);

                if (ChkActive.Checked)
                {
                    cmd.Parameters.AddWithValue("@IsActive", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IsActive", 0);
                }
                cmd.Parameters.AddWithValue("@CB", 0);
                cmd.Parameters.AddWithValue("@CD", DateTime.Now);
                
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Account No added Succesfully");
                    IncrementDestination();
                    BindGrid();
                    clear();
                }
                else
                {
                    MessageBox.Show("Account No already exists");
                }
                con.Close();
            }
            else if (!string.IsNullOrEmpty(EditId))
            {
                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                SqlCommand cmd = new SqlCommand("UpdateDepositAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("AccountId", TxtBankID.Text);
                cmd.Parameters.AddWithValue("@AccountHolderName", DdlAccountHolder.SelectedValue);
                cmd.Parameters.AddWithValue("@AccountNo", TxtAccountNo.Text);
                cmd.Parameters.AddWithValue("@Bank", DDLBank.SelectedValue);
                cmd.Parameters.AddWithValue("@NickName", TxtNickName.Text);
                cmd.Parameters.AddWithValue("@Description", TxtDescription.Text);
                cmd.Parameters.AddWithValue("@Branch", txtBranch.Text);

                cmd.Parameters.AddWithValue("@ROI", TxtROI.Text);
                cmd.Parameters.AddWithValue("@Duration", txtDuration.Text);
                cmd.Parameters.AddWithValue("@NameOfScheme", TxtNameOFScheme.Text);
                cmd.Parameters.AddWithValue("@IssueDate", DtIssueDate.Value.Date);
                cmd.Parameters.AddWithValue("@MaturityDate", DtMaturityDate.Value.Date);
                cmd.Parameters.AddWithValue("@MaturityAmount", TxtMaturityAmount.Text);
                cmd.Parameters.AddWithValue("@BondNo", TxtBondNo.Text);
                if (ChkActive.Checked)
                {
                    cmd.Parameters.AddWithValue("@IsActive", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IsActive", 0);
                }
                cmd.Parameters.AddWithValue("@CB", 0);
                cmd.Parameters.AddWithValue("@CD", "");
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Account No Edited Succesfully");
                    IncrementDestination();
                    BindGrid();
                    clear();
                    EditId = string.Empty;
                }
                else
                {
                    MessageBox.Show("Account No already exists");
                }
                con.Close();
            }

        }

        public void BindGrid()
        {
            SqlConnection con = new SqlConnection(Connection.InvAdminConn());
            SqlCommand cmd = new SqlCommand("GetDepositAccounts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            GvDestination.DataSource = dataTable;
            backup = dataTable;
            this.GvDestination.AllowUserToAddRows = false;
            con.Close();
        }

        private void clear()
        {
            TxtDescription.Text = string.Empty;
            TxtAccountNo.Text = string.Empty;
            TxtNickName.Text = string.Empty;
            DDLBank.SelectedIndex = 0;
            DdlAccountHolder.SelectedIndex = 0;
            TxtROI.Text = string.Empty;
            TxtBondNo.Text = string.Empty;
            TxtNameOFScheme.Text = string.Empty;
            txtDuration.Text = string.Empty;
            TxtMaturityAmount.Text = string.Empty;
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EditId))
            {
                SqlConnection con = new SqlConnection(Connection.InvAdminConn());
                SqlCommand cmd = new SqlCommand("GetDepositAccountOnId", con);
                cmd.Parameters.AddWithValue("@AccountId", EditId);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                if (dataTable.Rows.Count > 0)
                {
                    TxtBankID.Text = Convert.ToString(dataTable.Rows[0]["AccountId"]);
                    TxtAccountNo.Text = Convert.ToString(dataTable.Rows[0]["AccountNo"]);
                    DDLBank.Text = Convert.ToString(dataTable.Rows[0]["AccountHolderName"]);
                    DDLBank.Text = Convert.ToString(dataTable.Rows[0]["Bank"]);
                    TxtDescription.Text = Convert.ToString(dataTable.Rows[0]["Description"]);
                    TxtNickName.Text = Convert.ToString(dataTable.Rows[0]["NickName"]);
                    txtBranch.Text = Convert.ToString(dataTable.Rows[0]["Branch"]);

                    TxtROI.Text = Convert.ToString(dataTable.Rows[0]["ROI"]);
                    txtDuration.Text = Convert.ToString(dataTable.Rows[0]["Duration"]);
                    TxtNameOFScheme.Text = Convert.ToString(dataTable.Rows[0]["NameOfScheme"]);
                    DtIssueDate.Value = Convert.ToDateTime(dataTable.Rows[0]["IssueDate"]).Date;
                    DtMaturityDate.Value = Convert.ToDateTime(dataTable.Rows[0]["MaturityDate"]).Date;
                    TxtMaturityAmount.Text = Convert.ToString(dataTable.Rows[0]["MaturityAmount"]);
                    TxtBondNo.Text = Convert.ToString(dataTable.Rows[0]["BondNo"]);

                    if (Convert.ToBoolean(dataTable.Rows[0]["IsActive"]) == true)
                    {
                        ChkActive.Checked = true;
                    }
                    else
                    {
                        ChkActive.Checked = false;
                    }

                }
                con.Close();
            }
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            clear();
            IncrementDestination();
            EditId = string.Empty;
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDestinationSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBankSearch.Text))
            {
                GvDestination.DataSource = backup.Select("[AccountHolderName] Like '%" + TxtBankSearch.Text + "%'").Any() ? backup.Select("[AccountHolderName] Like '%" + TxtBankSearch.Text + "%'").CopyToDataTable() : backup.Clone();
            }
            else
            {
                GvDestination.DataSource = backup;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNickNameSearch.Text))
            {
                GvDestination.DataSource = backup.Select("[NickName] Like '%" + TxtNickNameSearch.Text + "%'").Any() ? backup.Select("[NickName] Like '%" + TxtNickNameSearch.Text + "%'").CopyToDataTable() : backup.Clone();
            }
            else
            {
                GvDestination.DataSource = backup;
            }
        }

        private void TxtType_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtType.Text))
            {
                GvDestination.DataSource = backup.Select("AccountType Like '%" + TxtType.Text + "%'").Any() ? backup.Select("AccountType Like '%" + TxtType.Text + "%'").CopyToDataTable() : backup.Clone();
            }
            else
            {
                GvDestination.DataSource = backup;
            }
        }

        private void GvDestination_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GvDestination.SelectedRows)
            {
                EditId = row.Cells[0].Value.ToString();
            }
        }
    }
}
