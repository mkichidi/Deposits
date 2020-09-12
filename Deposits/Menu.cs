﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposits
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
          
        }

        private bool CheckForDuplicateForm(Form newForm)
        {
            bool bValue = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == newForm.GetType())
                {
                    frm.Activate();
                    bValue = true;
                }
            }
            return bValue;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Accounts Accounts = new Accounts();
            bool frmPresent = CheckForDuplicateForm(Accounts);
            if (frmPresent)
                return;
            else if (!frmPresent)
            {
                Accounts.Show();
            }
        }

        private void jSWNotBilled_Click(object sender, EventArgs e)
        {
            Transactions Accounts = new Transactions();
            bool frmPresent = CheckForDuplicateForm(Accounts);
            if (frmPresent)
                return;
            else if (!frmPresent)
            {
                Accounts.Show();
            }
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents Accounts = new Documents();
            bool frmPresent = CheckForDuplicateForm(Accounts);
            if (frmPresent)
                return;
            else if (!frmPresent)
            {
                Accounts.Show();
            }
        }
    }
}
