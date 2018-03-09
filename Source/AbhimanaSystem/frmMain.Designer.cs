namespace AbhimanaSystem
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDataList = new MetroFramework.Controls.MetroGrid();
            this.tblcbrdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abhimana_dbDataSet = new AbhimanaSystem.abhimana_dbDataSet();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new MetroFramework.Controls.MetroButton();
            this.btnUpdateChild = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.txtChildEdu = new MetroFramework.Controls.MetroTextBox();
            this.txtDisabilities = new MetroFramework.Controls.MetroTextBox();
            this.btnNewChild = new MetroFramework.Controls.MetroButton();
            this.DateTime_Birthday = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbx_House = new MetroFramework.Controls.MetroComboBox();
            this.txtDonation_NGO = new MetroFramework.Controls.MetroTextBox();
            this.txtDonation_Gov = new MetroFramework.Controls.MetroTextBox();
            this.txtSanitation = new MetroFramework.Controls.MetroTextBox();
            this.txtRehabilitation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbl_cbrdataTableAdapter = new AbhimanaSystem.abhimana_dbDataSetTableAdapters.tbl_cbrdataTableAdapter();
            this.btnLoadData = new MetroFramework.Controls.MetroButton();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcbrdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abhimana_dbDataSet)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDataList
            // 
            this.dgvDataList.AllowUserToAddRows = false;
            this.dgvDataList.AllowUserToDeleteRows = false;
            this.dgvDataList.AllowUserToResizeRows = false;
            this.dgvDataList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDataList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataList.EnableHeadersVisualStyles = false;
            this.dgvDataList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDataList.Location = new System.Drawing.Point(15, 178);
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(973, 527);
            this.dgvDataList.TabIndex = 0;
            // 
            // tblcbrdataBindingSource
            // 
            this.tblcbrdataBindingSource.DataMember = "tbl_cbrdata";
            this.tblcbrdataBindingSource.DataSource = this.abhimana_dbDataSet;
            // 
            // abhimana_dbDataSet
            // 
            this.abhimana_dbDataSet.DataSetName = "abhimana_dbDataSet";
            this.abhimana_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(169, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::AbhimanaSystem.Properties.Resources.LoginPage_LoginIcon;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "Change Password";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Image = global::AbhimanaSystem.Properties.Resources.not_successfully;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fileToolStripMenuItem.Text = "Exit";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Orange;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(15, 13);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 31);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseCustomBackColor = true;
            this.btnMenu.UseCustomForeColor = true;
            this.btnMenu.UseSelectable = true;
            this.btnMenu.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnUpdateChild
            // 
            this.btnUpdateChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateChild.ForeColor = System.Drawing.Color.White;
            this.btnUpdateChild.Location = new System.Drawing.Point(177, 13);
            this.btnUpdateChild.Name = "btnUpdateChild";
            this.btnUpdateChild.Size = new System.Drawing.Size(75, 31);
            this.btnUpdateChild.TabIndex = 4;
            this.btnUpdateChild.Text = "Update";
            this.btnUpdateChild.UseCustomBackColor = true;
            this.btnUpdateChild.UseCustomForeColor = true;
            this.btnUpdateChild.UseSelectable = true;
            this.btnUpdateChild.Click += new System.EventHandler(this.btnUpdateChild_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(96, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseCustomBackColor = true;
            this.btnRefresh.UseCustomForeColor = true;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtChildEdu
            // 
            // 
            // 
            // 
            this.txtChildEdu.CustomButton.Image = null;
            this.txtChildEdu.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.txtChildEdu.CustomButton.Name = "";
            this.txtChildEdu.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtChildEdu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChildEdu.CustomButton.TabIndex = 1;
            this.txtChildEdu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChildEdu.CustomButton.UseSelectable = true;
            this.txtChildEdu.CustomButton.Visible = false;
            this.txtChildEdu.Lines = new string[0];
            this.txtChildEdu.Location = new System.Drawing.Point(50, 17);
            this.txtChildEdu.MaxLength = 32767;
            this.txtChildEdu.Multiline = true;
            this.txtChildEdu.Name = "txtChildEdu";
            this.txtChildEdu.PasswordChar = '\0';
            this.txtChildEdu.PromptText = "Child in Edu";
            this.txtChildEdu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChildEdu.SelectedText = "";
            this.txtChildEdu.SelectionLength = 0;
            this.txtChildEdu.SelectionStart = 0;
            this.txtChildEdu.ShortcutsEnabled = true;
            this.txtChildEdu.Size = new System.Drawing.Size(202, 40);
            this.txtChildEdu.TabIndex = 14;
            this.txtChildEdu.UseSelectable = true;
            this.txtChildEdu.WaterMark = "Child in Edu";
            this.txtChildEdu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChildEdu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChildEdu.TextChanged += new System.EventHandler(this.txtChildEdu_TextChanged);
            // 
            // txtDisabilities
            // 
            // 
            // 
            // 
            this.txtDisabilities.CustomButton.Image = null;
            this.txtDisabilities.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.txtDisabilities.CustomButton.Name = "";
            this.txtDisabilities.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDisabilities.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDisabilities.CustomButton.TabIndex = 1;
            this.txtDisabilities.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDisabilities.CustomButton.UseSelectable = true;
            this.txtDisabilities.CustomButton.Visible = false;
            this.txtDisabilities.Lines = new string[0];
            this.txtDisabilities.Location = new System.Drawing.Point(50, 66);
            this.txtDisabilities.MaxLength = 32767;
            this.txtDisabilities.Multiline = true;
            this.txtDisabilities.Name = "txtDisabilities";
            this.txtDisabilities.PasswordChar = '\0';
            this.txtDisabilities.PromptText = "Disabilities";
            this.txtDisabilities.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDisabilities.SelectedText = "";
            this.txtDisabilities.SelectionLength = 0;
            this.txtDisabilities.SelectionStart = 0;
            this.txtDisabilities.ShortcutsEnabled = true;
            this.txtDisabilities.Size = new System.Drawing.Size(202, 40);
            this.txtDisabilities.TabIndex = 16;
            this.txtDisabilities.UseSelectable = true;
            this.txtDisabilities.WaterMark = "Disabilities";
            this.txtDisabilities.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDisabilities.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDisabilities.TextChanged += new System.EventHandler(this.txtDisabilities_TextChanged);
            // 
            // btnNewChild
            // 
            this.btnNewChild.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewChild.ForeColor = System.Drawing.Color.White;
            this.btnNewChild.Location = new System.Drawing.Point(258, 13);
            this.btnNewChild.Name = "btnNewChild";
            this.btnNewChild.Size = new System.Drawing.Size(75, 31);
            this.btnNewChild.TabIndex = 17;
            this.btnNewChild.Text = "New";
            this.btnNewChild.UseCustomBackColor = true;
            this.btnNewChild.UseCustomForeColor = true;
            this.btnNewChild.UseSelectable = true;
            this.btnNewChild.Click += new System.EventHandler(this.btnNewChild_Click);
            // 
            // DateTime_Birthday
            // 
            this.DateTime_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime_Birthday.Location = new System.Drawing.Point(339, 23);
            this.DateTime_Birthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime_Birthday.Name = "DateTime_Birthday";
            this.DateTime_Birthday.Size = new System.Drawing.Size(158, 29);
            this.DateTime_Birthday.TabIndex = 18;
            this.DateTime_Birthday.ValueChanged += new System.EventHandler(this.DateTime_Birthday_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cbx_House);
            this.groupBox1.Controls.Add(this.txtDonation_NGO);
            this.groupBox1.Controls.Add(this.txtDonation_Gov);
            this.groupBox1.Controls.Add(this.txtSanitation);
            this.groupBox1.Controls.Add(this.txtRehabilitation);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.DateTime_Birthday);
            this.groupBox1.Controls.Add(this.txtDisabilities);
            this.groupBox1.Controls.Add(this.txtChildEdu);
            this.groupBox1.Location = new System.Drawing.Point(30, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 118);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(278, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "House";
            // 
            // cbx_House
            // 
            this.cbx_House.FormattingEnabled = true;
            this.cbx_House.ItemHeight = 23;
            this.cbx_House.Items.AddRange(new object[] {
            "Permanent",
            "Temporary",
            "Half",
            "Hut",
            "No"});
            this.cbx_House.Location = new System.Drawing.Point(339, 72);
            this.cbx_House.Name = "cbx_House";
            this.cbx_House.Size = new System.Drawing.Size(158, 29);
            this.cbx_House.TabIndex = 25;
            this.cbx_House.UseSelectable = true;
            this.cbx_House.SelectedIndexChanged += new System.EventHandler(this.cbx_House_SelectedIndexChanged);
            // 
            // txtDonation_NGO
            // 
            // 
            // 
            // 
            this.txtDonation_NGO.CustomButton.Image = null;
            this.txtDonation_NGO.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtDonation_NGO.CustomButton.Name = "";
            this.txtDonation_NGO.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDonation_NGO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDonation_NGO.CustomButton.TabIndex = 1;
            this.txtDonation_NGO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDonation_NGO.CustomButton.UseSelectable = true;
            this.txtDonation_NGO.CustomButton.Visible = false;
            this.txtDonation_NGO.Lines = new string[0];
            this.txtDonation_NGO.Location = new System.Drawing.Point(837, 66);
            this.txtDonation_NGO.MaxLength = 32767;
            this.txtDonation_NGO.Multiline = true;
            this.txtDonation_NGO.Name = "txtDonation_NGO";
            this.txtDonation_NGO.PasswordChar = '\0';
            this.txtDonation_NGO.PromptText = "Donation - NGO";
            this.txtDonation_NGO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDonation_NGO.SelectedText = "";
            this.txtDonation_NGO.SelectionLength = 0;
            this.txtDonation_NGO.SelectionStart = 0;
            this.txtDonation_NGO.ShortcutsEnabled = true;
            this.txtDonation_NGO.Size = new System.Drawing.Size(209, 40);
            this.txtDonation_NGO.TabIndex = 24;
            this.txtDonation_NGO.UseSelectable = true;
            this.txtDonation_NGO.WaterMark = "Donation - NGO";
            this.txtDonation_NGO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDonation_NGO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDonation_NGO.TextChanged += new System.EventHandler(this.txtDonation_NGO_TextChanged);
            // 
            // txtDonation_Gov
            // 
            // 
            // 
            // 
            this.txtDonation_Gov.CustomButton.Image = null;
            this.txtDonation_Gov.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtDonation_Gov.CustomButton.Name = "";
            this.txtDonation_Gov.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDonation_Gov.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDonation_Gov.CustomButton.TabIndex = 1;
            this.txtDonation_Gov.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDonation_Gov.CustomButton.UseSelectable = true;
            this.txtDonation_Gov.CustomButton.Visible = false;
            this.txtDonation_Gov.Lines = new string[0];
            this.txtDonation_Gov.Location = new System.Drawing.Point(837, 17);
            this.txtDonation_Gov.MaxLength = 32767;
            this.txtDonation_Gov.Multiline = true;
            this.txtDonation_Gov.Name = "txtDonation_Gov";
            this.txtDonation_Gov.PasswordChar = '\0';
            this.txtDonation_Gov.PromptText = "Donation - Gov";
            this.txtDonation_Gov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDonation_Gov.SelectedText = "";
            this.txtDonation_Gov.SelectionLength = 0;
            this.txtDonation_Gov.SelectionStart = 0;
            this.txtDonation_Gov.ShortcutsEnabled = true;
            this.txtDonation_Gov.Size = new System.Drawing.Size(209, 40);
            this.txtDonation_Gov.TabIndex = 23;
            this.txtDonation_Gov.UseSelectable = true;
            this.txtDonation_Gov.WaterMark = "Donation - Gov";
            this.txtDonation_Gov.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDonation_Gov.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDonation_Gov.TextChanged += new System.EventHandler(this.txtDonation_Gov_TextChanged);
            // 
            // txtSanitation
            // 
            // 
            // 
            // 
            this.txtSanitation.CustomButton.Image = null;
            this.txtSanitation.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtSanitation.CustomButton.Name = "";
            this.txtSanitation.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtSanitation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSanitation.CustomButton.TabIndex = 1;
            this.txtSanitation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSanitation.CustomButton.UseSelectable = true;
            this.txtSanitation.CustomButton.Visible = false;
            this.txtSanitation.Lines = new string[0];
            this.txtSanitation.Location = new System.Drawing.Point(566, 66);
            this.txtSanitation.MaxLength = 32767;
            this.txtSanitation.Multiline = true;
            this.txtSanitation.Name = "txtSanitation";
            this.txtSanitation.PasswordChar = '\0';
            this.txtSanitation.PromptText = "Sanitation facilities";
            this.txtSanitation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSanitation.SelectedText = "";
            this.txtSanitation.SelectionLength = 0;
            this.txtSanitation.SelectionStart = 0;
            this.txtSanitation.ShortcutsEnabled = true;
            this.txtSanitation.Size = new System.Drawing.Size(210, 40);
            this.txtSanitation.TabIndex = 22;
            this.txtSanitation.UseSelectable = true;
            this.txtSanitation.WaterMark = "Sanitation facilities";
            this.txtSanitation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSanitation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSanitation.TextChanged += new System.EventHandler(this.txtSanitation_TextChanged);
            // 
            // txtRehabilitation
            // 
            // 
            // 
            // 
            this.txtRehabilitation.CustomButton.Image = null;
            this.txtRehabilitation.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.txtRehabilitation.CustomButton.Name = "";
            this.txtRehabilitation.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtRehabilitation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRehabilitation.CustomButton.TabIndex = 1;
            this.txtRehabilitation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRehabilitation.CustomButton.UseSelectable = true;
            this.txtRehabilitation.CustomButton.Visible = false;
            this.txtRehabilitation.Lines = new string[0];
            this.txtRehabilitation.Location = new System.Drawing.Point(566, 17);
            this.txtRehabilitation.MaxLength = 32767;
            this.txtRehabilitation.Multiline = true;
            this.txtRehabilitation.Name = "txtRehabilitation";
            this.txtRehabilitation.PasswordChar = '\0';
            this.txtRehabilitation.PromptText = "Rehabilitation Activities";
            this.txtRehabilitation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRehabilitation.SelectedText = "";
            this.txtRehabilitation.SelectionLength = 0;
            this.txtRehabilitation.SelectionStart = 0;
            this.txtRehabilitation.ShortcutsEnabled = true;
            this.txtRehabilitation.Size = new System.Drawing.Size(210, 40);
            this.txtRehabilitation.TabIndex = 20;
            this.txtRehabilitation.UseSelectable = true;
            this.txtRehabilitation.WaterMark = "Rehabilitation Activities";
            this.txtRehabilitation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRehabilitation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRehabilitation.TextChanged += new System.EventHandler(this.txtRehabilitation_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(278, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Birthday";
            // 
            // tbl_cbrdataTableAdapter
            // 
            this.tbl_cbrdataTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(1012, 503);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(122, 31);
            this.btnLoadData.TabIndex = 21;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseCustomBackColor = true;
            this.btnLoadData.UseCustomForeColor = true;
            this.btnLoadData.UseSelectable = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(339, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 31);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Export";
            this.btnExport.UseCustomBackColor = true;
            this.btnExport.UseCustomForeColor = true;
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "child_no",
            "child_name",
            "age",
            "gender",
            "address",
            "gn_division",
            "mother_name",
            "mother_edu",
            "father_name",
            "father_edu",
            "income",
            "child_in_edu",
            "contact_no",
            "disabilities",
            "birthday",
            "rehabilitation_act",
            "house",
            "sanitation_facilities",
            "donation_gov",
            "donation_ngo"});
            this.checkedListBox1.Location = new System.Drawing.Point(1004, 178);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(140, 319);
            this.checkedListBox1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 721);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewChild);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdateChild);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvDataList);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcbrdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abhimana_dbDataSet)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvDataList;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnMenu;
        private MetroFramework.Controls.MetroButton btnUpdateChild;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtChildEdu;
        private MetroFramework.Controls.MetroTextBox txtDisabilities;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private MetroFramework.Controls.MetroButton btnNewChild;
        private MetroFramework.Controls.MetroDateTime DateTime_Birthday;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtDonation_NGO;
        private MetroFramework.Controls.MetroTextBox txtDonation_Gov;
        private MetroFramework.Controls.MetroTextBox txtSanitation;
        private MetroFramework.Controls.MetroTextBox txtRehabilitation;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbx_House;
        private abhimana_dbDataSet abhimana_dbDataSet;
        private System.Windows.Forms.BindingSource tblcbrdataBindingSource;
        private abhimana_dbDataSetTableAdapters.tbl_cbrdataTableAdapter tbl_cbrdataTableAdapter;
        private MetroFramework.Controls.MetroButton btnLoadData;
        private MetroFramework.Controls.MetroButton btnExport;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}