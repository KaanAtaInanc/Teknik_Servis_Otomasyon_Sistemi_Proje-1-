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
    public partial class Atanan_Islemler : Form
    {
        /// <summary>
        /// Mevcut teknisyenin ID'si - oturum açan kişiyi temsil eder
        /// </summary>
        private int currentTechnicianId = 0;
        private string currentTechnicianName = "";

        public Atanan_Islemler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor - Teknisyen bilgisini parametreden al
        /// </summary>
        public Atanan_Islemler(int technicianId, string technicianName)
        {
            InitializeComponent();
            this.currentTechnicianId = technicianId;
            this.currentTechnicianName = technicianName;
        }

        private void Atanan_Islemler_Load(object sender, EventArgs e)
        {
            this.ApplyModernStyling();
            this.LoadTechnicianInfo();
            this.LoadUserSpecificTasks();
            this.InitializeControls();
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
            this.StyleDataGridView(this.dgvMyTasks);
            this.StyleDataGridView(this.dgvCompletedTasks);
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
        /// Teknisyen bilgisini header'da gösterir
        /// </summary>
        private void LoadTechnicianInfo()
        {
            // ÖNEMLI: Burada gerçek veritabanından teknisyen bilgisini çekmek gerekir
            if (string.IsNullOrEmpty(this.currentTechnicianName))
            {
                this.currentTechnicianName = "Teknisyen";
            }

            this.lblTechnicianInfo.Text = $"👤 Teknisyen: {this.currentTechnicianName}";
        }

        /// <summary>
        /// Sadece oturum açan teknisyene atanan işleri yükler
        /// </summary>
        private void LoadUserSpecificTasks()
        {
            // ÖNEMLI: Burada veritabanından SADECE currentTechnicianId'ye ait işler çekilecek
            // Örnek SQL: SELECT * FROM Atanan_Isler WHERE TechnicianId = @TechnicianId AND Status != 'Tamamlandı'

            // Şimdilik örnek veriler:
            this.dgvMyTasks.DataSource = null;
            this.dgvMyTasks.Columns.Clear();

            // Sütunları ekle
            this.dgvMyTasks.Columns.Add("ID", "İş ID");
            this.dgvMyTasks.Columns.Add("CustomerName", "Müşteri Adı");
            this.dgvMyTasks.Columns.Add("DeviceName", "Cihaz");
            this.dgvMyTasks.Columns.Add("Status", "Durum");
            this.dgvMyTasks.Columns.Add("AssignedDate", "Atanan Tarih");

            // Burada veritabanı sorgusu yapılacak
            // Yalnızca currentTechnicianId'ye ait işler gösterilecek
        }

        /// <summary>
        /// Durumu ve kullanılan parçaları başlatır
        /// </summary>
        private void InitializeControls()
        {
            // İş Durumu ComboBox'ını doldur
            this.cmbStatus.Items.AddRange(new object[] {
                    "Bakımda",
                    "Beklemede",
                    "Tamamlanan Parça Bekleniyor",
                    "Tamamlandı",
                    "İptal Edildi"
                });
            this.cmbStatus.SelectedIndex = 0;

            // Kullanılan Parçalar ComboBox'ını doldur
            // ÖNEMLI: Burada veritabanından stok parçaları çekmek gerekir
            this.cmbUsedParts.Items.AddRange(new object[] {
                    "Parça Seçiniz",
                    "SSD 240GB",
                    "RAM 8GB",
                    "Ekran 15.6\"",
                    "Pil"
                });
            this.cmbUsedParts.SelectedIndex = 0;
        }
    }
}
