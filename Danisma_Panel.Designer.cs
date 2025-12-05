namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Danisma_Panel
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
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDeviceEntry = new System.Windows.Forms.TabPage();
            this.pnlDeviceInfo = new System.Windows.Forms.Panel();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlDeviceDetails = new System.Windows.Forms.Panel();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblBrandModel = new System.Windows.Forms.Label();
            this.txtBrandModel = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.btnCreateService = new FontAwesome.Sharp.IconButton();
            this.btnCancelService = new FontAwesome.Sharp.IconButton();
            this.dgvDeviceList = new System.Windows.Forms.DataGridView();
            this.tabPageStaffAssignment = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnlVerification = new System.Windows.Forms.Panel();
            this.lblDeviceNameVerif = new System.Windows.Forms.Label();
            this.txtDeviceNameVerif = new System.Windows.Forms.TextBox();
            this.lblBrandModelVerif = new System.Windows.Forms.Label();
            this.txtBrandModelVerif = new System.Windows.Forms.TextBox();
            this.lblSerialNoVerif = new System.Windows.Forms.Label();
            this.txtSerialNoVerif = new System.Windows.Forms.TextBox();
            this.lblComplaintVerif = new System.Windows.Forms.Label();
            this.txtComplaintVerif = new System.Windows.Forms.TextBox();
            this.pnlStaffSelection = new System.Windows.Forms.Panel();
            this.lblStaffSelection = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.btnAssignStaff = new FontAwesome.Sharp.IconButton();
            this.btnCancelAssignment = new FontAwesome.Sharp.IconButton();
            this.dgvAssignmentList = new System.Windows.Forms.DataGridView();
            this.pnlDataGrids = new System.Windows.Forms.Panel();
            this.BTN_Oturum_Kapat = new FontAwesome.Sharp.IconButton();
            this.BTN_Sistem_Kapat = new FontAwesome.Sharp.IconButton();
            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageDeviceEntry.SuspendLayout();
            this.pnlDeviceInfo.SuspendLayout();
            this.pnlCustomerInfo.SuspendLayout();
            this.pnlDeviceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).BeginInit();
            this.tabPageStaffAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlVerification.SuspendLayout();
            this.pnlStaffSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.BTN_Oturum_Kapat);
            this.pnlHeader.Controls.Add(this.BTN_Sistem_Kapat);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1656, 111);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(373, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danışma Paneli";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 24;
            this.btnExit.Location = new System.Drawing.Point(2686, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sistemi Kapat";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
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
            this.btnLogout.Location = new System.Drawing.Point(2536, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Oturumu Kapat";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageDeviceEntry);
            this.tabControlMain.Controls.Add(this.tabPageStaffAssignment);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 111);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1656, 730);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageDeviceEntry
            // 
            this.tabPageDeviceEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageDeviceEntry.Controls.Add(this.pnlDeviceInfo);
            this.tabPageDeviceEntry.Location = new System.Drawing.Point(4, 37);
            this.tabPageDeviceEntry.Name = "tabPageDeviceEntry";
            this.tabPageDeviceEntry.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageDeviceEntry.Size = new System.Drawing.Size(1648, 689);
            this.tabPageDeviceEntry.TabIndex = 0;
            this.tabPageDeviceEntry.Text = "🖥️  Cihaz Girişi";
            // 
            // pnlDeviceInfo
            // 
            this.pnlDeviceInfo.AutoScroll = true;
            this.pnlDeviceInfo.BackColor = System.Drawing.Color.White;
            this.pnlDeviceInfo.Controls.Add(this.pnlCustomerInfo);
            this.pnlDeviceInfo.Controls.Add(this.pnlDeviceDetails);
            this.pnlDeviceInfo.Controls.Add(this.btnCreateService);
            this.pnlDeviceInfo.Controls.Add(this.btnCancelService);
            this.pnlDeviceInfo.Controls.Add(this.dgvDeviceList);
            this.pnlDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeviceInfo.Location = new System.Drawing.Point(10, 10);
            this.pnlDeviceInfo.Name = "pnlDeviceInfo";
            this.pnlDeviceInfo.Size = new System.Drawing.Size(1628, 669);
            this.pnlDeviceInfo.TabIndex = 0;
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.BackColor = System.Drawing.Color.White;
            this.pnlCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerName);
            this.pnlCustomerInfo.Controls.Add(this.txtCustomerName);
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerSurname);
            this.pnlCustomerInfo.Controls.Add(this.txtCustomerSurname);
            this.pnlCustomerInfo.Controls.Add(this.lblPhoneNumber);
            this.pnlCustomerInfo.Controls.Add(this.txtPhoneNumber);
            this.pnlCustomerInfo.Controls.Add(this.lblEmail);
            this.pnlCustomerInfo.Controls.Add(this.txtEmail);
            this.pnlCustomerInfo.Controls.Add(this.lblCity);
            this.pnlCustomerInfo.Controls.Add(this.txtCity);
            this.pnlCustomerInfo.Controls.Add(this.lblDistrict);
            this.pnlCustomerInfo.Controls.Add(this.txtDistrict);
            this.pnlCustomerInfo.Controls.Add(this.lblAddress);
            this.pnlCustomerInfo.Controls.Add(this.txtAddress);
            this.pnlCustomerInfo.Location = new System.Drawing.Point(10, 10);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCustomerInfo.Size = new System.Drawing.Size(650, 300);
            this.pnlCustomerInfo.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCustomerName.Location = new System.Drawing.Point(15, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(157, 28);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "👤 Müşteri Adı";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerName.Location = new System.Drawing.Point(15, 40);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(290, 34);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCustomerSurname.Location = new System.Drawing.Point(330, 9);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(188, 28);
            this.lblCustomerSurname.TabIndex = 2;
            this.lblCustomerSurname.Text = "👤 Müşteri Soyadı";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerSurname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerSurname.Location = new System.Drawing.Point(330, 40);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(290, 34);
            this.txtCustomerSurname.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(15, 77);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(219, 28);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "☎️  Telefon Numarası";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(15, 110);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(290, 34);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEmail.Location = new System.Drawing.Point(330, 77);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 28);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "📧 E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(330, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 34);
            this.txtEmail.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCity.Location = new System.Drawing.Point(15, 149);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 28);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "🏙️  İl";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCity.Location = new System.Drawing.Point(15, 180);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(290, 34);
            this.txtCity.TabIndex = 9;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDistrict.Location = new System.Drawing.Point(330, 147);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(79, 28);
            this.lblDistrict.TabIndex = 10;
            this.lblDistrict.Text = "📍 İlçe";
            // 
            // txtDistrict
            // 
            this.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistrict.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDistrict.Location = new System.Drawing.Point(330, 180);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(290, 34);
            this.txtDistrict.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAddress.Location = new System.Drawing.Point(10, 219);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(147, 28);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "📮 Açık Adres";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(15, 250);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(605, 34);
            this.txtAddress.TabIndex = 13;
            // 
            // pnlDeviceDetails
            // 
            this.pnlDeviceDetails.BackColor = System.Drawing.Color.White;
            this.pnlDeviceDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeviceDetails.Controls.Add(this.lblDeviceName);
            this.pnlDeviceDetails.Controls.Add(this.txtDeviceName);
            this.pnlDeviceDetails.Controls.Add(this.lblBrandModel);
            this.pnlDeviceDetails.Controls.Add(this.txtBrandModel);
            this.pnlDeviceDetails.Controls.Add(this.lblSerialNo);
            this.pnlDeviceDetails.Controls.Add(this.txtSerialNo);
            this.pnlDeviceDetails.Controls.Add(this.lblComplaint);
            this.pnlDeviceDetails.Controls.Add(this.txtComplaint);
            this.pnlDeviceDetails.Location = new System.Drawing.Point(10, 320);
            this.pnlDeviceDetails.Name = "pnlDeviceDetails";
            this.pnlDeviceDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDeviceDetails.Size = new System.Drawing.Size(650, 280);
            this.pnlDeviceDetails.TabIndex = 1;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDeviceName.Location = new System.Drawing.Point(15, 9);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(135, 28);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "💻 Cihaz Adı";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeviceName.Location = new System.Drawing.Point(15, 40);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(605, 34);
            this.txtDeviceName.TabIndex = 1;
            // 
            // lblBrandModel
            // 
            this.lblBrandModel.AutoSize = true;
            this.lblBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrandModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBrandModel.Location = new System.Drawing.Point(15, 77);
            this.lblBrandModel.Name = "lblBrandModel";
            this.lblBrandModel.Size = new System.Drawing.Size(181, 28);
            this.lblBrandModel.TabIndex = 2;
            this.lblBrandModel.Text = "🏷️  Marka/Model";
            // 
            // txtBrandModel
            // 
            this.txtBrandModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrandModel.Location = new System.Drawing.Point(15, 110);
            this.txtBrandModel.Name = "txtBrandModel";
            this.txtBrandModel.Size = new System.Drawing.Size(290, 34);
            this.txtBrandModel.TabIndex = 3;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSerialNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSerialNo.Location = new System.Drawing.Point(330, 79);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(179, 28);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "🔢 Seri Numarası";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSerialNo.Location = new System.Drawing.Point(330, 110);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(290, 34);
            this.txtSerialNo.TabIndex = 5;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblComplaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblComplaint.Location = new System.Drawing.Point(15, 149);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(206, 28);
            this.lblComplaint.TabIndex = 6;
            this.lblComplaint.Text = "⚠️  Müşteri Şikayeti";
            // 
            // txtComplaint
            // 
            this.txtComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplaint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComplaint.Location = new System.Drawing.Point(15, 180);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(605, 80);
            this.txtComplaint.TabIndex = 7;
            // 
            // btnCreateService
            // 
            this.btnCreateService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCreateService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateService.FlatAppearance.BorderSize = 0;
            this.btnCreateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateService.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreateService.ForeColor = System.Drawing.Color.White;
            this.btnCreateService.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnCreateService.IconColor = System.Drawing.Color.White;
            this.btnCreateService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateService.IconSize = 24;
            this.btnCreateService.Location = new System.Drawing.Point(350, 610);
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.Size = new System.Drawing.Size(150, 45);
            this.btnCreateService.TabIndex = 8;
            this.btnCreateService.Text = "Kaydet";
            this.btnCreateService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateService.UseVisualStyleBackColor = false;
            // 
            // btnCancelService
            // 
            this.btnCancelService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelService.FlatAppearance.BorderSize = 0;
            this.btnCancelService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelService.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelService.ForeColor = System.Drawing.Color.White;
            this.btnCancelService.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelService.IconColor = System.Drawing.Color.White;
            this.btnCancelService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelService.IconSize = 24;
            this.btnCancelService.Location = new System.Drawing.Point(515, 610);
            this.btnCancelService.Name = "btnCancelService";
            this.btnCancelService.Size = new System.Drawing.Size(150, 45);
            this.btnCancelService.TabIndex = 9;
            this.btnCancelService.Text = "İptal";
            this.btnCancelService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelService.UseVisualStyleBackColor = false;
            // 
            // dgvDeviceList
            // 
            this.dgvDeviceList.AllowUserToAddRows = false;
            this.dgvDeviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeviceList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeviceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeviceList.ColumnHeadersHeight = 35;
            this.dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeviceList.Location = new System.Drawing.Point(680, 10);
            this.dgvDeviceList.Name = "dgvDeviceList";
            this.dgvDeviceList.ReadOnly = true;
            this.dgvDeviceList.RowHeadersVisible = false;
            this.dgvDeviceList.RowHeadersWidth = 62;
            this.dgvDeviceList.RowTemplate.Height = 28;
            this.dgvDeviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeviceList.Size = new System.Drawing.Size(945, 571);
            this.dgvDeviceList.TabIndex = 10;
            // 
            // tabPageStaffAssignment
            // 
            this.tabPageStaffAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageStaffAssignment.Controls.Add(this.dataGridView2);
            this.tabPageStaffAssignment.Controls.Add(this.pnlVerification);
            this.tabPageStaffAssignment.Controls.Add(this.pnlStaffSelection);
            this.tabPageStaffAssignment.Controls.Add(this.btnAssignStaff);
            this.tabPageStaffAssignment.Controls.Add(this.btnCancelAssignment);
            this.tabPageStaffAssignment.Controls.Add(this.dgvAssignmentList);
            this.tabPageStaffAssignment.Location = new System.Drawing.Point(4, 37);
            this.tabPageStaffAssignment.Name = "tabPageStaffAssignment";
            this.tabPageStaffAssignment.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageStaffAssignment.Size = new System.Drawing.Size(1648, 679);
            this.tabPageStaffAssignment.TabIndex = 1;
            this.tabPageStaffAssignment.Text = "👥 Personel Ataması";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersHeight = 35;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Location = new System.Drawing.Point(680, 346);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(955, 320);
            this.dataGridView2.TabIndex = 14;
            // 
            // pnlVerification
            // 
            this.pnlVerification.BackColor = System.Drawing.Color.White;
            this.pnlVerification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVerification.Controls.Add(this.lblDeviceNameVerif);
            this.pnlVerification.Controls.Add(this.txtDeviceNameVerif);
            this.pnlVerification.Controls.Add(this.lblBrandModelVerif);
            this.pnlVerification.Controls.Add(this.txtBrandModelVerif);
            this.pnlVerification.Controls.Add(this.lblSerialNoVerif);
            this.pnlVerification.Controls.Add(this.txtSerialNoVerif);
            this.pnlVerification.Controls.Add(this.lblComplaintVerif);
            this.pnlVerification.Controls.Add(this.txtComplaintVerif);
            this.pnlVerification.Location = new System.Drawing.Point(10, 10);
            this.pnlVerification.Name = "pnlVerification";
            this.pnlVerification.Padding = new System.Windows.Forms.Padding(15);
            this.pnlVerification.Size = new System.Drawing.Size(650, 320);
            this.pnlVerification.TabIndex = 0;
            // 
            // lblDeviceNameVerif
            // 
            this.lblDeviceNameVerif.AutoSize = true;
            this.lblDeviceNameVerif.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceNameVerif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDeviceNameVerif.Location = new System.Drawing.Point(15, 9);
            this.lblDeviceNameVerif.Name = "lblDeviceNameVerif";
            this.lblDeviceNameVerif.Size = new System.Drawing.Size(260, 28);
            this.lblDeviceNameVerif.TabIndex = 0;
            this.lblDeviceNameVerif.Text = "💻 Cihaz Adı (Doğrulama)";
            // 
            // txtDeviceNameVerif
            // 
            this.txtDeviceNameVerif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtDeviceNameVerif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceNameVerif.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeviceNameVerif.Location = new System.Drawing.Point(15, 40);
            this.txtDeviceNameVerif.Name = "txtDeviceNameVerif";
            this.txtDeviceNameVerif.ReadOnly = true;
            this.txtDeviceNameVerif.Size = new System.Drawing.Size(605, 34);
            this.txtDeviceNameVerif.TabIndex = 1;
            // 
            // lblBrandModelVerif
            // 
            this.lblBrandModelVerif.AutoSize = true;
            this.lblBrandModelVerif.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrandModelVerif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBrandModelVerif.Location = new System.Drawing.Point(11, 79);
            this.lblBrandModelVerif.Name = "lblBrandModelVerif";
            this.lblBrandModelVerif.Size = new System.Drawing.Size(306, 28);
            this.lblBrandModelVerif.TabIndex = 2;
            this.lblBrandModelVerif.Text = "🏷️  Marka/Model (Doğrulama)";
            // 
            // txtBrandModelVerif
            // 
            this.txtBrandModelVerif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtBrandModelVerif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandModelVerif.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrandModelVerif.Location = new System.Drawing.Point(15, 110);
            this.txtBrandModelVerif.Name = "txtBrandModelVerif";
            this.txtBrandModelVerif.ReadOnly = true;
            this.txtBrandModelVerif.Size = new System.Drawing.Size(290, 34);
            this.txtBrandModelVerif.TabIndex = 3;
            // 
            // lblSerialNoVerif
            // 
            this.lblSerialNoVerif.AutoSize = true;
            this.lblSerialNoVerif.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSerialNoVerif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSerialNoVerif.Location = new System.Drawing.Point(326, 79);
            this.lblSerialNoVerif.Name = "lblSerialNoVerif";
            this.lblSerialNoVerif.Size = new System.Drawing.Size(304, 28);
            this.lblSerialNoVerif.TabIndex = 4;
            this.lblSerialNoVerif.Text = "🔢 Seri Numarası (Doğrulama)";
            // 
            // txtSerialNoVerif
            // 
            this.txtSerialNoVerif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSerialNoVerif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerialNoVerif.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSerialNoVerif.Location = new System.Drawing.Point(330, 110);
            this.txtSerialNoVerif.Name = "txtSerialNoVerif";
            this.txtSerialNoVerif.ReadOnly = true;
            this.txtSerialNoVerif.Size = new System.Drawing.Size(290, 34);
            this.txtSerialNoVerif.TabIndex = 5;
            // 
            // lblComplaintVerif
            // 
            this.lblComplaintVerif.AutoSize = true;
            this.lblComplaintVerif.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblComplaintVerif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblComplaintVerif.Location = new System.Drawing.Point(11, 149);
            this.lblComplaintVerif.Name = "lblComplaintVerif";
            this.lblComplaintVerif.Size = new System.Drawing.Size(331, 28);
            this.lblComplaintVerif.TabIndex = 6;
            this.lblComplaintVerif.Text = "⚠️  Müşteri Şikayeti (Doğrulama)";
            // 
            // txtComplaintVerif
            // 
            this.txtComplaintVerif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtComplaintVerif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplaintVerif.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComplaintVerif.Location = new System.Drawing.Point(15, 180);
            this.txtComplaintVerif.Multiline = true;
            this.txtComplaintVerif.Name = "txtComplaintVerif";
            this.txtComplaintVerif.ReadOnly = true;
            this.txtComplaintVerif.Size = new System.Drawing.Size(605, 80);
            this.txtComplaintVerif.TabIndex = 7;
            // 
            // pnlStaffSelection
            // 
            this.pnlStaffSelection.BackColor = System.Drawing.Color.White;
            this.pnlStaffSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaffSelection.Controls.Add(this.lblStaffSelection);
            this.pnlStaffSelection.Controls.Add(this.cmbStaff);
            this.pnlStaffSelection.Location = new System.Drawing.Point(10, 340);
            this.pnlStaffSelection.Name = "pnlStaffSelection";
            this.pnlStaffSelection.Padding = new System.Windows.Forms.Padding(15);
            this.pnlStaffSelection.Size = new System.Drawing.Size(650, 120);
            this.pnlStaffSelection.TabIndex = 1;
            // 
            // lblStaffSelection
            // 
            this.lblStaffSelection.AutoSize = true;
            this.lblStaffSelection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaffSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStaffSelection.Location = new System.Drawing.Point(15, 15);
            this.lblStaffSelection.Name = "lblStaffSelection";
            this.lblStaffSelection.Size = new System.Drawing.Size(194, 28);
            this.lblStaffSelection.TabIndex = 0;
            this.lblStaffSelection.Text = "👨‍💼 Personel Seçimi";
            // 
            // cmbStaff
            // 
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStaff.Location = new System.Drawing.Point(15, 40);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(605, 36);
            this.cmbStaff.TabIndex = 1;
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
            // 
            // btnAssignStaff
            // 
            this.btnAssignStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAssignStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignStaff.FlatAppearance.BorderSize = 0;
            this.btnAssignStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignStaff.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAssignStaff.ForeColor = System.Drawing.Color.White;
            this.btnAssignStaff.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAssignStaff.IconColor = System.Drawing.Color.White;
            this.btnAssignStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssignStaff.IconSize = 24;
            this.btnAssignStaff.Location = new System.Drawing.Point(350, 470);
            this.btnAssignStaff.Name = "btnAssignStaff";
            this.btnAssignStaff.Size = new System.Drawing.Size(150, 45);
            this.btnAssignStaff.TabIndex = 11;
            this.btnAssignStaff.Text = "Ata";
            this.btnAssignStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssignStaff.UseVisualStyleBackColor = false;
            // 
            // btnCancelAssignment
            // 
            this.btnCancelAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelAssignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAssignment.FlatAppearance.BorderSize = 0;
            this.btnCancelAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAssignment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelAssignment.ForeColor = System.Drawing.Color.White;
            this.btnCancelAssignment.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelAssignment.IconColor = System.Drawing.Color.White;
            this.btnCancelAssignment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelAssignment.IconSize = 24;
            this.btnCancelAssignment.Location = new System.Drawing.Point(515, 470);
            this.btnCancelAssignment.Name = "btnCancelAssignment";
            this.btnCancelAssignment.Size = new System.Drawing.Size(150, 45);
            this.btnCancelAssignment.TabIndex = 12;
            this.btnCancelAssignment.Text = "İptal";
            this.btnCancelAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelAssignment.UseVisualStyleBackColor = false;
            // 
            // dgvAssignmentList
            // 
            this.dgvAssignmentList.AllowUserToAddRows = false;
            this.dgvAssignmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignmentList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignmentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignmentList.ColumnHeadersHeight = 35;
            this.dgvAssignmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAssignmentList.Location = new System.Drawing.Point(680, 10);
            this.dgvAssignmentList.Name = "dgvAssignmentList";
            this.dgvAssignmentList.ReadOnly = true;
            this.dgvAssignmentList.RowHeadersVisible = false;
            this.dgvAssignmentList.RowHeadersWidth = 62;
            this.dgvAssignmentList.RowTemplate.Height = 28;
            this.dgvAssignmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignmentList.Size = new System.Drawing.Size(955, 320);
            this.dgvAssignmentList.TabIndex = 13;
            // 
            // pnlDataGrids
            // 
            this.pnlDataGrids.Location = new System.Drawing.Point(0, 0);
            this.pnlDataGrids.Name = "pnlDataGrids";
            this.pnlDataGrids.Size = new System.Drawing.Size(200, 100);
            this.pnlDataGrids.TabIndex = 0;
            // 
            // BTN_Oturum_Kapat
            // 
            this.BTN_Oturum_Kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.BTN_Oturum_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Oturum_Kapat.FlatAppearance.BorderSize = 0;
            this.BTN_Oturum_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Oturum_Kapat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.BTN_Oturum_Kapat.ForeColor = System.Drawing.Color.White;
            this.BTN_Oturum_Kapat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.BTN_Oturum_Kapat.IconColor = System.Drawing.Color.White;
            this.BTN_Oturum_Kapat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Oturum_Kapat.Location = new System.Drawing.Point(994, 3);
            this.BTN_Oturum_Kapat.Name = "BTN_Oturum_Kapat";
            this.BTN_Oturum_Kapat.Size = new System.Drawing.Size(313, 102);
            this.BTN_Oturum_Kapat.TabIndex = 8;
            this.BTN_Oturum_Kapat.Text = "🚪 Oturumu Kapat";
            this.BTN_Oturum_Kapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Oturum_Kapat.UseVisualStyleBackColor = false;
            this.BTN_Oturum_Kapat.Click += new System.EventHandler(this.BTN_Oturum_Kapat_Click);
            // 
            // BTN_Sistem_Kapat
            // 
            this.BTN_Sistem_Kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Sistem_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sistem_Kapat.FlatAppearance.BorderSize = 0;
            this.BTN_Sistem_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Sistem_Kapat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.BTN_Sistem_Kapat.ForeColor = System.Drawing.Color.White;
            this.BTN_Sistem_Kapat.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.BTN_Sistem_Kapat.IconColor = System.Drawing.Color.White;
            this.BTN_Sistem_Kapat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Sistem_Kapat.Location = new System.Drawing.Point(1343, 3);
            this.BTN_Sistem_Kapat.Name = "BTN_Sistem_Kapat";
            this.BTN_Sistem_Kapat.Size = new System.Drawing.Size(313, 102);
            this.BTN_Sistem_Kapat.TabIndex = 9;
            this.BTN_Sistem_Kapat.Text = "⏻️  Sistemi Kapat";
            this.BTN_Sistem_Kapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sistem_Kapat.UseVisualStyleBackColor = false;
            this.BTN_Sistem_Kapat.Click += new System.EventHandler(this.BTN_Sistem_Kapat_Click);
            // 
            // Danisma_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1656, 841);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Danisma_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danışma Paneli - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Danisma_Panel_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDeviceEntry.ResumeLayout(false);
            this.pnlDeviceInfo.ResumeLayout(false);
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.pnlDeviceDetails.ResumeLayout(false);
            this.pnlDeviceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).EndInit();
            this.tabPageStaffAssignment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlVerification.ResumeLayout(false);
            this.pnlVerification.PerformLayout();
            this.pnlStaffSelection.ResumeLayout(false);
            this.pnlStaffSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnLogout;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDeviceEntry;
        private System.Windows.Forms.TabPage tabPageStaffAssignment;

        private System.Windows.Forms.Panel pnlDeviceInfo;
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.Panel pnlDeviceDetails;
        private System.Windows.Forms.Panel pnlVerification;
        private System.Windows.Forms.Panel pnlStaffSelection;
        private System.Windows.Forms.Panel pnlDataGrids;

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblBrandModel;
        private System.Windows.Forms.TextBox txtBrandModel;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.TextBox txtComplaint;

        private System.Windows.Forms.Label lblDeviceNameVerif;
        private System.Windows.Forms.TextBox txtDeviceNameVerif;
        private System.Windows.Forms.Label lblBrandModelVerif;
        private System.Windows.Forms.TextBox txtBrandModelVerif;
        private System.Windows.Forms.Label lblSerialNoVerif;
        private System.Windows.Forms.TextBox txtSerialNoVerif;
        private System.Windows.Forms.Label lblComplaintVerif;
        private System.Windows.Forms.TextBox txtComplaintVerif;

        private System.Windows.Forms.Label lblStaffSelection;
        private System.Windows.Forms.ComboBox cmbStaff;

        private FontAwesome.Sharp.IconButton btnCreateService;
        private FontAwesome.Sharp.IconButton btnCancelService;
        private FontAwesome.Sharp.IconButton btnAssignStaff;
        private FontAwesome.Sharp.IconButton btnCancelAssignment;

        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.DataGridView dgvAssignmentList;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FontAwesome.Sharp.IconButton BTN_Oturum_Kapat;
        private FontAwesome.Sharp.IconButton BTN_Sistem_Kapat;
    }
}