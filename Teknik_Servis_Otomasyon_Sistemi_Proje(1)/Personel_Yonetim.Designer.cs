namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Personel_Yonetim
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOperations = new System.Windows.Forms.TabPage();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.pnlStaffForm = new System.Windows.Forms.Panel();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.btnOperations = new FontAwesome.Sharp.IconButton();
            this.btnAddStaff = new FontAwesome.Sharp.IconButton();
            this.btnEditInfo = new FontAwesome.Sharp.IconButton();
            this.btnDeleteStaff = new FontAwesome.Sharp.IconButton();
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.tabPagePerformance = new System.Windows.Forms.TabPage();
            this.pnlPerformance = new System.Windows.Forms.Panel();
            this.pnlPerformanceCards = new System.Windows.Forms.Panel();
            this.lblPerformanceTitle = new System.Windows.Forms.Label();
            this.lblSelectedStaffName = new System.Windows.Forms.Label();
            this.txtSelectedStaffName = new System.Windows.Forms.TextBox();
            this.lblSelectedStaffSurname = new System.Windows.Forms.Label();
            this.txtSelectedStaffSurname = new System.Windows.Forms.TextBox();
            this.lblResolvedIssues = new System.Windows.Forms.Label();
            this.txtResolvedIssues = new System.Windows.Forms.TextBox();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.txtAverageTime = new System.Windows.Forms.TextBox();
            this.btnTracking = new FontAwesome.Sharp.IconButton();
            this.dgvPerformanceList = new System.Windows.Forms.DataGridView();
            this.dgvIssueTypes = new System.Windows.Forms.DataGridView();
            this.pnlDataGridPerformance = new System.Windows.Forms.Panel();
            this.dgvStaffDetails = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageOperations.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.pnlStaffForm.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.tabPagePerformance.SuspendLayout();
            this.pnlPerformance.SuspendLayout();
            this.pnlPerformanceCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformanceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnHome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1435, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(513, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👥 Personel Yönetimi";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 24;
            this.btnHome.Location = new System.Drawing.Point(2555, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageOperations);
            this.tabControlMain.Controls.Add(this.tabPagePerformance);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 80);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1435, 750);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageOperations
            // 
            this.tabPageOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageOperations.Controls.Add(this.pnlOperations);
            this.tabPageOperations.Location = new System.Drawing.Point(4, 37);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageOperations.Size = new System.Drawing.Size(1427, 709);
            this.tabPageOperations.TabIndex = 0;
            this.tabPageOperations.Text = "⚙️  İşlemler";
            // 
            // pnlOperations
            // 
            this.pnlOperations.AutoScroll = true;
            this.pnlOperations.BackColor = System.Drawing.Color.White;
            this.pnlOperations.Controls.Add(this.pnlStaffForm);
            this.pnlOperations.Controls.Add(this.pnlActionButtons);
            this.pnlOperations.Controls.Add(this.dgvStaffList);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperations.Location = new System.Drawing.Point(10, 10);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(1407, 689);
            this.pnlOperations.TabIndex = 0;
            // 
            // pnlStaffForm
            // 
            this.pnlStaffForm.BackColor = System.Drawing.Color.White;
            this.pnlStaffForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaffForm.Controls.Add(this.lblStaffID);
            this.pnlStaffForm.Controls.Add(this.txtStaffID);
            this.pnlStaffForm.Controls.Add(this.lblFirstName);
            this.pnlStaffForm.Controls.Add(this.txtFirstName);
            this.pnlStaffForm.Controls.Add(this.lblLastName);
            this.pnlStaffForm.Controls.Add(this.txtLastName);
            this.pnlStaffForm.Controls.Add(this.lblUsername);
            this.pnlStaffForm.Controls.Add(this.txtUsername);
            this.pnlStaffForm.Controls.Add(this.lblPassword);
            this.pnlStaffForm.Controls.Add(this.txtPassword);
            this.pnlStaffForm.Controls.Add(this.lblRole);
            this.pnlStaffForm.Controls.Add(this.txtRole);
            this.pnlStaffForm.Location = new System.Drawing.Point(10, 10);
            this.pnlStaffForm.Name = "pnlStaffForm";
            this.pnlStaffForm.Padding = new System.Windows.Forms.Padding(15);
            this.pnlStaffForm.Size = new System.Drawing.Size(680, 400);
            this.pnlStaffForm.TabIndex = 0;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStaffID.Location = new System.Drawing.Point(15, 15);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(153, 28);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "🆔 Personel ID";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStaffID.Location = new System.Drawing.Point(15, 46);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(310, 34);
            this.txtStaffID.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFirstName.Location = new System.Drawing.Point(360, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 28);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "👤 Ad";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(360, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(290, 34);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLastName.Location = new System.Drawing.Point(15, 96);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 28);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "👤 Soyad";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.Location = new System.Drawing.Point(15, 121);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(310, 34);
            this.txtLastName.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsername.Location = new System.Drawing.Point(360, 96);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(166, 28);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "🔐 Kullanıcı Adı";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(365, 127);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(290, 34);
            this.txtUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPassword.Location = new System.Drawing.Point(15, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 28);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "🔑 Şifre";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(15, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(310, 34);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRole.Location = new System.Drawing.Point(360, 167);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(83, 28);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "🎖️  Rol";
            // 
            // txtRole
            // 
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRole.Location = new System.Drawing.Point(360, 213);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(290, 34);
            this.txtRole.TabIndex = 11;
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.BackColor = System.Drawing.Color.White;
            this.pnlActionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActionButtons.Controls.Add(this.btnOperations);
            this.pnlActionButtons.Controls.Add(this.btnAddStaff);
            this.pnlActionButtons.Controls.Add(this.btnEditInfo);
            this.pnlActionButtons.Controls.Add(this.btnDeleteStaff);
            this.pnlActionButtons.Location = new System.Drawing.Point(10, 420);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Padding = new System.Windows.Forms.Padding(15);
            this.pnlActionButtons.Size = new System.Drawing.Size(680, 120);
            this.pnlActionButtons.TabIndex = 1;
            // 
            // btnOperations
            // 
            this.btnOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnOperations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperations.FlatAppearance.BorderSize = 0;
            this.btnOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOperations.ForeColor = System.Drawing.Color.White;
            this.btnOperations.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnOperations.IconColor = System.Drawing.Color.White;
            this.btnOperations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOperations.IconSize = 20;
            this.btnOperations.Location = new System.Drawing.Point(15, 15);
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Size = new System.Drawing.Size(140, 64);
            this.btnOperations.TabIndex = 0;
            this.btnOperations.Text = "İşlemler";
            this.btnOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperations.UseVisualStyleBackColor = false;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddStaff.IconColor = System.Drawing.Color.White;
            this.btnAddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStaff.IconSize = 20;
            this.btnAddStaff.Location = new System.Drawing.Point(170, 15);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(140, 64);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Personel Ekle";
            this.btnAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnEditInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditInfo.FlatAppearance.BorderSize = 0;
            this.btnEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditInfo.ForeColor = System.Drawing.Color.White;
            this.btnEditInfo.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnEditInfo.IconColor = System.Drawing.Color.White;
            this.btnEditInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditInfo.IconSize = 20;
            this.btnEditInfo.Location = new System.Drawing.Point(325, 15);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(140, 64);
            this.btnEditInfo.TabIndex = 2;
            this.btnEditInfo.Text = "Düzenle";
            this.btnEditInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditInfo.UseVisualStyleBackColor = false;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStaff.FlatAppearance.BorderSize = 0;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteStaff.IconColor = System.Drawing.Color.White;
            this.btnDeleteStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteStaff.IconSize = 20;
            this.btnDeleteStaff.Location = new System.Drawing.Point(480, 15);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(140, 64);
            this.btnDeleteStaff.TabIndex = 3;
            this.btnDeleteStaff.Text = "Sil";
            this.btnDeleteStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.AllowUserToAddRows = false;
            this.dgvStaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffList.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaffList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStaffList.ColumnHeadersHeight = 35;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaffList.Location = new System.Drawing.Point(700, 10);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.ReadOnly = true;
            this.dgvStaffList.RowHeadersVisible = false;
            this.dgvStaffList.RowHeadersWidth = 62;
            this.dgvStaffList.RowTemplate.Height = 28;
            this.dgvStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffList.Size = new System.Drawing.Size(692, 530);
            this.dgvStaffList.TabIndex = 0;
            // 
            // tabPagePerformance
            // 
            this.tabPagePerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPagePerformance.Controls.Add(this.pnlPerformance);
            this.tabPagePerformance.Location = new System.Drawing.Point(4, 37);
            this.tabPagePerformance.Name = "tabPagePerformance";
            this.tabPagePerformance.Padding = new System.Windows.Forms.Padding(10);
            this.tabPagePerformance.Size = new System.Drawing.Size(1427, 709);
            this.tabPagePerformance.TabIndex = 1;
            this.tabPagePerformance.Text = "📊 Performans";
            // 
            // pnlPerformance
            // 
            this.pnlPerformance.AutoScroll = true;
            this.pnlPerformance.BackColor = System.Drawing.Color.White;
            this.pnlPerformance.Controls.Add(this.pnlPerformanceCards);
            this.pnlPerformance.Controls.Add(this.dgvPerformanceList);
            this.pnlPerformance.Controls.Add(this.dgvIssueTypes);
            this.pnlPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPerformance.Location = new System.Drawing.Point(10, 10);
            this.pnlPerformance.Name = "pnlPerformance";
            this.pnlPerformance.Size = new System.Drawing.Size(1407, 689);
            this.pnlPerformance.TabIndex = 0;
            // 
            // pnlPerformanceCards
            // 
            this.pnlPerformanceCards.BackColor = System.Drawing.Color.White;
            this.pnlPerformanceCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPerformanceCards.Controls.Add(this.lblPerformanceTitle);
            this.pnlPerformanceCards.Controls.Add(this.lblSelectedStaffName);
            this.pnlPerformanceCards.Controls.Add(this.txtSelectedStaffName);
            this.pnlPerformanceCards.Controls.Add(this.lblSelectedStaffSurname);
            this.pnlPerformanceCards.Controls.Add(this.txtSelectedStaffSurname);
            this.pnlPerformanceCards.Controls.Add(this.lblResolvedIssues);
            this.pnlPerformanceCards.Controls.Add(this.txtResolvedIssues);
            this.pnlPerformanceCards.Controls.Add(this.lblAverageTime);
            this.pnlPerformanceCards.Controls.Add(this.txtAverageTime);
            this.pnlPerformanceCards.Controls.Add(this.btnTracking);
            this.pnlPerformanceCards.Location = new System.Drawing.Point(10, 10);
            this.pnlPerformanceCards.Name = "pnlPerformanceCards";
            this.pnlPerformanceCards.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPerformanceCards.Size = new System.Drawing.Size(1370, 200);
            this.pnlPerformanceCards.TabIndex = 0;
            // 
            // lblPerformanceTitle
            // 
            this.lblPerformanceTitle.AutoSize = true;
            this.lblPerformanceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPerformanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPerformanceTitle.Location = new System.Drawing.Point(14, 13);
            this.lblPerformanceTitle.Name = "lblPerformanceTitle";
            this.lblPerformanceTitle.Size = new System.Drawing.Size(248, 32);
            this.lblPerformanceTitle.TabIndex = 0;
            this.lblPerformanceTitle.Text = "👤 Personel Bilgileri";
            // 
            // lblSelectedStaffName
            // 
            this.lblSelectedStaffName.AutoSize = true;
            this.lblSelectedStaffName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedStaffName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSelectedStaffName.Location = new System.Drawing.Point(15, 45);
            this.lblSelectedStaffName.Name = "lblSelectedStaffName";
            this.lblSelectedStaffName.Size = new System.Drawing.Size(41, 25);
            this.lblSelectedStaffName.TabIndex = 1;
            this.lblSelectedStaffName.Text = "Ad:";
            // 
            // txtSelectedStaffName
            // 
            this.txtSelectedStaffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSelectedStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedStaffName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSelectedStaffName.Location = new System.Drawing.Point(15, 70);
            this.txtSelectedStaffName.Multiline = true;
            this.txtSelectedStaffName.Name = "txtSelectedStaffName";
            this.txtSelectedStaffName.ReadOnly = true;
            this.txtSelectedStaffName.Size = new System.Drawing.Size(200, 45);
            this.txtSelectedStaffName.TabIndex = 2;
            // 
            // lblSelectedStaffSurname
            // 
            this.lblSelectedStaffSurname.AutoSize = true;
            this.lblSelectedStaffSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedStaffSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSelectedStaffSurname.Location = new System.Drawing.Point(230, 45);
            this.lblSelectedStaffSurname.Name = "lblSelectedStaffSurname";
            this.lblSelectedStaffSurname.Size = new System.Drawing.Size(69, 25);
            this.lblSelectedStaffSurname.TabIndex = 3;
            this.lblSelectedStaffSurname.Text = "Soyad:";
            // 
            // txtSelectedStaffSurname
            // 
            this.txtSelectedStaffSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSelectedStaffSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedStaffSurname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSelectedStaffSurname.Location = new System.Drawing.Point(230, 70);
            this.txtSelectedStaffSurname.Multiline = true;
            this.txtSelectedStaffSurname.Name = "txtSelectedStaffSurname";
            this.txtSelectedStaffSurname.ReadOnly = true;
            this.txtSelectedStaffSurname.Size = new System.Drawing.Size(200, 45);
            this.txtSelectedStaffSurname.TabIndex = 4;
            // 
            // lblResolvedIssues
            // 
            this.lblResolvedIssues.AutoSize = true;
            this.lblResolvedIssues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResolvedIssues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblResolvedIssues.Location = new System.Drawing.Point(445, 45);
            this.lblResolvedIssues.Name = "lblResolvedIssues";
            this.lblResolvedIssues.Size = new System.Drawing.Size(188, 25);
            this.lblResolvedIssues.TabIndex = 5;
            this.lblResolvedIssues.Text = "✅ Çözülen Arızalar:";
            // 
            // txtResolvedIssues
            // 
            this.txtResolvedIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtResolvedIssues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResolvedIssues.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResolvedIssues.Location = new System.Drawing.Point(445, 70);
            this.txtResolvedIssues.Multiline = true;
            this.txtResolvedIssues.Name = "txtResolvedIssues";
            this.txtResolvedIssues.ReadOnly = true;
            this.txtResolvedIssues.Size = new System.Drawing.Size(200, 45);
            this.txtResolvedIssues.TabIndex = 6;
            this.txtResolvedIssues.Text = "0";
            // 
            // lblAverageTime
            // 
            this.lblAverageTime.AutoSize = true;
            this.lblAverageTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAverageTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAverageTime.Location = new System.Drawing.Point(660, 45);
            this.lblAverageTime.Name = "lblAverageTime";
            this.lblAverageTime.Size = new System.Drawing.Size(176, 25);
            this.lblAverageTime.TabIndex = 7;
            this.lblAverageTime.Text = "⏱️  Ortalama Süre:";
            // 
            // txtAverageTime
            // 
            this.txtAverageTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtAverageTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAverageTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAverageTime.Location = new System.Drawing.Point(660, 70);
            this.txtAverageTime.Multiline = true;
            this.txtAverageTime.Name = "txtAverageTime";
            this.txtAverageTime.ReadOnly = true;
            this.txtAverageTime.Size = new System.Drawing.Size(200, 45);
            this.txtAverageTime.TabIndex = 8;
            this.txtAverageTime.Text = "0";
            // 
            // btnTracking
            // 
            this.btnTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTracking.FlatAppearance.BorderSize = 0;
            this.btnTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTracking.ForeColor = System.Drawing.Color.White;
            this.btnTracking.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnTracking.IconColor = System.Drawing.Color.White;
            this.btnTracking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTracking.IconSize = 20;
            this.btnTracking.Location = new System.Drawing.Point(875, 70);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(140, 45);
            this.btnTracking.TabIndex = 4;
            this.btnTracking.Text = "Takip Et";
            this.btnTracking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTracking.UseVisualStyleBackColor = false;
            // 
            // dgvPerformanceList
            // 
            this.dgvPerformanceList.AllowUserToAddRows = false;
            this.dgvPerformanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerformanceList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerformanceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerformanceList.ColumnHeadersHeight = 35;
            this.dgvPerformanceList.Location = new System.Drawing.Point(10, 220);
            this.dgvPerformanceList.Name = "dgvPerformanceList";
            this.dgvPerformanceList.ReadOnly = true;
            this.dgvPerformanceList.RowHeadersVisible = false;
            this.dgvPerformanceList.RowHeadersWidth = 62;
            this.dgvPerformanceList.RowTemplate.Height = 28;
            this.dgvPerformanceList.Size = new System.Drawing.Size(680, 440);
            this.dgvPerformanceList.TabIndex = 1;
            // 
            // dgvIssueTypes
            // 
            this.dgvIssueTypes.AllowUserToAddRows = false;
            this.dgvIssueTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssueTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssueTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIssueTypes.ColumnHeadersHeight = 35;
            this.dgvIssueTypes.Location = new System.Drawing.Point(700, 220);
            this.dgvIssueTypes.Name = "dgvIssueTypes";
            this.dgvIssueTypes.ReadOnly = true;
            this.dgvIssueTypes.RowHeadersVisible = false;
            this.dgvIssueTypes.RowHeadersWidth = 62;
            this.dgvIssueTypes.RowTemplate.Height = 28;
            this.dgvIssueTypes.Size = new System.Drawing.Size(680, 440);
            this.dgvIssueTypes.TabIndex = 2;
            // 
            // pnlDataGridPerformance
            // 
            this.pnlDataGridPerformance.Location = new System.Drawing.Point(0, 0);
            this.pnlDataGridPerformance.Name = "pnlDataGridPerformance";
            this.pnlDataGridPerformance.Size = new System.Drawing.Size(200, 100);
            this.pnlDataGridPerformance.TabIndex = 0;
            // 
            // dgvStaffDetails
            // 
            this.dgvStaffDetails.ColumnHeadersHeight = 34;
            this.dgvStaffDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvStaffDetails.Name = "dgvStaffDetails";
            this.dgvStaffDetails.RowHeadersWidth = 62;
            this.dgvStaffDetails.Size = new System.Drawing.Size(240, 150);
            this.dgvStaffDetails.TabIndex = 0;
            // 
            // Personel_Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Personel_Yonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Yönetimi - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Personel_Yonetim_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOperations.ResumeLayout(false);
            this.pnlOperations.ResumeLayout(false);
            this.pnlStaffForm.ResumeLayout(false);
            this.pnlStaffForm.PerformLayout();
            this.pnlActionButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.tabPagePerformance.ResumeLayout(false);
            this.pnlPerformance.ResumeLayout(false);
            this.pnlPerformanceCards.ResumeLayout(false);
            this.pnlPerformanceCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformanceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnHome;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOperations;
        private System.Windows.Forms.TabPage tabPagePerformance;

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlStaffForm;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Panel pnlPerformance;
        private System.Windows.Forms.Panel pnlPerformanceCards;
        private System.Windows.Forms.Panel pnlDataGridPerformance;

        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;

        private System.Windows.Forms.Label lblPerformanceTitle;
        private System.Windows.Forms.Label lblSelectedStaffName;
        private System.Windows.Forms.TextBox txtSelectedStaffName;
        private System.Windows.Forms.Label lblSelectedStaffSurname;
        private System.Windows.Forms.TextBox txtSelectedStaffSurname;
        private System.Windows.Forms.Label lblResolvedIssues;
        private System.Windows.Forms.TextBox txtResolvedIssues;
        private System.Windows.Forms.Label lblAverageTime;
        private System.Windows.Forms.TextBox txtAverageTime;

        private FontAwesome.Sharp.IconButton btnAddStaff;
        private FontAwesome.Sharp.IconButton btnEditInfo;
        private FontAwesome.Sharp.IconButton btnDeleteStaff;
        private FontAwesome.Sharp.IconButton btnOperations;
        private FontAwesome.Sharp.IconButton btnTracking;

        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.DataGridView dgvStaffDetails;
        private System.Windows.Forms.DataGridView dgvPerformanceList;
        private System.Windows.Forms.DataGridView dgvIssueTypes;
    }
}