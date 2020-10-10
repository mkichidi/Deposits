namespace Deposits.Reports
{
    partial class DeadLine
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
            this.label3 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtDeadLine = new System.Windows.Forms.DateTimePicker();
            this.DdlAccountHolder = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.GvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DdlAccountHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 259;
            this.label3.Text = "To";
            // 
            // DtTo
            // 
            this.DtTo.Location = new System.Drawing.Point(365, 119);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(119, 20);
            this.DtTo.TabIndex = 258;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 257;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 256;
            this.label2.Text = "Dead Line Date";
            // 
            // DtFrom
            // 
            this.DtFrom.Location = new System.Drawing.Point(201, 119);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(116, 20);
            this.DtFrom.TabIndex = 255;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(514, 79);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(75, 23);
            this.BtnExcel.TabIndex = 254;
            this.BtnExcel.Text = "Excel";
            this.BtnExcel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 253;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 252;
            this.label1.Text = "Dead Line Date";
            // 
            // DtDeadLine
            // 
            this.DtDeadLine.Location = new System.Drawing.Point(201, 83);
            this.DtDeadLine.Name = "DtDeadLine";
            this.DtDeadLine.Size = new System.Drawing.Size(116, 20);
            this.DtDeadLine.TabIndex = 251;
            // 
            // DdlAccountHolder
            // 
            this.DdlAccountHolder.EditValue = "";
            this.DdlAccountHolder.Location = new System.Drawing.Point(149, 39);
            this.DdlAccountHolder.Name = "DdlAccountHolder";
            this.DdlAccountHolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DdlAccountHolder.Size = new System.Drawing.Size(242, 20);
            this.DdlAccountHolder.TabIndex = 261;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 260;
            this.label4.Text = "Account Holder";
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
            this.GvReport.Location = new System.Drawing.Point(12, 168);
            this.GvReport.Name = "GvReport";
            this.GvReport.Size = new System.Drawing.Size(858, 219);
            this.GvReport.TabIndex = 262;
            // 
            // DeadLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 428);
            this.Controls.Add(this.GvReport);
            this.Controls.Add(this.DdlAccountHolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtFrom);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtDeadLine);
            this.Name = "DeadLine";
            this.Text = "DeadLine";
            ((System.ComponentModel.ISupportInitialize)(this.DdlAccountHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtDeadLine;
        private DevExpress.XtraEditors.CheckedComboBoxEdit DdlAccountHolder;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView GvReport;
    }
}