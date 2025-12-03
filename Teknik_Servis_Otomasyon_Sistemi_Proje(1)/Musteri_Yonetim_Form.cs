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
    public partial class Musteri_Yonetim_Form : Form
    {
        /// <summary>
        /// Orijinal müşteri verilerini tutar
        /// </summary>
        private DataTable originalData = new DataTable();

        public Musteri_Yonetim_Form()
        {
            InitializeComponent();
        }

        private void Musteri_Yonetim_Form_Load(object sender, EventArgs e)
        {
            this.ApplyModernStyling();
            this.LoadCustomerData();
            this.SubscribeToEvents();
        }

        /// <summary>
        /// Modern stillendirmeyi uygular
        /// </summary>
        private void ApplyModernStyling()
        {
            // DataGridView stillendirme
            this.StyleDataGridView(this.dgvCustomers);
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
        /// Veritabanından müşteri verilerini yükler
        /// </summary>
        private void LoadCustomerData()
        {
            // ÖNEMLI: Burada veritabanından gerçek müşteri verilerini çekmek gerekir
            // Örnek SQL: SELECT ID, Ad, Soyad, Telefon, Email, Şehir, Adres, CihazTürü, KayıtTarihi FROM Müşteriler

            // Şimdilik örnek veriler:
            this.originalData.Columns.Clear();
            this.originalData.Columns.Add("ID", typeof(int));
            this.originalData.Columns.Add("Ad", typeof(string));
            this.originalData.Columns.Add("Soyad", typeof(string));
            this.originalData.Columns.Add("Telefon", typeof(string));
            this.originalData.Columns.Add("Email", typeof(string));
            this.originalData.Columns.Add("Şehir", typeof(string));
            this.originalData.Columns.Add("Adres", typeof(string));
            this.originalData.Columns.Add("CihazTürü", typeof(string));
            this.originalData.Columns.Add("KayıtTarihi", typeof(DateTime));

            // Örnek satır ekle (gerçekte veritabanından gelecek)
            // this.originalData.Rows.Add(1, "Ahmet", "Kara", "0535123456", "ahmet@email.com", "İstanbul", "Kadıköy", "Laptop", DateTime.Now);

            this.dgvCustomers.DataSource = this.originalData;
        }

        /// <summary>
        /// Event handler'ları abone ettirir
        /// </summary>
        private void SubscribeToEvents()
        {
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            this.btnClearFilter.Click += new System.EventHandler(this.BtnClearFilter_Click);
        }

        /// <summary>
        /// Filtrele butonu click event'i
        /// </summary>
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            this.ApplyFilters();
        }

        /// <summary>
        /// Seçilen şehir ve cihaz türüne göre filtre uygular
        /// </summary>
        private void ApplyFilters()
        {
            if (this.originalData.Rows.Count == 0)
            {
                MessageBox.Show("Gösterilecek veri bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string city = this.cmbCity.SelectedItem.ToString();
            string deviceType = this.cmbDeviceType.SelectedItem.ToString();

            // DataView oluştur ve filtre uygula
            DataView dv = new DataView(this.originalData);
            string filter = "";

            // Şehir filtresi
            if (city != "Tüm Şehirler")
            {
                filter += $"Şehir = '{city}'";
            }

            // Cihaz türü filtresi
            if (deviceType != "Tüm Cihazlar")
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"CihazTürü = '{deviceType}'";
            }

            // Filtreyi uygula
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }

            this.dgvCustomers.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Filtreleme kriterlerine uygun veri bulunamadı.", "Sonuç Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Filtre Kaldır butonu click event'i
        /// </summary>
        private void BtnClearFilter_Click(object sender, EventArgs e)
        {
            // ComboBox'ları sıfırla
            this.cmbCity.SelectedIndex = 0;
            this.cmbDeviceType.SelectedIndex = 0;

            // DataGrid'i orijinal verilerle doldur
            this.dgvCustomers.DataSource = this.originalData;

            MessageBox.Show("Filtreler kaldırıldı. Tüm müşteriler gösteriliyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
