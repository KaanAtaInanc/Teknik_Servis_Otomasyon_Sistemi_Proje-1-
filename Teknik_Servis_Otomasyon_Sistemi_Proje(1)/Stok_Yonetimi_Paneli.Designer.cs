namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Stok_Yonetimi_Paneli
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
            this.pnlStockForm = new System.Windows.Forms.Panel();
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
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.pnlList = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageOperations.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.pnlStockForm.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1400, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(422, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📦 Stok Yönetimi";
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
            this.btnHome.Location = new System.Drawing.Point(2520, 20);
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
            this.tabControlMain.Controls.Add(this.tabPageList);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 80);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1400, 720);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageOperations
            // 
            this.tabPageOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageOperations.Controls.Add(this.pnlOperations);
            this.tabPageOperations.Location = new System.Drawing.Point(4, 37);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageOperations.Size = new System.Drawing.Size(1392, 679);
            this.tabPageOperations.TabIndex = 0;
            this.tabPageOperations.Text = "➕ İşlemler";
            // 
            // pnlOperations
            // 
            this.pnlOperations.AutoScroll = true;
            this.pnlOperations.BackColor = System.Drawing.Color.White;
            this.pnlOperations.Controls.Add(this.pnlStockForm);
            this.pnlOperations.Controls.Add(this.pnlActionButtons);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperations.Location = new System.Drawing.Point(10, 10);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(1372, 659);
            this.pnlOperations.TabIndex = 0;
            // 
            // pnlStockForm
            // 
            this.pnlStockForm.BackColor = System.Drawing.Color.White;
            this.pnlStockForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pnlStockForm.Size = new System.Drawing.Size(1370, 380);
            this.pnlStockForm.TabIndex = 0;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPartName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPartName.Location = new System.Drawing.Point(15, 15);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(136, 28);
            this.lblPartName.TabIndex = 0;
            this.lblPartName.Text = "📦 Parça Adı";
            // 
            // txtPartName
            // 
            this.txtPartName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPartName.Location = new System.Drawing.Point(15, 48);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(320, 34);
            this.txtPartName.TabIndex = 1;
            // 
            // lblBrandModel
            // 
            this.lblBrandModel.AutoSize = true;
            this.lblBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrandModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBrandModel.Location = new System.Drawing.Point(360, 15);
            this.lblBrandModel.Name = "lblBrandModel";
            this.lblBrandModel.Size = new System.Drawing.Size(181, 28);
            this.lblBrandModel.TabIndex = 2;
            this.lblBrandModel.Text = "🏷️  Marka/Model";
            // 
            // txtBrandModel
            // 
            this.txtBrandModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrandModel.Location = new System.Drawing.Point(365, 46);
            this.txtBrandModel.Name = "txtBrandModel";
            this.txtBrandModel.Size = new System.Drawing.Size(320, 34);
            this.txtBrandModel.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblQuantity.Location = new System.Drawing.Point(705, 15);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(149, 28);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "📊 Stok Adedi";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(710, 46);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(320, 34);
            this.txtQuantity.TabIndex = 5;
            // 
            // lblCriticalLevel
            // 
            this.lblCriticalLevel.AutoSize = true;
            this.lblCriticalLevel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCriticalLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCriticalLevel.Location = new System.Drawing.Point(1050, 15);
            this.lblCriticalLevel.Name = "lblCriticalLevel";
            this.lblCriticalLevel.Size = new System.Drawing.Size(171, 28);
            this.lblCriticalLevel.TabIndex = 6;
            this.lblCriticalLevel.Text = "⚠️  Kritik Seviye";
            // 
            // txtCriticalLevel
            // 
            this.txtCriticalLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCriticalLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCriticalLevel.Location = new System.Drawing.Point(1055, 46);
            this.txtCriticalLevel.Name = "txtCriticalLevel";
            this.txtCriticalLevel.Size = new System.Drawing.Size(290, 34);
            this.txtCriticalLevel.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPrice.Location = new System.Drawing.Point(15, 85);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(155, 28);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "💰 Birim Fiyatı";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(15, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(320, 34);
            this.txtPrice.TabIndex = 9;
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.BackColor = System.Drawing.Color.White;
            this.pnlActionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActionButtons.Controls.Add(this.btnAdd);
            this.pnlActionButtons.Controls.Add(this.btnEdit);
            this.pnlActionButtons.Controls.Add(this.btnDelete);
            this.pnlActionButtons.Controls.Add(this.btnClear);
            this.pnlActionButtons.Location = new System.Drawing.Point(10, 400);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Padding = new System.Windows.Forms.Padding(15);
            this.pnlActionButtons.Size = new System.Drawing.Size(1370, 90);
            this.pnlActionButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(15, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 20;
            this.btnEdit.Location = new System.Drawing.Point(170, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 20;
            this.btnDelete.Location = new System.Drawing.Point(325, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 20;
            this.btnClear.Location = new System.Drawing.Point(480, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Temizle";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // tabPageList
            // 
            this.tabPageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageList.Controls.Add(this.pnlList);
            this.tabPageList.Location = new System.Drawing.Point(4, 37);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageList.Size = new System.Drawing.Size(1392, 679);
            this.tabPageList.TabIndex = 1;
            this.tabPageList.Text = "📋 Stok Listesi";
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.Controls.Add(this.dgvStock);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(10, 10);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(10);
            this.pnlList.Size = new System.Drawing.Size(1372, 659);
            this.pnlList.TabIndex = 0;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStock.ColumnHeadersHeight = 35;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(10, 10);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1352, 639);
            this.dgvStock.TabIndex = 0;
            // 
            // Stok_Yonetimi_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Stok_Yonetimi_Paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Yönetimi - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Stok_Yonetimi_Paneli_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOperations.ResumeLayout(false);
            this.pnlOperations.ResumeLayout(false);
            this.pnlStockForm.ResumeLayout(false);
            this.pnlStockForm.PerformLayout();
            this.pnlActionButtons.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnHome;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOperations;
        private System.Windows.Forms.TabPage tabPageList;

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlStockForm;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Panel pnlList;

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

        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnClear;

        private System.Windows.Forms.DataGridView dgvStock;
    }
}