using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposits.Reports
{
    public partial class DeadLine : Form
    {
        public DeadLine()
        {
            InitializeComponent();

            var con = new SqlConnection(Connection.InvAdminConn());
            var cmd = new SqlCommand("GetPropertyOwner", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            var dataTable = new DataTable();
            var reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            dataTable = dataTable.Select("", "[Name] ASC").CopyToDataTable(); ;

            DdlAccountHolder.Properties.DataSource = dataTable;
            DdlAccountHolder.Properties.DisplayMember = "Name";
            DdlAccountHolder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            DdlAccountHolder.Properties.IncrementalSearch = true;
            DdlAccountHolder.KeyDown += new KeyEventHandler(checkedComboBoxEdit1_KeyDown);

        }

        void checkedComboBoxEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((DevExpress.XtraEditors.CheckedComboBoxEdit)sender).IsPopupOpen)
                ((DevExpress.XtraEditors.CheckedComboBoxEdit)sender).ShowPopup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection.InvAdminConn());
            SqlCommand cmd = new SqlCommand("GetDepositAccountsDeadLine", con);
            cmd.Parameters.AddWithValue("@DeadLine", DtDeadLine.Value.Date);
            cmd.Parameters.AddWithValue("@AccountHolder", DdlAccountHolder.Text.Replace(", ", ","));

            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            GvReport.DataSource = dataTable;
            this.GvReport.AllowUserToAddRows = false;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection.InvAdminConn());
            SqlCommand cmd = new SqlCommand("GetDepositAccountsDeadLineBetweenDates", con);
            cmd.Parameters.AddWithValue("@From", DtFrom.Value.Date);
            cmd.Parameters.AddWithValue("@To", DtTo.Value.Date);
            cmd.Parameters.AddWithValue("@AccountHolder", DdlAccountHolder.Text.Replace(", ", ","));

            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            GvReport.DataSource = dataTable;
            this.GvReport.AllowUserToAddRows = false;
            con.Close();
        }
    }
}
