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
    public partial class Ariza_Panel : Form
    {
        /// <summary>
        /// Orijinal arıza verilerini tutar
        /// </summary>
        private DataTable originalData = new DataTable();

        public Ariza_Panel()
        {
            InitializeComponent();
        }

        private void Ariza_Panel_Load(object sender, EventArgs e)
        {
            this.ApplyModernStyling();
            this.LoadFaultData();
            this.SubscribeToEvents();
        }

        /// <summary>
        /// Modern stillendirmeyi uygular
        /// </summary>
        private void ApplyModernStyling()
        {
            // DataGridView stillendirme
            this.StyleDataGridView(this.dgvFaults);
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
        /// Veritabanından arıza verilerini yükler
        /// </summary>
        private void LoadFaultData()
        {
            // ÖNEMLI: Burada veritabanından gerçek arıza verilerini çekmek gerekir
            // Örnek SQL: SELECT ID, MüşteriAd, CihazAd, ArızaTürü, Durum, GelişTarihi, ArızaDetay FROM Arızalar

            // Şimdilik örnek veriler:
            this.originalData.Columns.Clear();
            this.originalData.Columns.Add("ID", typeof(int));
            this.originalData.Columns.Add("MüşteriAd", typeof(string));
            this.originalData.Columns.Add("CihazAd", typeof(string));
            this.originalData.Columns.Add("ArızaTürü", typeof(string));
            this.originalData.Columns.Add("Durum", typeof(string));
            this.originalData.Columns.Add("GelişTarihi", typeof(DateTime));
            this.originalData.Columns.Add("ArızaDetay", typeof(string));

            // Örnek satırlar (gerçekte veritabanından gelecek)
            // this.originalData.Rows.Add(1, "Ahmet Kara", "Laptop", "Yazılım Arızası", "Bakımda", DateTime.Now, "İşletim sistemi kurulması gerekli");

            this.dgvFaults.DataSource = this.originalData;
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
        /// Seçilen arıza türü ve duruma göre filtre uygular
        /// </summary>
        private void ApplyFilters()
        {
            if (this.originalData.Rows.Count == 0)
            {
                MessageBox.Show("Gösterilecek veri bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string faultType = this.cmbFaultType.SelectedItem.ToString();
            string status = this.cmbStatus.SelectedItem.ToString();

            // DataView oluştur ve filtre uygula
            DataView dv = new DataView(this.originalData);
            string filter = "";

            // Arıza türü filtresi
            if (faultType != "Tüm Arızalar")
            {
                filter += $"ArızaTürü = '{faultType}'";
            }

            // Durum filtresi
            if (status != "Tüm Durumlar")
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"Durum = '{status}'";
            }

            // Filtreyi uygula
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }

            this.dgvFaults.DataSource = dv;

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
            this.cmbFaultType.SelectedIndex = 0;
            this.cmbStatus.SelectedIndex = 0;

            // DataGrid'i orijinal verilerle doldur
            this.dgvFaults.DataSource = this.originalData;

            MessageBox.Show("Filtreler kaldırıldı. Tüm arızalar gösteriliyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {

        }
    }
}
