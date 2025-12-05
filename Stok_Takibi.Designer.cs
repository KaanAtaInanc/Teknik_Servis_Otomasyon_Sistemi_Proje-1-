namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Stok_Takibi
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
            this.btnHome = new System.Windows.Forms.Button();

            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOperations = new System.Windows.Forms.TabPage();
            this.tabPageList = new System.Windows.Forms.TabPage();

            this.pnlOperations = new System.Windows.Forms.Panel();
            this.pnlStockForm = new System.Windows.Forms.Panel();
            this.pnlActionButtons = new System.Windows.Forms.Panel();

            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPartName = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblBrandModel = new System.Windows.Forms.Label();
            this.txtBrandModel = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblCriticalLevel = new System.Windows.Forms.Label();
            this.txtCriticalLevel = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.pnlList = new System.Windows.Forms.Panel();
            this.pnlSearchFilter = new System.Windows.Forms.Panel();
            this.pnlDataGrid = new System.Windows.Forms.Panel();

            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnSearchReset = new System.Windows.Forms.Button();

            this.dgvStock = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageOperations.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.pnlStockForm.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlSearchFilter.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();

            // ========== HEADER PANEL ==========
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnHome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "📦 Stok Yönetimi";

            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(1320, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "🏠 Ana Sayfa";
            this.btnHome.UseVisualStyleBackColor = false;

            // ========== TAB CONTROL ==========
            this.tabControlMain.Controls.Add(this.tabPageOperations);
            this.tabControlMain.Controls.Add(this.tabPageList);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 80);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1400, 720);
            this.tabControlMain.TabIndex = 0;

            // ========== TAB PAGE 1: OPERATIONS ==========
            this.tabPageOperations.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.tabPageOperations.Controls.Add(this.pnlOperations);
            this.tabPageOperations.Location = new System.Drawing.Point(4, 37);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageOperations.Size = new System.Drawing.Size(1392, 679);
            this.tabPageOperations.TabIndex = 0;
            this.tabPageOperations.Text = "➕ İşlemler";

            this.pnlOperations.AutoScroll = true;
            this.pnlOperations.BackColor = System.Drawing.Color.White;
            this.pnlOperations.Controls.Add(this.pnlStockForm);
            this.pnlOperations.Controls.Add(this.pnlActionButtons);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperations.Location = new System.Drawing.Point(10, 10);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(1372, 659);

            // ===== STOCK FORM =====
            this.pnlStockForm.BackColor = System.Drawing.Color.White;
            this.pnlStockForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStockForm.Controls.Add(this.lblCategory);
            this.pnlStockForm.Controls.Add(this.cmbCategory);
            this.pnlStockForm.Controls.Add(this.lblPartName);
            this.pnlStockForm.Controls.Add(this.txtPartName);
            this.pnlStockForm.Controls.Add(this.lblBrandModel);
            this.pnlStockForm.Controls.Add(this.txtBrandModel);
            this.pnlStockForm.Controls.Add(this.lblQuantity);
            this.pnlStockForm.Controls.Add(this.txtQuantity);
            this.pnlStockForm.Controls.Add(this.lblCriticalLevel);
            this.pnlStockForm.Controls.Add(this.txtCriticalLevel);
            this.pnlStockForm.Controls.Add(this.lblPrice);
            this.pnlStockForm.Controls.Add(this.txtPrice);
            this.pnlStockForm.Location = new System.Drawing.Point(10, 10);
            this.pnlStockForm.Name = "pnlStockForm";
            this.pnlStockForm.Padding = new System.Windows.Forms.Padding(15);
            this.pnlStockForm.Size = new System.Drawing.Size(1370, 420);

            // Kategori
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblCategory.Location = new System.Drawing.Point(15, 15);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "🏷️  Kategori";

            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Items.AddRange(new object[] { "Kategori Seçiniz", "Ekran", "Batarya", "Kasa", "Bellek (RAM)", "Depolama (SSD/HDD)", "Konnektör", "Şarj Aleti", "Başka" });
            this.cmbCategory.Location = new System.Drawing.Point(15, 48);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(320, 36);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndex = 0;

            // Parça Adı
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPartName.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPartName.Location = new System.Drawing.Point(360, 15);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Text = "📦 Parça Adı";

            this.txtPartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPartName.Location = new System.Drawing.Point(360, 48);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(320, 34);
            this.txtPartName.TabIndex = 3;

            // Marka/Model
            this.lblBrandModel.AutoSize = true;
            this.lblBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrandModel.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblBrandModel.Location = new System.Drawing.Point(705, 15);
            this.lblBrandModel.Name = "lblBrandModel";
            this.lblBrandModel.Text = "🏷️  Marka/Model";

            this.txtBrandModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrandModel.Location = new System.Drawing.Point(710, 48);
            this.txtBrandModel.Name = "txtBrandModel";
            this.txtBrandModel.Size = new System.Drawing.Size(320, 34);
            this.txtBrandModel.TabIndex = 5;

            // Miktar
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblQuantity.Location = new System.Drawing.Point(1050, 15);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Text = "📊 Stok Adedi";

            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(1055, 48);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(290, 34);
            this.txtQuantity.TabIndex = 7;

            // Kritik Seviye
            this.lblCriticalLevel.AutoSize = true;
            this.lblCriticalLevel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCriticalLevel.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblCriticalLevel.Location = new System.Drawing.Point(15, 95);
            this.lblCriticalLevel.Name = "lblCriticalLevel";
            this.lblCriticalLevel.Text = "⚠️  Kritik Seviye";

            this.txtCriticalLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCriticalLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCriticalLevel.Location = new System.Drawing.Point(15, 128);
            this.txtCriticalLevel.Name = "txtCriticalLevel";
            this.txtCriticalLevel.Size = new System.Drawing.Size(320, 34);
            this.txtCriticalLevel.TabIndex = 9;
            this.txtCriticalLevel.Text = "10";

            // Fiyat
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblPrice.Location = new System.Drawing.Point(360, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Text = "💰 Birim Fiyatı";

            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(360, 128);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(320, 34);
            this.txtPrice.TabIndex = 11;

            // ===== ACTION BUTTONS =====
            this.pnlActionButtons.BackColor = System.Drawing.Color.White;
            this.pnlActionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActionButtons.Controls.Add(this.btnAdd);
            this.pnlActionButtons.Controls.Add(this.btnEdit);
            this.pnlActionButtons.Controls.Add(this.btnDelete);
            this.pnlActionButtons.Controls.Add(this.btnClear);
            this.pnlActionButtons.Location = new System.Drawing.Point(10, 440);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Padding = new System.Windows.Forms.Padding(15);
            this.pnlActionButtons.Size = new System.Drawing.Size(1370, 90);

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "✅ Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;

            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(170, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✏️  Düzenle";
            this.btnEdit.UseVisualStyleBackColor = false;

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(325, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "🗑️  Sil";
            this.btnDelete.UseVisualStyleBackColor = false;

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(480, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "🧹 Temizle";
            this.btnClear.UseVisualStyleBackColor = false;

            // ========== TAB PAGE 2: LIST ==========
            this.tabPageList.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.tabPageList.Controls.Add(this.pnlList);
            this.tabPageList.Location = new System.Drawing.Point(4, 37);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageList.Size = new System.Drawing.Size(1392, 679);
            this.tabPageList.TabIndex = 1;
            this.tabPageList.Text = "📋 Stok Listesi";

            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.Controls.Add(this.pnlDataGrid);
            this.pnlList.Controls.Add(this.pnlSearchFilter);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(10, 10);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1372, 659);

            // ===== SEARCH & FILTER PANEL =====
            this.pnlSearchFilter.BackColor = System.Drawing.Color.White;
            this.pnlSearchFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchFilter.Controls.Add(this.lblSearch);
            this.pnlSearchFilter.Controls.Add(this.txtSearch);
            this.pnlSearchFilter.Controls.Add(this.lblFilterBy);
            this.pnlSearchFilter.Controls.Add(this.cmbFilterBy);
            this.pnlSearchFilter.Controls.Add(this.btnSearchReset);
            this.pnlSearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchFilter.Height = 90;
            this.pnlSearchFilter.Name = "pnlSearchFilter";
            this.pnlSearchFilter.Padding = new System.Windows.Forms.Padding(15);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblSearch.Location = new System.Drawing.Point(15, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "🔍 Arama";

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(15, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 34);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Ara...";

            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblFilterBy.Location = new System.Drawing.Point(440, 15);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Text = "📂 Kategoriye Göre";

            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterBy.Items.AddRange(new object[] { "Tüm Kategoriler", "Ekran", "Batarya", "Kasa", "Bellek (RAM)", "Depolama (SSD/HDD)", "Konnektör", "Şarj Aleti", "Başka" });
            this.cmbFilterBy.Location = new System.Drawing.Point(440, 40);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(200, 36);
            this.cmbFilterBy.TabIndex = 1;
            this.cmbFilterBy.SelectedIndex = 0;

            this.btnSearchReset.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSearchReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReset.FlatAppearance.BorderSize = 0;
            this.btnSearchReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchReset.ForeColor = System.Drawing.Color.White;
            this.btnSearchReset.Location = new System.Drawing.Point(660, 40);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(120, 36);
            this.btnSearchReset.TabIndex = 2;
            this.btnSearchReset.Text = "🔄 Sıfırla";
            this.btnSearchReset.UseVisualStyleBackColor = false;

            // ===== DATA GRID PANEL =====
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvStock);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 90);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(10);

            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStock.ColumnHeadersHeight = 35;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(10, 10);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1352, 550);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStock_CellFormatting);

            // ========== FORM ==========
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Stok_Takibi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Yönetimi - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Stok_Takibi_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOperations.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.pnlOperations.ResumeLayout(false);
            this.pnlStockForm.ResumeLayout(false);
            this.pnlStockForm.PerformLayout();
            this.pnlActionButtons.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            this.pnlSearchFilter.ResumeLayout(false);
            this.pnlSearchFilter.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOperations;
        private System.Windows.Forms.TabPage tabPageList;

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlStockForm;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlSearchFilter;
        private System.Windows.Forms.Panel pnlDataGrid;

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblBrandModel;
        private System.Windows.Forms.TextBox txtBrandModel;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCriticalLevel;
        private System.Windows.Forms.TextBox txtCriticalLevel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.Button btnSearchReset;

        private System.Windows.Forms.DataGridView dgvStock;
    }
}