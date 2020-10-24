namespace Deposits
{
    partial class StatementGenerator
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
            this.label8 = new System.Windows.Forms.Label();
            this.DdlAccount = new System.Windows.Forms.ComboBox();
            this.GvReport = new System.Windows.Forms.DataGridView();
            this.BtnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 246;
            this.label8.Text = "Account";
            // 
            // DdlAccount
            // 
            this.DdlAccount.FormattingEnabled = true;
            this.DdlAccount.Location = new System.Drawing.Point(122, 34);
            this.DdlAccount.Name = "DdlAccount";
            this.DdlAccount.Size = new System.Drawing.Size(263, 21);
            this.DdlAccount.TabIndex = 247;
            this.DdlAccount.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GvReport
            // 
            this.GvReport.AllowUserToAddRows = false;
            this.GvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GvReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvReport.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.GvReport.Location = new System.Drawing.Point(12, 92);
            this.GvReport.Name = "GvReport";
            this.GvReport.Size = new System.Drawing.Size(761, 219);
            this.GvReport.TabIndex = 248;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(615, 12);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(103, 23);
            this.BtnExcel.TabIndex = 249;
            this.BtnExcel.Text = "Export To Excel";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // StatementGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 397);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.GvReport);
            this.Controls.Add(this.DdlAccount);
            this.Controls.Add(this.label8);
            this.Name = "StatementGenerator";
            this.Text = "StatementGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.GvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DdlAccount;
        public System.Windows.Forms.DataGridView GvReport;
        private System.Windows.Forms.Button BtnExcel;
    }
}