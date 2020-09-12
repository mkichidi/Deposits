namespace Deposits
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DdlTDSAccount = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DDLAccountSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GvShipment = new System.Windows.Forms.DataGridView();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdTDS = new System.Windows.Forms.RadioButton();
            this.RdIntrest = new System.Windows.Forms.RadioButton();
            this.RdDeposit = new System.Windows.Forms.RadioButton();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DdlAccount = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtShipmentID = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvShipment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNew,
            this.tsBtnEdit,
            this.tsBtnSave,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 39);
            this.toolStrip1.TabIndex = 123;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNew.Image")));
            this.tsBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.Size = new System.Drawing.Size(67, 36);
            this.tsBtnNew.Text = "&New";
            this.tsBtnNew.ToolTipText = "New";
            this.tsBtnNew.Click += new System.EventHandler(this.tsBtnNew_Click);
            // 
            // tsBtnEdit
            // 
            this.tsBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEdit.Image")));
            this.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEdit.Name = "tsBtnEdit";
            this.tsBtnEdit.Size = new System.Drawing.Size(63, 36);
            this.tsBtnEdit.Text = "&Edit";
            this.tsBtnEdit.ToolTipText = "Edit";
            this.tsBtnEdit.Click += new System.EventHandler(this.tsBtnEdit_Click);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(67, 36);
            this.tsBtnSave.Text = "&Save";
            this.tsBtnSave.Click += new System.EventHandler(this.tsBtnSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 36);
            this.toolStripButton1.Text = "E&xit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // DdlTDSAccount
            // 
            this.DdlTDSAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DdlTDSAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DdlTDSAccount.Enabled = false;
            this.DdlTDSAccount.FormattingEnabled = true;
            this.DdlTDSAccount.Location = new System.Drawing.Point(510, 154);
            this.DdlTDSAccount.Name = "DdlTDSAccount";
            this.DdlTDSAccount.Size = new System.Drawing.Size(244, 21);
            this.DdlTDSAccount.TabIndex = 226;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(324, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 18);
            this.label8.TabIndex = 227;
            this.label8.Text = "TDS deduction Account no";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(484, 198);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(167, 24);
            this.txtBalance.TabIndex = 224;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 225;
            this.label7.Text = "Balance";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DDLAccountSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GvShipment);
            this.groupBox2.Controls.Add(this.DtTo);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1007, 367);
            this.groupBox2.TabIndex = 223;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 193;
            this.label3.Text = "Account no";
            this.label3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(692, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 192;
            this.label6.Text = "To";
            this.label6.Visible = false;
            // 
            // DDLAccountSearch
            // 
            this.DDLAccountSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DDLAccountSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DDLAccountSearch.FormattingEnabled = true;
            this.DDLAccountSearch.Location = new System.Drawing.Point(374, 14);
            this.DDLAccountSearch.Name = "DDLAccountSearch";
            this.DDLAccountSearch.Size = new System.Drawing.Size(121, 21);
            this.DDLAccountSearch.TabIndex = 181;
            this.DDLAccountSearch.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 189;
            this.label2.Text = "Date";
            this.label2.Visible = false;
            // 
            // GvShipment
            // 
            this.GvShipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GvShipment.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvShipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GvShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvShipment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GvShipment.Location = new System.Drawing.Point(15, 41);
            this.GvShipment.Name = "GvShipment";
            this.GvShipment.Size = new System.Drawing.Size(983, 317);
            this.GvShipment.TabIndex = 125;
            this.GvShipment.SelectionChanged += new System.EventHandler(this.GvShipment_SelectionChanged);
            // 
            // DtTo
            // 
            this.DtTo.Location = new System.Drawing.Point(724, 14);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(115, 20);
            this.DtTo.TabIndex = 191;
            this.DtTo.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 190;
            this.dateTimePicker1.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(852, 93);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(167, 75);
            this.txtRemarks.TabIndex = 221;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 222;
            this.label1.Text = "Remarks";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAmount.Location = new System.Drawing.Point(224, 199);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(167, 24);
            this.TxtAmount.TabIndex = 219;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(161, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 220;
            this.label12.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(5, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 218;
            this.label4.Text = "Transaction";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdTDS);
            this.groupBox1.Controls.Add(this.RdIntrest);
            this.groupBox1.Controls.Add(this.RdDeposit);
            this.groupBox1.Location = new System.Drawing.Point(40, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 47);
            this.groupBox1.TabIndex = 217;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction type";
            // 
            // RdTDS
            // 
            this.RdTDS.AutoSize = true;
            this.RdTDS.Location = new System.Drawing.Point(156, 19);
            this.RdTDS.Name = "RdTDS";
            this.RdTDS.Size = new System.Drawing.Size(47, 17);
            this.RdTDS.TabIndex = 2;
            this.RdTDS.Text = "TDS";
            this.RdTDS.UseVisualStyleBackColor = true;
            this.RdTDS.CheckedChanged += new System.EventHandler(this.RdTDS_CheckedChanged);
            // 
            // RdIntrest
            // 
            this.RdIntrest.AutoSize = true;
            this.RdIntrest.Location = new System.Drawing.Point(96, 19);
            this.RdIntrest.Name = "RdIntrest";
            this.RdIntrest.Size = new System.Drawing.Size(54, 17);
            this.RdIntrest.TabIndex = 1;
            this.RdIntrest.Text = "Intrest";
            this.RdIntrest.UseVisualStyleBackColor = true;
            // 
            // RdDeposit
            // 
            this.RdDeposit.AutoSize = true;
            this.RdDeposit.Checked = true;
            this.RdDeposit.Location = new System.Drawing.Point(25, 20);
            this.RdDeposit.Name = "RdDeposit";
            this.RdDeposit.Size = new System.Drawing.Size(61, 17);
            this.RdDeposit.TabIndex = 0;
            this.RdDeposit.TabStop = true;
            this.RdDeposit.Text = "Deposit";
            this.RdDeposit.UseVisualStyleBackColor = true;
            // 
            // DtFrom
            // 
            this.DtFrom.Location = new System.Drawing.Point(639, 96);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(115, 20);
            this.DtFrom.TabIndex = 216;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 215;
            this.label5.Text = "Date";
            // 
            // DdlAccount
            // 
            this.DdlAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DdlAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DdlAccount.FormattingEnabled = true;
            this.DdlAccount.Location = new System.Drawing.Point(308, 95);
            this.DdlAccount.Name = "DdlAccount";
            this.DdlAccount.Size = new System.Drawing.Size(244, 21);
            this.DdlAccount.TabIndex = 213;
            this.DdlAccount.SelectedIndexChanged += new System.EventHandler(this.DdlAccount_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 214;
            this.label9.Text = "Account no";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 228;
            this.label10.Text = "Deposit ID";
            // 
            // TxtShipmentID
            // 
            this.TxtShipmentID.Enabled = false;
            this.TxtShipmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtShipmentID.Location = new System.Drawing.Point(103, 92);
            this.TxtShipmentID.Name = "TxtShipmentID";
            this.TxtShipmentID.Size = new System.Drawing.Size(100, 24);
            this.TxtShipmentID.TabIndex = 229;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 620);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtShipmentID);
            this.Controls.Add(this.DdlTDSAccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DdlAccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvShipment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripButton tsBtnEdit;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox DdlTDSAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DDLAccountSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GvShipment;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdTDS;
        private System.Windows.Forms.RadioButton RdIntrest;
        private System.Windows.Forms.RadioButton RdDeposit;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DdlAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtShipmentID;
    }
}