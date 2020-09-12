using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;

namespace Deposits
{
    public partial class PDFViwer : Form
    {
        string sharePath = "\\\\BJ01\\DepositDocuments";

        public PDFViwer()
        {
            InitializeComponent();
            NetworkShare.DisconnectFromShare(sharePath, true); //Remove this line
            NetworkShare.ConnectToShare(sharePath, "ShareUser", "sharing"); //Connect with the new credentials
            axAcroPDF1.src = PropertyDatatable.PdFPath;
            NetworkShare.DisconnectFromShare(sharePath, false); //Remove this line also

            LblFileName.Text = PropertyDatatable.PdFPath.Split('\\')[PropertyDatatable.PdFPath.Split('\\').Count() - 1];
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            string download = string.Empty;
            string userPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            DirectoryInfo user = new DirectoryInfo(userPath);
            if (user.Exists)
            {
                // Identify the "%USERPROFILE%\Downloads" directory on Windows Vista, 7, 8 systems.
                DirectoryInfo downloads = new DirectoryInfo(user + @"\Downloads");
                if (downloads.Exists)
                {
                    // return the full path "C:\Users\USERNAME\Downloads"
                    download = downloads.FullName;
                }
                else
                {
                    // Couldn't find it, maybe they're on Windows XP
                    string xpDocs = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                    DirectoryInfo xpDownloads = new DirectoryInfo(xpDocs + @"\Downloads");
                    if (xpDownloads.Exists)
                    {
                        // return the full path "C:\Documents and Settings\USERNAME\My Documents\Downloads"
                        download = xpDownloads.FullName;
                    }
                    else
                    {
                        // Couldn't identify a "Downloads" directory in either location
                        throw new DirectoryNotFoundException("Cannot identify the users 'Downloads' directory.");
                    }
                }
            }



            if (File.Exists(download + "\\" + LblFileName.Text))
            {
                File.Delete(download + "\\" + LblFileName.Text);
            }

            NetworkShare.DisconnectFromShare("\\\\BJ01\\PropertyDocuments", true); //Remove this line
            NetworkShare.ConnectToShare("\\\\BJ01\\PropertyDocuments", "ShareUser", "sharing"); //Connect with the new credentials

            File.Copy(PropertyDatatable.PdFPath, download + "\\" + LblFileName.Text);

            NetworkShare.DisconnectFromShare("\\\\BJ01\\PropertyDocuments", false); //Remove this line also


            DialogResult ans = MessageBox.Show("File Downloaded at " + download + "\\" + LblFileName.Text + Environment.NewLine + "Do you want to open?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(download + "\\" + LblFileName.Text);
            }
        }
    }
}
