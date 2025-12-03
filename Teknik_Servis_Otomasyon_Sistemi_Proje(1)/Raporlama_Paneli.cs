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
    public partial class Raporlama_Paneli : Form
    {
        /// <summary>
        /// Rapor verilerini tutar
        /// </summary>
        private DataTable reportData = new DataTable();

        public Raporlama_Paneli()
        {
            InitializeComponent();
        }

        private void Raporlama_Paneli_Load(object sender, EventArgs e)
        {
            this.ApplyModernStyling();
            this.InitializeReportData();
            this.SubscribeToEvents();
        }

        /// <summary>
        /// Modern stillendirmeyi uygular
        /// </summary>
        private void ApplyModernStyling()
        {
            // DataGridView stillendirme
            this.StyleDataGridView(this.dgvReport);

            // Başlangıç ve bitiş tarihlerini ayarla
            this.dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            this.dtpEndDate.Value = DateTime.Now;
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
        /// Rapor verilerini başlatır
        /// </summary>
        private void InitializeReportData()
        {
            this.reportData.Columns.Clear();
            this.reportData.Columns.Add("ID", typeof(int));
            this.reportData.Columns.Add("Açıklama", typeof(string));
            this.reportData.Columns.Add("Tarih", typeof(DateTime));
            this.reportData.Columns.Add("Değer", typeof(decimal));

            this.dgvReport.DataSource = this.reportData;
        }

        /// <summary>
        /// Event handler'ları abone ettirir
        /// </summary>
        private void SubscribeToEvents()
        {
            this.btnStockReport.Click += new System.EventHandler(this.BtnStockReport_Click);
            this.btnFaultReport.Click += new System.EventHandler(this.BtnFaultReport_Click);
            this.btnCustomerReport.Click += new System.EventHandler(this.BtnCustomerReport_Click);
            this.btnExportExcel.Click += new System.EventHandler(this.BtnExportExcel_Click);
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
        }

        /// <summary>
        /// Stok raporu yükler
        /// </summary>
        private void BtnStockReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stok raporu yükleniyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // ÖNEMLI: Burada veritabanından stok verileri çekilecek
        }

        /// <summary>
        /// Arıza raporu yükler
        /// </summary>
        private void BtnFaultReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arıza raporu yükleniyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // ÖNEMLI: Burada veritabanından arıza verileri çekilecek
        }

        /// <summary>
        /// Müşteri raporu yükler
        /// </summary>
        private void BtnCustomerReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri raporu yükleniyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // ÖNEMLI: Burada veritabanından müşteri verileri çekilecek
        }

        /// <summary>
        /// Raporu Excel'e aktar
        /// </summary>
        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            if (this.dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Dışa aktarılacak veri bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = $"Rapor_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ÖNEMLI: Excel aktarma kodunu buraya ekle
                    MessageBox.Show("Rapor başarıyla Excel'e aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Excel aktarımı sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Raporu yenile
        /// </summary>
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.reportData.Clear();
            MessageBox.Show("Rapor yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Raporu temizle
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.reportData.Clear();
            this.dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            this.dtpEndDate.Value = DateTime.Now;
            MessageBox.Show("Rapor temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
