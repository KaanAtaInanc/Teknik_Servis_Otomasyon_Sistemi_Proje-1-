namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Atanan_Islemler
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
            this.lblTechnicianInfo = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAssignedTasks = new System.Windows.Forms.TabPage();
            this.pnlAssignedTasks = new System.Windows.Forms.Panel();
            this.pnlTasksList = new System.Windows.Forms.Panel();
            this.dgvMyTasks = new System.Windows.Forms.DataGridView();
            this.tabPageTaskDetails = new System.Windows.Forms.TabPage();
            this.pnlTaskDetails = new System.Windows.Forms.Panel();
            this.pnlDeviceInfo = new System.Windows.Forms.Panel();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblBrandModel = new System.Windows.Forms.Label();
            this.txtBrandModel = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.pnlWorkProgress = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTechnicianNotes = new System.Windows.Forms.Label();
            this.txtTechnicianNotes = new System.Windows.Forms.TextBox();
            this.pnlPartsUsed = new System.Windows.Forms.Panel();
            this.pnlPartFilters = new System.Windows.Forms.Panel();
            this.lblPartCategory = new System.Windows.Forms.Label();
            this.cmbPartCategory = new System.Windows.Forms.ComboBox();
            this.lblPartSearch = new System.Windows.Forms.Label();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            this.lblUsedParts = new System.Windows.Forms.Label();
            this.cmbUsedParts = new System.Windows.Forms.ComboBox();
            this.lblStockInfo = new System.Windows.Forms.Label();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.lblPartQuantity = new System.Windows.Forms.Label();
            this.txtPartQuantity = new System.Windows.Forms.TextBox();
            this.dgvCompletedTasks = new System.Windows.Forms.DataGridView();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.btnSaveWork = new FontAwesome.Sharp.IconButton();
            this.btnCancelWork = new FontAwesome.Sharp.IconButton();
            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageAssignedTasks.SuspendLayout();
            this.pnlAssignedTasks.SuspendLayout();
            this.pnlTasksList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTasks)).BeginInit();
            this.tabPageTaskDetails.SuspendLayout();
            this.pnlTaskDetails.SuspendLayout();
            this.pnlDeviceInfo.SuspendLayout();
            this.pnlWorkProgress.SuspendLayout();
            this.pnlPartsUsed.SuspendLayout();
            this.pnlPartFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedTasks)).BeginInit();
            this.pnlActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblTechnicianInfo);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1457, 86);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔧 Atanan İşlemler";
            // 
            // lblTechnicianInfo
            // 
            this.lblTechnicianInfo.AutoSize = true;
            this.lblTechnicianInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTechnicianInfo.ForeColor = System.Drawing.Color.White;
            this.lblTechnicianInfo.Location = new System.Drawing.Point(505, 33);
            this.lblTechnicianInfo.Name = "lblTechnicianInfo";
            this.lblTechnicianInfo.Size = new System.Drawing.Size(287, 30);
            this.lblTechnicianInfo.TabIndex = 1;
            this.lblTechnicianInfo.Text = "👤 Teknisyen: Yükleniyor...";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 24;
            this.btnLogout.Location = new System.Drawing.Point(1249, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(196, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "🚪 Çıkış";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAssignedTasks);
            this.tabControlMain.Controls.Add(this.tabPageTaskDetails);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 86);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1457, 714);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageAssignedTasks
            // 
            this.tabPageAssignedTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageAssignedTasks.Controls.Add(this.pnlAssignedTasks);
            this.tabPageAssignedTasks.Location = new System.Drawing.Point(4, 37);
            this.tabPageAssignedTasks.Name = "tabPageAssignedTasks";
            this.tabPageAssignedTasks.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageAssignedTasks.Size = new System.Drawing.Size(1449, 673);
            this.tabPageAssignedTasks.TabIndex = 0;
            this.tabPageAssignedTasks.Text = "📋 Atanan İşlerim";
            // 
            // pnlAssignedTasks
            // 
            this.pnlAssignedTasks.AutoScroll = true;
            this.pnlAssignedTasks.BackColor = System.Drawing.Color.White;
            this.pnlAssignedTasks.Controls.Add(this.pnlTasksList);
            this.pnlAssignedTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssignedTasks.Location = new System.Drawing.Point(10, 10);
            this.pnlAssignedTasks.Name = "pnlAssignedTasks";
            this.pnlAssignedTasks.Size = new System.Drawing.Size(1429, 653);
            this.pnlAssignedTasks.TabIndex = 0;
            // 
            // pnlTasksList
            // 
            this.pnlTasksList.BackColor = System.Drawing.Color.White;
            this.pnlTasksList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTasksList.Controls.Add(this.dgvMyTasks);
            this.pnlTasksList.Location = new System.Drawing.Point(10, 10);
            this.pnlTasksList.Name = "pnlTasksList";
            this.pnlTasksList.Padding = new System.Windows.Forms.Padding(15);
            this.pnlTasksList.Size = new System.Drawing.Size(1370, 650);
            this.pnlTasksList.TabIndex = 0;
            // 
            // dgvMyTasks
            // 
            this.dgvMyTasks.AllowUserToAddRows = false;
            this.dgvMyTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMyTasks.ColumnHeadersHeight = 35;
            this.dgvMyTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMyTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyTasks.Location = new System.Drawing.Point(15, 15);
            this.dgvMyTasks.Name = "dgvMyTasks";
            this.dgvMyTasks.ReadOnly = true;
            this.dgvMyTasks.RowHeadersVisible = false;
            this.dgvMyTasks.RowHeadersWidth = 62;
            this.dgvMyTasks.RowTemplate.Height = 28;
            this.dgvMyTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyTasks.Size = new System.Drawing.Size(1338, 618);
            this.dgvMyTasks.TabIndex = 0;
            // 
            // tabPageTaskDetails
            // 
            this.tabPageTaskDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageTaskDetails.Controls.Add(this.pnlTaskDetails);
            this.tabPageTaskDetails.Location = new System.Drawing.Point(4, 37);
            this.tabPageTaskDetails.Name = "tabPageTaskDetails";
            this.tabPageTaskDetails.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageTaskDetails.Size = new System.Drawing.Size(1449, 673);
            this.tabPageTaskDetails.TabIndex = 1;
            this.tabPageTaskDetails.Text = "🔧 İşlem Detayları";
            // 
            // pnlTaskDetails
            // 
            this.pnlTaskDetails.AutoScroll = true;
            this.pnlTaskDetails.BackColor = System.Drawing.Color.White;
            this.pnlTaskDetails.Controls.Add(this.pnlDeviceInfo);
            this.pnlTaskDetails.Controls.Add(this.pnlWorkProgress);
            this.pnlTaskDetails.Controls.Add(this.pnlPartsUsed);
            this.pnlTaskDetails.Controls.Add(this.pnlActionButtons);
            this.pnlTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTaskDetails.Location = new System.Drawing.Point(10, 10);
            this.pnlTaskDetails.Name = "pnlTaskDetails";
            this.pnlTaskDetails.Size = new System.Drawing.Size(1429, 653);
            this.pnlTaskDetails.TabIndex = 0;
            // 
            // pnlDeviceInfo
            // 
            this.pnlDeviceInfo.BackColor = System.Drawing.Color.White;
            this.pnlDeviceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeviceInfo.Controls.Add(this.lblDeviceName);
            this.pnlDeviceInfo.Controls.Add(this.txtDeviceName);
            this.pnlDeviceInfo.Controls.Add(this.lblBrandModel);
            this.pnlDeviceInfo.Controls.Add(this.txtBrandModel);
            this.pnlDeviceInfo.Controls.Add(this.lblSerialNo);
            this.pnlDeviceInfo.Controls.Add(this.txtSerialNo);
            this.pnlDeviceInfo.Controls.Add(this.lblComplaint);
            this.pnlDeviceInfo.Controls.Add(this.txtComplaint);
            this.pnlDeviceInfo.Location = new System.Drawing.Point(10, 16);
            this.pnlDeviceInfo.Name = "pnlDeviceInfo";
            this.pnlDeviceInfo.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDeviceInfo.Size = new System.Drawing.Size(680, 350);
            this.pnlDeviceInfo.TabIndex = 0;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDeviceName.Location = new System.Drawing.Point(15, 15);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(135, 28);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "💻 Cihaz Adı";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeviceName.Location = new System.Drawing.Point(15, 46);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(630, 34);
            this.txtDeviceName.TabIndex = 1;
            // 
            // lblBrandModel
            // 
            this.lblBrandModel.AutoSize = true;
            this.lblBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrandModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBrandModel.Location = new System.Drawing.Point(15, 85);
            this.lblBrandModel.Name = "lblBrandModel";
            this.lblBrandModel.Size = new System.Drawing.Size(181, 28);
            this.lblBrandModel.TabIndex = 2;
            this.lblBrandModel.Text = "🏷️  Marka/Model";
            // 
            // txtBrandModel
            // 
            this.txtBrandModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtBrandModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrandModel.Location = new System.Drawing.Point(15, 116);
            this.txtBrandModel.Name = "txtBrandModel";
            this.txtBrandModel.ReadOnly = true;
            this.txtBrandModel.Size = new System.Drawing.Size(290, 34);
            this.txtBrandModel.TabIndex = 3;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSerialNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSerialNo.Location = new System.Drawing.Point(355, 85);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(179, 28);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "🔢 Seri Numarası";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSerialNo.Location = new System.Drawing.Point(355, 116);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.ReadOnly = true;
            this.txtSerialNo.Size = new System.Drawing.Size(290, 34);
            this.txtSerialNo.TabIndex = 5;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblComplaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblComplaint.Location = new System.Drawing.Point(15, 155);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(206, 28);
            this.lblComplaint.TabIndex = 6;
            this.lblComplaint.Text = "⚠️  Müşteri Şikayeti";
            // 
            // txtComplaint
            // 
            this.txtComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplaint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComplaint.Location = new System.Drawing.Point(15, 186);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.ReadOnly = true;
            this.txtComplaint.Size = new System.Drawing.Size(630, 144);
            this.txtComplaint.TabIndex = 7;
            // 
            // pnlWorkProgress
            // 
            this.pnlWorkProgress.BackColor = System.Drawing.Color.White;
            this.pnlWorkProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWorkProgress.Controls.Add(this.lblStatus);
            this.pnlWorkProgress.Controls.Add(this.cmbStatus);
            this.pnlWorkProgress.Controls.Add(this.lblTechnicianNotes);
            this.pnlWorkProgress.Controls.Add(this.txtTechnicianNotes);
            this.pnlWorkProgress.Location = new System.Drawing.Point(10, 402);
            this.pnlWorkProgress.Name = "pnlWorkProgress";
            this.pnlWorkProgress.Padding = new System.Windows.Forms.Padding(15);
            this.pnlWorkProgress.Size = new System.Drawing.Size(680, 200);
            this.pnlWorkProgress.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(15, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 28);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "📊 İş Durumu";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location = new System.Drawing.Point(15, 46);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(630, 36);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblTechnicianNotes
            // 
            this.lblTechnicianNotes.AutoSize = true;
            this.lblTechnicianNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTechnicianNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTechnicianNotes.Location = new System.Drawing.Point(15, 85);
            this.lblTechnicianNotes.Name = "lblTechnicianNotes";
            this.lblTechnicianNotes.Size = new System.Drawing.Size(247, 28);
            this.lblTechnicianNotes.TabIndex = 2;
            this.lblTechnicianNotes.Text = "📝 Teknisyen Açıklaması";
            // 
            // txtTechnicianNotes
            // 
            this.txtTechnicianNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTechnicianNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTechnicianNotes.Location = new System.Drawing.Point(15, 116);
            this.txtTechnicianNotes.Multiline = true;
            this.txtTechnicianNotes.Name = "txtTechnicianNotes";
            this.txtTechnicianNotes.Size = new System.Drawing.Size(630, 70);
            this.txtTechnicianNotes.TabIndex = 3;
            // 
            // pnlPartsUsed
            // 
            this.pnlPartsUsed.BackColor = System.Drawing.Color.White;
            this.pnlPartsUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPartsUsed.Controls.Add(this.pnlPartFilters);
            this.pnlPartsUsed.Controls.Add(this.lblUsedParts);
            this.pnlPartsUsed.Controls.Add(this.cmbUsedParts);
            this.pnlPartsUsed.Controls.Add(this.lblStockInfo);
            this.pnlPartsUsed.Controls.Add(this.lblStockValue);
            this.pnlPartsUsed.Controls.Add(this.lblPartQuantity);
            this.pnlPartsUsed.Controls.Add(this.txtPartQuantity);
            this.pnlPartsUsed.Controls.Add(this.dgvCompletedTasks);
            this.pnlPartsUsed.Location = new System.Drawing.Point(700, 16);
            this.pnlPartsUsed.Name = "pnlPartsUsed";
            this.pnlPartsUsed.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPartsUsed.Size = new System.Drawing.Size(680, 586);
            this.pnlPartsUsed.TabIndex = 2;
            // 
            // pnlPartFilters
            // 
            this.pnlPartFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.pnlPartFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPartFilters.Controls.Add(this.lblPartCategory);
            this.pnlPartFilters.Controls.Add(this.cmbPartCategory);
            this.pnlPartFilters.Controls.Add(this.lblPartSearch);
            this.pnlPartFilters.Controls.Add(this.txtPartSearch);
            this.pnlPartFilters.Location = new System.Drawing.Point(15, 15);
            this.pnlPartFilters.Name = "pnlPartFilters";
            this.pnlPartFilters.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPartFilters.Size = new System.Drawing.Size(630, 110);
            this.pnlPartFilters.TabIndex = 0;
            // 
            // lblPartCategory
            // 
            this.lblPartCategory.AutoSize = true;
            this.lblPartCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPartCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPartCategory.Location = new System.Drawing.Point(10, 10);
            this.lblPartCategory.Name = "lblPartCategory";
            this.lblPartCategory.Size = new System.Drawing.Size(181, 25);
            this.lblPartCategory.TabIndex = 0;
            this.lblPartCategory.Text = "📂 Parça Kategorisi";
            // 
            // cmbPartCategory
            // 
            this.cmbPartCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPartCategory.Items.AddRange(new object[] {
            "Tümü",
            "Ekran",
            "Batarya",
            "Kasa",
            "Bellek",
            "Depolama",
            "Konnektör",
            "Şarj Aleti",
            "Başka"});
            this.cmbPartCategory.Location = new System.Drawing.Point(10, 33);
            this.cmbPartCategory.Name = "cmbPartCategory";
            this.cmbPartCategory.Size = new System.Drawing.Size(300, 33);
            this.cmbPartCategory.TabIndex = 0;
            this.cmbPartCategory.SelectedIndexChanged += new System.EventHandler(this.CmbPartCategory_SelectedIndexChanged);
            // 
            // lblPartSearch
            // 
            this.lblPartSearch.AutoSize = true;
            this.lblPartSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPartSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPartSearch.Location = new System.Drawing.Point(320, 10);
            this.lblPartSearch.Name = "lblPartSearch";
            this.lblPartSearch.Size = new System.Drawing.Size(125, 25);
            this.lblPartSearch.TabIndex = 1;
            this.lblPartSearch.Text = "🔍 Parça Ara";
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartSearch.Location = new System.Drawing.Point(320, 33);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(300, 31);
            this.txtPartSearch.TabIndex = 1;
            this.txtPartSearch.TextChanged += new System.EventHandler(this.TxtPartSearch_TextChanged);
            // 
            // lblUsedParts
            // 
            this.lblUsedParts.AutoSize = true;
            this.lblUsedParts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsedParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsedParts.Location = new System.Drawing.Point(15, 140);
            this.lblUsedParts.Name = "lblUsedParts";
            this.lblUsedParts.Size = new System.Drawing.Size(237, 28);
            this.lblUsedParts.TabIndex = 1;
            this.lblUsedParts.Text = "🔩 Kullanılan Parça Seç";
            // 
            // cmbUsedParts
            // 
            this.cmbUsedParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsedParts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUsedParts.Location = new System.Drawing.Point(15, 165);
            this.cmbUsedParts.Name = "cmbUsedParts";
            this.cmbUsedParts.Size = new System.Drawing.Size(630, 36);
            this.cmbUsedParts.TabIndex = 2;
            this.cmbUsedParts.SelectedIndexChanged += new System.EventHandler(this.CmbUsedParts_SelectedIndexChanged);
            // 
            // lblStockInfo
            // 
            this.lblStockInfo.AutoSize = true;
            this.lblStockInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStockInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStockInfo.Location = new System.Drawing.Point(15, 210);
            this.lblStockInfo.Name = "lblStockInfo";
            this.lblStockInfo.Size = new System.Drawing.Size(156, 25);
            this.lblStockInfo.TabIndex = 3;
            this.lblStockInfo.Text = "📦 Mevcut Stok:";
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblStockValue.Location = new System.Drawing.Point(150, 210);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(75, 28);
            this.lblStockValue.TabIndex = 4;
            this.lblStockValue.Text = "0 Adet";
            // 
            // lblPartQuantity
            // 
            this.lblPartQuantity.AutoSize = true;
            this.lblPartQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPartQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPartQuantity.Location = new System.Drawing.Point(15, 245);
            this.lblPartQuantity.Name = "lblPartQuantity";
            this.lblPartQuantity.Size = new System.Drawing.Size(210, 28);
            this.lblPartQuantity.TabIndex = 5;
            this.lblPartQuantity.Text = "📊 Kullanılan Miktar";
            // 
            // txtPartQuantity
            // 
            this.txtPartQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPartQuantity.Location = new System.Drawing.Point(15, 270);
            this.txtPartQuantity.Name = "txtPartQuantity";
            this.txtPartQuantity.Size = new System.Drawing.Size(630, 34);
            this.txtPartQuantity.TabIndex = 3;
            // 
            // dgvCompletedTasks
            // 
            this.dgvCompletedTasks.AllowUserToAddRows = false;
            this.dgvCompletedTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompletedTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompletedTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompletedTasks.ColumnHeadersHeight = 35;
            this.dgvCompletedTasks.Location = new System.Drawing.Point(15, 315);
            this.dgvCompletedTasks.Name = "dgvCompletedTasks";
            this.dgvCompletedTasks.ReadOnly = true;
            this.dgvCompletedTasks.RowHeadersVisible = false;
            this.dgvCompletedTasks.RowHeadersWidth = 62;
            this.dgvCompletedTasks.RowTemplate.Height = 28;
            this.dgvCompletedTasks.Size = new System.Drawing.Size(630, 256);
            this.dgvCompletedTasks.TabIndex = 0;
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.BackColor = System.Drawing.Color.White;
            this.pnlActionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActionButtons.Controls.Add(this.btnSaveWork);
            this.pnlActionButtons.Controls.Add(this.btnCancelWork);
            this.pnlActionButtons.Location = new System.Drawing.Point(700, 402);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Padding = new System.Windows.Forms.Padding(15);
            this.pnlActionButtons.Size = new System.Drawing.Size(680, 200);
            this.pnlActionButtons.TabIndex = 3;
            // 
            // btnSaveWork
            // 
            this.btnSaveWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSaveWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveWork.FlatAppearance.BorderSize = 0;
            this.btnSaveWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWork.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveWork.ForeColor = System.Drawing.Color.White;
            this.btnSaveWork.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveWork.IconColor = System.Drawing.Color.White;
            this.btnSaveWork.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveWork.IconSize = 24;
            this.btnSaveWork.Location = new System.Drawing.Point(20, 36);
            this.btnSaveWork.Name = "btnSaveWork";
            this.btnSaveWork.Size = new System.Drawing.Size(300, 55);
            this.btnSaveWork.TabIndex = 0;
            this.btnSaveWork.Text = "✅ İşlemi Kaydet";
            this.btnSaveWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveWork.UseVisualStyleBackColor = false;
            // 
            // btnCancelWork
            // 
            this.btnCancelWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelWork.FlatAppearance.BorderSize = 0;
            this.btnCancelWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelWork.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelWork.ForeColor = System.Drawing.Color.White;
            this.btnCancelWork.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelWork.IconColor = System.Drawing.Color.White;
            this.btnCancelWork.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelWork.IconSize = 24;
            this.btnCancelWork.Location = new System.Drawing.Point(345, 36);
            this.btnCancelWork.Name = "btnCancelWork";
            this.btnCancelWork.Size = new System.Drawing.Size(300, 55);
            this.btnCancelWork.TabIndex = 1;
            this.btnCancelWork.Text = "❌ İptal";
            this.btnCancelWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelWork.UseVisualStyleBackColor = false;
            // 
            // Atanan_Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1457, 800);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Atanan_Islemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atanan İşlemler - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Atanan_Islemler_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAssignedTasks.ResumeLayout(false);
            this.pnlAssignedTasks.ResumeLayout(false);
            this.pnlTasksList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTasks)).EndInit();
            this.tabPageTaskDetails.ResumeLayout(false);
            this.pnlTaskDetails.ResumeLayout(false);
            this.pnlDeviceInfo.ResumeLayout(false);
            this.pnlDeviceInfo.PerformLayout();
            this.pnlWorkProgress.ResumeLayout(false);
            this.pnlWorkProgress.PerformLayout();
            this.pnlPartsUsed.ResumeLayout(false);
            this.pnlPartsUsed.PerformLayout();
            this.pnlPartFilters.ResumeLayout(false);
            this.pnlPartFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedTasks)).EndInit();
            this.pnlActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTechnicianInfo;
        private FontAwesome.Sharp.IconButton btnLogout;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAssignedTasks;
        private System.Windows.Forms.TabPage tabPageTaskDetails;

        private System.Windows.Forms.Panel pnlAssignedTasks;
        private System.Windows.Forms.Panel pnlTasksList;
        private System.Windows.Forms.Panel pnlTaskDetails;
        private System.Windows.Forms.Panel pnlDeviceInfo;
        private System.Windows.Forms.Panel pnlWorkProgress;
        private System.Windows.Forms.Panel pnlPartsUsed;
        private System.Windows.Forms.Panel pnlPartFilters;
        private System.Windows.Forms.Panel pnlActionButtons;

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblBrandModel;
        private System.Windows.Forms.TextBox txtBrandModel;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.TextBox txtComplaint;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTechnicianNotes;
        private System.Windows.Forms.TextBox txtTechnicianNotes;

        private System.Windows.Forms.Label lblPartCategory;
        private System.Windows.Forms.ComboBox cmbPartCategory;
        private System.Windows.Forms.Label lblPartSearch;
        private System.Windows.Forms.TextBox txtPartSearch;
        private System.Windows.Forms.Label lblUsedParts;
        private System.Windows.Forms.ComboBox cmbUsedParts;
        private System.Windows.Forms.Label lblStockInfo;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label lblPartQuantity;
        private System.Windows.Forms.TextBox txtPartQuantity;

        private FontAwesome.Sharp.IconButton btnSaveWork;
        private FontAwesome.Sharp.IconButton btnCancelWork;

        private System.Windows.Forms.DataGridView dgvMyTasks;
        private System.Windows.Forms.DataGridView dgvCompletedTasks;
    }
}