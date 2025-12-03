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
    public partial class Stok_Yonetimi_Paneli : Form
    {
        /// <summary>
        /// Stok verilerini tutar
        /// </summary>
        private DataTable stockData = new DataTable();

        public Stok_Yonetimi_Paneli()
        {
            InitializeComponent();
        }

        private void Stok_Yonetimi_Paneli_Load(object sender, EventArgs e)
        {
            this.ApplyModernStyling();
            this.LoadStockData();
            this.SubscribeToEvents();
        }

        /// <summary>
        /// Modern stillendirmeyi uygular
        /// </summary>
        private void ApplyModernStyling()
        {
            // TabControl özelleştirme
            this.tabControlMain.Appearance = TabAppearance.FlatButtons;
            this.tabControlMain.ItemSize = new System.Drawing.Size(0, 40);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // DataGridView stillendirme
            this.StyleDataGridView(this.dgvStock);
        }

        /// <summary>
        /// DataGridView'ı stillendirir
        /// </summary>
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.GridColor = System.Drawing.Color.FromArgb(189, 195, 199);
        }

        /// <summary>
        /// Stok verilerini yükler
        /// </summary>
        private void LoadStockData()
        {
            // ÖNEMLI: Burada veritabanından gerçek stok verilerini çekmek gerekir
            // Örnek SQL: SELECT ID, ParcaAd, Marka, Miktar, KritikSeviye, BirimFiyati FROM Stok

            this.stockData.Columns.Clear();
            this.stockData.Columns.Add("ID", typeof(int));
            this.stockData.Columns.Add("ParcaAd", typeof(string));
            this.stockData.Columns.Add("Marka", typeof(string));
            this.stockData.Columns.Add("Miktar", typeof(int));
            this.stockData.Columns.Add("KritikSeviye", typeof(int));
            this.stockData.Columns.Add("BirimFiyati", typeof(decimal));

            this.dgvStock.DataSource = this.stockData;
        }

        /// <summary>
        /// Event handler'ları abone ettirir
        /// </summary>
        private void SubscribeToEvents()
        {
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
        }

        /// <summary>
        /// Parça ekleme işlemi
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPartName.Text))
            {
                MessageBox.Show("Parça adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(this.txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Stok adedi geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(this.txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Fiyat geçerli bir değer olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ÖNEMLI: Burada veritabanına veri eklemek gerekir
            // INSERT INTO Stok (ParcaAd, Marka, Miktar, KritikSeviye, BirimFiyati) VALUES (...)

            this.stockData.Rows.Add(
                this.stockData.Rows.Count + 1,
                this.txtPartName.Text,
                this.txtBrandModel.Text,
                quantity,
                int.Parse(this.txtCriticalLevel.Text ?? "10"),
                price
            );

            MessageBox.Show("Parça başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ClearForm();
        }

        /// <summary>
        /// Parça düzenleme işlemi
        /// </summary>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Düzenlemek için bir parça seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Düzenleme işlemi yapılacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Düzenleme mantığı burada uygulanacak
        }

        /// <summary>
        /// Parça silme işlemi
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silmek için bir parça seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Seçili parçayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.dgvStock.Rows.RemoveAt(this.dgvStock.SelectedRows[0].Index);
                MessageBox.Show("Parça başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Formu temizleme işlemi
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        /// <summary>
        /// Form alanlarını temizler
        /// </summary>
        private void ClearForm()
        {
            this.txtPartName.Clear();
            this.txtBrandModel.Clear();
            this.txtQuantity.Clear();
            this.txtCriticalLevel.Text = "10";
            this.txtPrice.Clear();
        }
    }
}
