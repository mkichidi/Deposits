namespace Deposits
{
    partial class Documents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtDocuments = new System.Windows.Forms.RichTextBox();
            this.BtnViewDocuments = new System.Windows.Forms.Button();
            this.BtnAddDocuments = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDocuName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DdlAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRemarks = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.GvTranport = new System.Windows.Forms.DataGridView();
            this.TxtTransportSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTranport)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDocuments
            // 
            this.TxtDocuments.Enabled = false;
            this.TxtDocuments.Location = new System.Drawing.Point(101, 108);
            this.TxtDocuments.Name = "TxtDocuments";
            this.TxtDocuments.Size = new System.Drawing.Size(334, 59);
            this.TxtDocuments.TabIndex = 4;
            this.TxtDocuments.Text = "";
            // 
            // BtnViewDocuments
            // 
            this.BtnViewDocuments.Location = new System.Drawing.Point(297, 173);
            this.BtnViewDocuments.Name = "BtnViewDocuments";
            this.BtnViewDocuments.Size = new System.Drawing.Size(97, 23);
            this.BtnViewDocuments.TabIndex = 6;
            this.BtnViewDocuments.Text = "View Documents";
            this.BtnViewDocuments.UseVisualStyleBackColor = true;
            this.BtnViewDocuments.Click += new System.EventHandler(this.BtnViewDocuments_Click);
            // 
            // BtnAddDocuments
            // 
            this.BtnAddDocuments.Location = new System.Drawing.Point(141, 173);
            this.BtnAddDocuments.Name = "BtnAddDocuments";
            this.BtnAddDocuments.Size = new System.Drawing.Size(97, 23);
            this.BtnAddDocuments.TabIndex = 5;
            this.BtnAddDocuments.Text = "Add Documents";
            this.BtnAddDocuments.UseVisualStyleBackColor = true;
            this.BtnAddDocuments.Click += new System.EventHandler(this.BtnAddDocuments_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 140;
            this.label4.Text = "Add Documents";
            // 
            // TxtDocuName
            // 
            this.TxtDocuName.Location = new System.Drawing.Point(473, 73);
            this.TxtDocuName.Name = "TxtDocuName";
            this.TxtDocuName.Size = new System.Drawing.Size(160, 20);
            this.TxtDocuName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 369;
            this.label3.Text = "Account";
            // 
            // DdlAccount
            // 
            this.DdlAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DdlAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DdlAccount.FormattingEnabled = true;
            this.DdlAccount.Location = new System.Drawing.Point(75, 71);
            this.DdlAccount.Name = "DdlAccount";
            this.DdlAccount.Size = new System.Drawing.Size(248, 21);
            this.DdlAccount.TabIndex = 1;
            this.DdlAccount.SelectedIndexChanged += new System.EventHandler(this.DdlProperty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 370;
            this.label1.Text = "Document Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 372;
            this.label2.Text = "Remarks";
            // 
            // TxtRemarks
            // 
            this.TxtRemarks.Location = new System.Drawing.Point(726, 71);
            this.TxtRemarks.Name = "TxtRemarks";
            this.TxtRemarks.Size = new System.Drawing.Size(128, 20);
            this.TxtRemarks.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.BtnExcel);
            this.groupBox2.Controls.Add(this.GvTranport);
            this.groupBox2.Controls.Add(this.TxtTransportSearch);
            this.groupBox2.Location = new System.Drawing.Point(17, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 239);
            this.groupBox2.TabIndex = 373;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(139, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 18);
            this.label13.TabIndex = 368;
            this.label13.Text = "Tenant Name";
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(500, 23);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(98, 23);
            this.BtnExcel.TabIndex = 9;
            this.BtnExcel.Text = "Export to Excel";
            this.BtnExcel.UseVisualStyleBackColor = true;
            // 
            // GvTranport
            // 
            this.GvTranport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GvTranport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvTranport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GvTranport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvTranport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GvTranport.Location = new System.Drawing.Point(21, 56);
            this.GvTranport.Name = "GvTranport";
            this.GvTranport.Size = new System.Drawing.Size(798, 163);
            this.GvTranport.TabIndex = 10;
            this.GvTranport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvTranport_CellClick);
            // 
            // TxtTransportSearch
            // 
            this.TxtTransportSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTransportSearch.Location = new System.Drawing.Point(238, 21);
            this.TxtTransportSearch.Name = "TxtTransportSearch";
            this.TxtTransportSearch.Size = new System.Drawing.Size(172, 24);
            this.TxtTransportSearch.TabIndex = 8;
            this.TxtTransportSearch.TextChanged += new System.EventHandler(this.TxtTransportSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save Documents";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DdlAccount);
            this.Controls.Add(this.TxtDocuName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDocuments);
            this.Controls.Add(this.BtnViewDocuments);
            this.Controls.Add(this.BtnAddDocuments);
            this.Name = "Documents";
            this.Text = "Documents";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTranport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtDocuments;
        private System.Windows.Forms.Button BtnViewDocuments;
        private System.Windows.Forms.Button BtnAddDocuments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDocuName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DdlAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRemarks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.DataGridView GvTranport;
        private System.Windows.Forms.TextBox TxtTransportSearch;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}