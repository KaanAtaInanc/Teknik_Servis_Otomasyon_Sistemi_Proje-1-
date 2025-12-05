using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Stok_Takibi : Form
    {
        private DataTable stockData = new DataTable();
        private DataTable originalStockData = new DataTable();

        public Stok_Takibi()
        {
            InitializeComponent();
        }

        private void Stok_Takibi_Load(object sender, EventArgs e)
        {
            try
            {
                this.ApplyModernStyling();
                this.LoadStockData();
                this.SubscribeToEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyModernStyling()
        {
            if (this.tabControlMain != null)
            {
                this.tabControlMain.Appearance = TabAppearance.FlatButtons;
                this.tabControlMain.ItemSize = new Size(0, 40);
                this.tabControlMain.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }

            if (this.dgvStock != null)
            {
                this.StyleDataGridView(this.dgvStock);
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.GridColor = Color.FromArgb(189, 195, 199);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = false;
        }

        private void LoadStockData()
        {
            this.stockData.Columns.Clear();
            this.stockData.Columns.Add("ID", typeof(int));
            this.stockData.Columns.Add("Kategori", typeof(string));
            this.stockData.Columns.Add("ParcaAd", typeof(string));
            this.stockData.Columns.Add("Marka", typeof(string));
            this.stockData.Columns.Add("Miktar", typeof(int));
            this.stockData.Columns.Add("KritikSeviye", typeof(int));
            this.stockData.Columns.Add("BirimFiyati", typeof(decimal));

            this.originalStockData = this.stockData.Copy();

            if (this.dgvStock != null)
            {
                this.dgvStock.DataSource = this.stockData;
            }
        }

        private void SubscribeToEvents()
        {
            if (this.btnAdd != null) this.btnAdd.Click += BtnAdd_Click;
            if (this.btnEdit != null) this.btnEdit.Click += BtnEdit_Click;
            if (this.btnDelete != null) this.btnDelete.Click += BtnDelete_Click;
            if (this.btnClear != null) this.btnClear.Click += BtnClear_Click;
            if (this.txtSearch != null) this.txtSearch.TextChanged += TxtSearch_TextChanged;
            if (this.cmbFilterBy != null) this.cmbFilterBy.SelectedIndexChanged += CmbFilterBy_SelectedIndexChanged;
            if (this.btnSearchReset != null) this.btnSearchReset.Click += BtnSearchReset_Click;
            if (this.btnHome != null) this.btnHome.Click += BtnHome_Click;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.ApplySearchAndFilter();
        }

        private void CmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ApplySearchAndFilter();
        }

        private void ApplySearchAndFilter()
        {
            try
            {
                string searchText = this.txtSearch?.Text.ToLower() ?? "";
                string selectedCategory = this.cmbFilterBy?.SelectedItem?.ToString() ?? "Tüm Kategoriler";

                DataView dv = new DataView(this.originalStockData);
                string filter = "";

                if (!string.IsNullOrWhiteSpace(searchText) && searchText != "ara...")
                {
                    filter += $"(ParcaAd LIKE '%{searchText}%' OR Marka LIKE '%{searchText}%' OR Kategori LIKE '%{searchText}%')";
                }

                if (selectedCategory != "Tüm Kategoriler")
                {
                    if (!string.IsNullOrEmpty(filter))
                        filter += " AND ";
                    filter += $"Kategori = '{selectedCategory}'";
                }

                if (!string.IsNullOrEmpty(filter))
                    dv.RowFilter = filter;

                if (this.dgvStock != null)
                    this.dgvStock.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtreleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearchReset_Click(object sender, EventArgs e)
        {
            if (this.txtSearch != null) this.txtSearch.Text = "Ara...";
            if (this.cmbFilterBy != null) this.cmbFilterBy.SelectedIndex = 0;
            if (this.dgvStock != null) this.dgvStock.DataSource = this.originalStockData;

            MessageBox.Show("Tüm arama ve filtreler temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvStock.Columns["Miktar"] == null || this.dgvStock.Columns["KritikSeviye"] == null)
                    return;

                int miktarColIndex = this.dgvStock.Columns["Miktar"].Index;
                int kritikColIndex = this.dgvStock.Columns["KritikSeviye"].Index;

                if (e.RowIndex >= 0 && e.RowIndex < this.dgvStock.Rows.Count)
                {
                    DataGridViewRow row = this.dgvStock.Rows[e.RowIndex];

                    if (row.Cells[miktarColIndex].Value != null && row.Cells[kritikColIndex].Value != null)
                    {
                        if (int.TryParse(row.Cells[miktarColIndex].Value.ToString(), out int miktar) &&
                            int.TryParse(row.Cells[kritikColIndex].Value.ToString(), out int kritikSeviye))
                        {
                            if (miktar <= kritikSeviye)
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                                row.DefaultCellStyle.ForeColor = Color.FromArgb(139, 0, 0);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.White;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"CellFormatting hatası: {ex.Message}");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbCategory == null || this.cmbCategory.SelectedIndex <= 0)
                {
                    MessageBox.Show("Lütfen kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.txtPartName?.Text))
                {
                    MessageBox.Show("Parça adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(this.txtQuantity?.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Stok adedi geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(this.txtCriticalLevel?.Text, out int criticalLevel) || criticalLevel < 0)
                {
                    MessageBox.Show("Kritik seviye geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(this.txtPrice?.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Fiyat geçerli bir değer olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.stockData.Rows.Add(
                    this.stockData.Rows.Count + 1,
                    this.cmbCategory.SelectedItem.ToString(),
                    this.txtPartName.Text,
                    this.txtBrandModel?.Text ?? "",
                    quantity,
                    criticalLevel,
                    price
                );

                this.originalStockData = this.stockData.Copy();
                MessageBox.Show("Parça başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ekleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvStock?.SelectedRows.Count == 0)
            {
                MessageBox.Show("Düzenlemek için bir parça seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Düzenleme işlemi yapılacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvStock?.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Silmek için bir parça seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Seçili parçayı silmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.dgvStock.Rows.RemoveAt(this.dgvStock.SelectedRows[0].Index);
                    this.originalStockData = this.stockData.Copy();
                    MessageBox.Show("Parça başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            if (this.cmbCategory != null) this.cmbCategory.SelectedIndex = 0;
            if (this.txtPartName != null) this.txtPartName.Clear();
            if (this.txtBrandModel != null) this.txtBrandModel.Clear();
            if (this.txtQuantity != null) this.txtQuantity.Clear();
            if (this.txtCriticalLevel != null) this.txtCriticalLevel.Text = "10";
            if (this.txtPrice != null) this.txtPrice.Clear();
        }
    }
}
