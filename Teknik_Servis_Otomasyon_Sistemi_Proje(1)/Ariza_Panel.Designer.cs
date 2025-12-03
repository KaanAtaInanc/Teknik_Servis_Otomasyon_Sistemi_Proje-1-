namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Ariza_Panel
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFaultType = new System.Windows.Forms.Label();
            this.cmbFaultType = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.btnClearFilter = new FontAwesome.Sharp.IconButton();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvFaults = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaults)).BeginInit();
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
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(358, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔧 Arıza Takip";
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
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblFaultType);
            this.pnlFilter.Controls.Add(this.cmbFaultType);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Controls.Add(this.cmbStatus);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.btnClearFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 80);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(15);
            this.pnlFilter.Size = new System.Drawing.Size(1400, 100);
            this.pnlFilter.TabIndex = 1;
            // 
            // lblFaultType
            // 
            this.lblFaultType.AutoSize = true;
            this.lblFaultType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFaultType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFaultType.Location = new System.Drawing.Point(15, 15);
            this.lblFaultType.Name = "lblFaultType";
            this.lblFaultType.Size = new System.Drawing.Size(150, 28);
            this.lblFaultType.TabIndex = 0;
            this.lblFaultType.Text = "⚙️  Arıza Türü";
            // 
            // cmbFaultType
            // 
            this.cmbFaultType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaultType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFaultType.FormattingEnabled = true;
            this.cmbFaultType.Items.AddRange(new object[] {
            "Tüm Arızalar",
            "Donanım Arızası",
            "Yazılım Arızası",
            "Bağlantı Sorunu",
            "Performans Sorunu",
            "Ekran Sorunu",
            "Ses Sorunu",
            "Diğer"});
            this.cmbFaultType.Location = new System.Drawing.Point(15, 40);
            this.cmbFaultType.Name = "cmbFaultType";
            this.cmbFaultType.Size = new System.Drawing.Size(200, 36);
            this.cmbFaultType.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(240, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 28);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "📊 Durum";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Tüm Durumlar",
            "Bakımda",
            "Bekleme",
            "Tamamlandı",
            "İptal Edildi"});
            this.cmbStatus.Location = new System.Drawing.Point(240, 40);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 36);
            this.cmbStatus.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFilter.IconColor = System.Drawing.Color.White;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 20;
            this.btnFilter.Location = new System.Drawing.Point(465, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(130, 38);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnClearFilter.IconColor = System.Drawing.Color.White;
            this.btnClearFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearFilter.IconSize = 20;
            this.btnClearFilter.Location = new System.Drawing.Point(610, 40);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(130, 38);
            this.btnClearFilter.TabIndex = 3;
            this.btnClearFilter.Text = "Filtre Kaldır";
            this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvFaults);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 180);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDataGrid.Size = new System.Drawing.Size(1400, 620);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dgvFaults
            // 
            this.dgvFaults.AllowUserToAddRows = false;
            this.dgvFaults.AllowUserToDeleteRows = false;
            this.dgvFaults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFaults.BackgroundColor = System.Drawing.Color.White;
            this.dgvFaults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFaults.ColumnHeadersHeight = 35;
            this.dgvFaults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFaults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaults.Location = new System.Drawing.Point(10, 10);
            this.dgvFaults.Name = "dgvFaults";
            this.dgvFaults.ReadOnly = true;
            this.dgvFaults.RowHeadersVisible = false;
            this.dgvFaults.RowHeadersWidth = 62;
            this.dgvFaults.RowTemplate.Height = 28;
            this.dgvFaults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaults.Size = new System.Drawing.Size(1380, 600);
            this.dgvFaults.TabIndex = 0;
            // 
            // Ariza_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Ariza_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arıza Takip - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Ariza_Panel_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnHome;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFaultType;
        private System.Windows.Forms.ComboBox cmbFaultType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private FontAwesome.Sharp.IconButton btnFilter;
        private FontAwesome.Sharp.IconButton btnClearFilter;

        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvFaults;
    }
}