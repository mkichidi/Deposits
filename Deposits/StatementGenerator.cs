using OfficeOpenXml;
using OfficeOpenXml.Style;
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

namespace Deposits
{
    public partial class StatementGenerator : Form
    {
        public StatementGenerator()
        {
            InitializeComponent();

            dt.Columns.Add("Date",typeof( DateTime));
            dt.Columns.Add("Deposit");
            dt.Columns.Add("Interest");
            dt.Columns.Add("TDS");
            dt.Columns.Add("Balance",typeof(decimal));

           var con = new SqlConnection(Connection.InvAdminConn());
           var cmd = new SqlCommand("GetDepositAccounts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader;
           var dataTable = new DataTable();
            reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            con.Close();

            DataRow row = dataTable.NewRow();
            row["AccountNo"] = "-Select-";
            dataTable.Rows.InsertAt(row, 0);

            DdlAccount.DataSource = new DataView(dataTable);
            DdlAccount.DisplayMember = "AccountNo";
            DdlAccount.ValueMember = "AccountId";
            DdlAccount.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlAccount.SelectedIndex > 0)
            {
                var con = new SqlConnection(Connection.InvAdminConn());
                var cmd = new SqlCommand("GetDepositAmountOnAccountID", con);
                cmd.Parameters.AddWithValue("@AccountId", DdlAccount.SelectedValue);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader;
                var dataTable = new DataTable();
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                con.Close();

                if (dataTable.Rows.Count > 0)
                {
                    dt.Rows.Clear();

                    decimal depositAmount = Convert.ToDecimal(dataTable.Rows[0]["DepositeAmount"]);
                    decimal ROI = Convert.ToDecimal(dataTable.Rows[0]["ROI"]);
                    decimal TDS = 10;
                    int duration = Convert.ToInt32(dataTable.Rows[0]["Duration"]);

                    DateTime startDate = Convert.ToDateTime(dataTable.Rows[0]["Date"]);
                    DateTime endDate = startDate.AddMonths(duration);
                    Tuple<decimal, decimal> TDStoDeduct = Tuple.Create(0M, 0M);

                    DataRow row = dt.NewRow();
                    row["Deposit"] =Math.Round( depositAmount,0);
                    row["Date"] = startDate;
                    row["Balance"] = Math.Round(depositAmount, 0);
                    dt.Rows.Add(row);

                    var nextDate = startDate.AddMonths(3).AddDays(-1);

                    while (nextDate <= endDate)
                    {
                        var interMedtiateYear = new DateTime(nextDate.Year, 4, 1);
                        if (TimeBetween(interMedtiateYear, startDate, nextDate))
                        {
                            //TDStoDeduct = InterestCalculatorDayWise(depositAmount, ROI, startDate, interMedtiateYear.AddDays(-1), nextDate);
                            TDStoDeduct = InterestCalculatorMonthly(depositAmount, ROI, startDate, interMedtiateYear.AddDays(-1));
                        }
                        depositAmount += InterestCalculatorQuarterly(depositAmount, ROI, nextDate, TDStoDeduct);
                        TDStoDeduct = Tuple.Create(0M, 0M);
                        startDate = nextDate;
                        nextDate = startDate.AddMonths(3);
                    }

                    GvReport.DataSource = dt;
                }
            }
        }


        public static bool TimeBetween(DateTime curent, DateTime fromDate, DateTime toDate)
        {
            int cd_fd = curent.CompareTo(fromDate);
            int cd_td = curent.CompareTo(toDate);

            if (cd_fd == 0 || cd_td == 0)
            {
                return true;
            }

            if (cd_fd >= 1 && cd_td <= -1)
            {
                return true;
            }
            return false;
        }

        static DataTable dt = new DataTable();

        private static decimal InterestCalculatorQuarterly(decimal depositAmount, decimal ROI, DateTime date, Tuple<decimal, decimal> TDStoDeduct)
        {
            var interestbkp = ((depositAmount * ROI) / (4 * 100));
           var interest = Math.Round(interestbkp - (TDStoDeduct.Item1/10));

            DataRow row = dt.NewRow();
            row["Interest"] = interest;
            row["Date"] = date;
            row["Balance"] = Math.Round(interest + depositAmount, 0);
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["TDS"] = Math.Round((interestbkp - TDStoDeduct.Item1) / 10);
            row["Date"] = date.AddDays(1);
            row["Balance"] =Math.Round( interest + depositAmount - Math.Round((interestbkp - TDStoDeduct.Item1) / 10),0);
            dt.Rows.Add(row);

            return interest - Math.Round((interestbkp - TDStoDeduct.Item1) / 10);
        }


        private static Tuple<decimal, decimal> InterestCalculatorDayWise(decimal depositAmount, decimal ROI, DateTime startDate, DateTime endDate, DateTime nextDate)
        {
            decimal quarterInterest = ((depositAmount * ROI) / (4 * 100));

            decimal days = Convert.ToDecimal((nextDate - startDate).TotalDays);

            //int wholeMonth = Convert.ToInt32(days / 30);

            //int newDays = 0;
            //for (int i = 1; i <= wholeMonth; i++)
            //{
            //    var tempDate = startDate.AddMonths(i);
            //    if (DateTime.DaysInMonth(startDate.Year, startDate.Month) == 31)
            //    {
            //        newDays++;
            //    }
            //}
            decimal dayInterest = quarterInterest / days;

            decimal remainingDays = Convert.ToDecimal((endDate - startDate).TotalDays);

            var interest = (remainingDays * dayInterest);

            var row = dt.NewRow();
            row["Interest"] = Math.Round(interest / 10);
            row["Date"] = endDate;
            row["Balance"] = Math.Round(depositAmount + Math.Round(interest / 10));
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["TDS"] = Math.Round(interest / 10);
            row["Date"] = endDate;
            row["Balance"] = Math.Round(depositAmount);
            dt.Rows.Add(row);

            return Tuple.Create(Math.Round(interest), Math.Round(interest / 10));
        }

        private static Tuple<decimal ,decimal>  InterestCalculatorMonthly(decimal depositAmount, decimal ROI, DateTime startDate, DateTime endDate)
        {
            decimal monthlyInterest = ((depositAmount * ROI) / (12 * 100));

            decimal days = Convert.ToDecimal((endDate - startDate).TotalDays);

            //int wholeMonth = Convert.ToInt32(days / 30);

            DateTime temp = startDate.AddMonths(1);
            int wholeMonth = 0;

            while (temp <= endDate)
            {
                wholeMonth++;
                temp = temp.AddMonths(1);
            }

            int newDays = 0;
            if (System.DateTime.DaysInMonth(endDate.Year, endDate.Month)==31)
            {
                newDays++;
            }
            //for (int i = 1; i <= wholeMonth; i++)
            //{
            //    var tempDate = startDate.AddMonths(i);
            //    if (DateTime.DaysInMonth(startDate.Year, startDate.Month) == 31)
            //    {
            //        newDays++;
            //    }
            //}

            decimal dayInterest = monthlyInterest / (newDays > 0 ? 31 : 30);

            //decimal remainingDays = (days - Convert.ToDecimal((endDate - startDate.AddMonths(wholeMonth)).TotalDays)) + newDays;
            decimal remainingDays = Convert.ToDecimal((endDate - startDate.AddMonths(wholeMonth)).TotalDays);

            var interest = (wholeMonth * monthlyInterest) + (remainingDays * dayInterest);

            var row = dt.NewRow();
            row["Interest"] = Math.Round(interest / 10);
            row["Date"] = endDate;
            row["Balance"] = Math.Round(depositAmount + Math.Round(interest / 10));
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["TDS"] = Math.Round(interest / 10);
            row["Date"] = endDate;
            row["Balance"] = Math.Round(depositAmount);
            dt.Rows.Add(row);

            return Tuple.Create( Math.Round(interest),Math.Round(interest / 10));
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            string filename = "D:\\JSW\\NotBilled\\Bills_" + DateTime.Now.Date.ToString().Substring(0, 10).Replace('/', '-') + ".xlsx";
            System.IO.FileInfo excel = new System.IO.FileInfo(filename);

            System.IO.Directory.CreateDirectory("D:\\JSW\\NotBilled\\");

            if (excel.Exists)
            {
                excel.Delete();
            }
            using (ExcelPackage pck = new ExcelPackage(new System.IO.FileInfo("D:\\JSW\\NotBilled\\Bills_" + DateTime.Now.Date.ToString().Substring(0, 10).Replace('/', '-') + ".xlsx")))
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("NotBilled");
                ws.Cells["A1"].LoadFromDataTable(((DataTable)GvReport.DataSource), true);
                ws.Cells.AutoFitColumns();

                // Add some styling
                using (ExcelRange rng = ws.Cells[1, 1, 1, GvReport .Columns.Count])
                {
                    rng.Style.Font.Bold = true;
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));
                    rng.Style.Font.Color.SetColor(System.Drawing.Color.White);
                }

                pck.Save();

            }
            DialogResult ans = MessageBox.Show("File Downloaded at " + filename + Environment.NewLine + "Do you want to open?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(filename);
            }
        }

    }
}
