namespace Deposits
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.GvDestination = new System.Windows.Forms.DataGridView();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAccountHolderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBankID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNickNameSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBankSearch = new System.Windows.Forms.TextBox();
            this.TxtAccountNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DDLBank = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNickName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.sc = new System.Windows.Forms.Label();
            this.TxtROI = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtNameOFScheme = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtMaturityAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DtIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.DtMaturityDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtBondNo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvDestination)).BeginInit();
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
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 39);
            this.toolStrip1.TabIndex = 93;
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
            // tsBtnExit
            // 
            this.tsBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExit.Image")));
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(61, 36);
            this.tsBtnExit.Text = "E&xit";
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // GvDestination
            // 
            this.GvDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GvDestination.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvDestination.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvDestination.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GvDestination.Location = new System.Drawing.Point(14, 49);
            this.GvDestination.Name = "GvDestination";
            this.GvDestination.Size = new System.Drawing.Size(954, 185);
            this.GvDestination.TabIndex = 9;
            this.GvDestination.SelectionChanged += new System.EventHandler(this.GvDestination_SelectionChanged);
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Checked = true;
            this.ChkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActive.Location = new System.Drawing.Point(792, 223);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(66, 22);
            this.ChkActive.TabIndex = 3;
            this.ChkActive.Text = "Active";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(792, 113);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(192, 26);
            this.TxtDescription.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(707, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 95;
            this.label6.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 94;
            this.label4.Text = "Accounts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Tan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(-184, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 92;
            this.label7.Text = "Vehicle";
            // 
            // TxtAccountHolderName
            // 
            this.TxtAccountHolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountHolderName.Location = new System.Drawing.Point(472, 86);
            this.TxtAccountHolderName.Name = "TxtAccountHolderName";
            this.TxtAccountHolderName.Size = new System.Drawing.Size(172, 24);
            this.TxtAccountHolderName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 90;
            this.label3.Text = "Account Holder Name";
            // 
            // TxtBankID
            // 
            this.TxtBankID.Enabled = false;
            this.TxtBankID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBankID.Location = new System.Drawing.Point(108, 86);
            this.TxtBankID.Name = "TxtBankID";
            this.TxtBankID.Size = new System.Drawing.Size(100, 24);
            this.TxtBankID.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Accounts ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-184, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 87;
            this.label1.Text = "Vehicle ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.TxtType);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.GvDestination);
            this.groupBox1.Controls.Add(this.TxtNickNameSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtBankSearch);
            this.groupBox1.Location = new System.Drawing.Point(20, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 240);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // TxtType
            // 
            this.TxtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtType.Location = new System.Drawing.Point(629, 19);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(115, 24);
            this.TxtType.TabIndex = 119;
            this.TxtType.TextChanged += new System.EventHandler(this.TxtType_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(586, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 18);
            this.label14.TabIndex = 120;
            this.label14.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 18);
            this.label12.TabIndex = 119;
            this.label12.Text = "Nick Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(248, -233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 18);
            this.label11.TabIndex = 118;
            this.label11.Text = "Account Holder Name";
            // 
            // TxtNickNameSearch
            // 
            this.TxtNickNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNickNameSearch.Location = new System.Drawing.Point(436, 19);
            this.TxtNickNameSearch.Name = "TxtNickNameSearch";
            this.TxtNickNameSearch.Size = new System.Drawing.Size(128, 24);
            this.TxtNickNameSearch.TabIndex = 8;
            this.TxtNickNameSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 101;
            this.label5.Text = "Holder Name";
            // 
            // TxtBankSearch
            // 
            this.TxtBankSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBankSearch.Location = new System.Drawing.Point(184, 18);
            this.TxtBankSearch.Name = "TxtBankSearch";
            this.TxtBankSearch.Size = new System.Drawing.Size(143, 24);
            this.TxtBankSearch.TabIndex = 7;
            this.TxtBankSearch.TextChanged += new System.EventHandler(this.TxtDestinationSearch_TextChanged);
            // 
            // TxtAccountNo
            // 
            this.TxtAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountNo.Location = new System.Drawing.Point(792, 84);
            this.TxtAccountNo.Name = "TxtAccountNo";
            this.TxtAccountNo.Size = new System.Drawing.Size(192, 24);
            this.TxtAccountNo.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(704, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 107;
            this.label10.Text = "Account No";
            // 
            // DDLBank
            // 
            this.DDLBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DDLBank.FormattingEnabled = true;
            this.DDLBank.Location = new System.Drawing.Point(108, 118);
            this.DDLBank.Name = "DDLBank";
            this.DDLBank.Size = new System.Drawing.Size(121, 21);
            this.DDLBank.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 114;
            this.label8.Text = "Bank";
            // 
            // TxtNickName
            // 
            this.TxtNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNickName.Location = new System.Drawing.Point(108, 148);
            this.TxtNickName.Name = "TxtNickName";
            this.TxtNickName.Size = new System.Drawing.Size(172, 24);
            this.TxtNickName.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 116;
            this.label9.Text = "Nick Name";
            // 
            // txtBranch
            // 
            this.txtBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranch.Location = new System.Drawing.Point(472, 116);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(172, 24);
            this.txtBranch.TabIndex = 132;
            // 
            // sc
            // 
            this.sc.AutoSize = true;
            this.sc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc.Location = new System.Drawing.Point(416, 119);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(55, 18);
            this.sc.TabIndex = 133;
            this.sc.Text = "Branch";
            // 
            // TxtROI
            // 
            this.TxtROI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtROI.Location = new System.Drawing.Point(108, 188);
            this.TxtROI.Name = "TxtROI";
            this.TxtROI.Size = new System.Drawing.Size(121, 24);
            this.TxtROI.TabIndex = 134;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 18);
            this.label15.TabIndex = 135;
            this.label15.Text = "Rate of Intrest";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(474, 185);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(121, 24);
            this.txtDuration.TabIndex = 136;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(338, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 18);
            this.label16.TabIndex = 137;
            this.label16.Text = "Duration in months";
            // 
            // TxtNameOFScheme
            // 
            this.TxtNameOFScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameOFScheme.Location = new System.Drawing.Point(792, 145);
            this.TxtNameOFScheme.Name = "TxtNameOFScheme";
            this.TxtNameOFScheme.Size = new System.Drawing.Size(192, 24);
            this.TxtNameOFScheme.TabIndex = 138;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(666, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 18);
            this.label17.TabIndex = 139;
            this.label17.Text = "Name of Scheme";
            // 
            // TxtMaturityAmount
            // 
            this.TxtMaturityAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaturityAmount.Location = new System.Drawing.Point(792, 182);
            this.TxtMaturityAmount.Name = "TxtMaturityAmount";
            this.TxtMaturityAmount.Size = new System.Drawing.Size(121, 24);
            this.TxtMaturityAmount.TabIndex = 140;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(675, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 18);
            this.label18.TabIndex = 141;
            this.label18.Text = "Maturity Amount";
            // 
            // DtIssueDate
            // 
            this.DtIssueDate.Location = new System.Drawing.Point(108, 227);
            this.DtIssueDate.Name = "DtIssueDate";
            this.DtIssueDate.Size = new System.Drawing.Size(115, 20);
            this.DtIssueDate.TabIndex = 218;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(29, 228);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 18);
            this.label19.TabIndex = 217;
            this.label19.Text = "Issue Date";
            // 
            // DtMaturityDate
            // 
            this.DtMaturityDate.Location = new System.Drawing.Point(472, 226);
            this.DtMaturityDate.Name = "DtMaturityDate";
            this.DtMaturityDate.Size = new System.Drawing.Size(115, 20);
            this.DtMaturityDate.TabIndex = 220;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(374, 227);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 18);
            this.label20.TabIndex = 219;
            this.label20.Text = "Maturity Date";
            // 
            // TxtBondNo
            // 
            this.TxtBondNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBondNo.Location = new System.Drawing.Point(472, 148);
            this.TxtBondNo.Name = "TxtBondNo";
            this.TxtBondNo.Size = new System.Drawing.Size(121, 24);
            this.TxtBondNo.TabIndex = 221;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(403, 151);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 18);
            this.label21.TabIndex = 222;
            this.label21.Text = "Bond No";
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 522);
            this.Controls.Add(this.TxtBondNo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.DtMaturityDate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DtIssueDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TxtMaturityAmount);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtNameOFScheme);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtROI);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.TxtNickName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DDLBank);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtAccountNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ChkActive);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtAccountHolderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBankID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvDestination)).EndInit();
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
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.DataGridView GvDestination;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAccountHolderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBankID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBankSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAccountNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DDLBank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNickName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNickNameSearch;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.TextBox TxtROI;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtNameOFScheme;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtMaturityAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker DtIssueDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker DtMaturityDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtBondNo;
        private System.Windows.Forms.Label label21;
    }
}