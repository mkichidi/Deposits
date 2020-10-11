namespace Deposits
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CtrlBtnAppClose = new System.Windows.Forms.ToolStripButton();
            this.CtrlBtnMinimize = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountHoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditJSWBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.jSWNotBilled = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.serachOnAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statementGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlBtnAppClose
            // 
            this.CtrlBtnAppClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CtrlBtnAppClose.Name = "CtrlBtnAppClose";
            this.CtrlBtnAppClose.Size = new System.Drawing.Size(40, 24);
            this.CtrlBtnAppClose.Text = "Close";
            this.CtrlBtnAppClose.ToolTipText = "Calculator";
            // 
            // CtrlBtnMinimize
            // 
            this.CtrlBtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.CtrlBtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CtrlBtnMinimize.FlatAppearance.BorderSize = 0;
            this.CtrlBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlBtnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlBtnMinimize.Location = new System.Drawing.Point(758, 49);
            this.CtrlBtnMinimize.Name = "CtrlBtnMinimize";
            this.CtrlBtnMinimize.Size = new System.Drawing.Size(35, 31);
            this.CtrlBtnMinimize.TabIndex = 60;
            this.CtrlBtnMinimize.Text = "_";
            this.CtrlBtnMinimize.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.EditJSWBilling,
            this.toolStripMenuItem2,
            this.reportsToolStripMenuItem,
            this.CtrlBtnAppClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(823, 31);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "CtrlMainmenustrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.documentsToolStripMenuItem,
            this.accountHoldersToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 27);
            this.toolStripMenuItem1.Text = "Masters";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItem3.Text = "Accounts";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.documentsToolStripMenuItem.Text = "Documents";
            this.documentsToolStripMenuItem.Click += new System.EventHandler(this.documentsToolStripMenuItem_Click);
            // 
            // accountHoldersToolStripMenuItem
            // 
            this.accountHoldersToolStripMenuItem.Name = "accountHoldersToolStripMenuItem";
            this.accountHoldersToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.accountHoldersToolStripMenuItem.Text = "Account Holders";
            this.accountHoldersToolStripMenuItem.Click += new System.EventHandler(this.accountHoldersToolStripMenuItem_Click);
            // 
            // EditJSWBilling
            // 
            this.EditJSWBilling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSWNotBilled});
            this.EditJSWBilling.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditJSWBilling.Name = "EditJSWBilling";
            this.EditJSWBilling.Size = new System.Drawing.Size(109, 27);
            this.EditJSWBilling.Text = "Transactions";
            // 
            // jSWNotBilled
            // 
            this.jSWNotBilled.Name = "jSWNotBilled";
            this.jSWNotBilled.Size = new System.Drawing.Size(157, 24);
            this.jSWNotBilled.Text = "Trasactions";
            this.jSWNotBilled.Click += new System.EventHandler(this.jSWNotBilled_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serachOnAllToolStripMenuItem,
            this.deadLineToolStripMenuItem,
            this.statementGeneratorToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(76, 27);
            this.toolStripMenuItem2.Text = "Reports";
            // 
            // serachOnAllToolStripMenuItem
            // 
            this.serachOnAllToolStripMenuItem.Name = "serachOnAllToolStripMenuItem";
            this.serachOnAllToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.serachOnAllToolStripMenuItem.Text = "Search On All";
            this.serachOnAllToolStripMenuItem.Click += new System.EventHandler(this.serachOnAllToolStripMenuItem_Click);
            // 
            // deadLineToolStripMenuItem
            // 
            this.deadLineToolStripMenuItem.Name = "deadLineToolStripMenuItem";
            this.deadLineToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.deadLineToolStripMenuItem.Text = "DeadLine";
            this.deadLineToolStripMenuItem.Click += new System.EventHandler(this.deadLineToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(12, 27);
            // 
            // statementGeneratorToolStripMenuItem
            // 
            this.statementGeneratorToolStripMenuItem.Name = "statementGeneratorToolStripMenuItem";
            this.statementGeneratorToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.statementGeneratorToolStripMenuItem.Text = "Statement Generator";
            this.statementGeneratorToolStripMenuItem.Click += new System.EventHandler(this.statementGeneratorToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 340);
            this.Controls.Add(this.CtrlBtnMinimize);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Deposit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton CtrlBtnAppClose;
        private System.Windows.Forms.Button CtrlBtnMinimize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditJSWBilling;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSWNotBilled;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serachOnAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountHoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statementGeneratorToolStripMenuItem;
    }
}