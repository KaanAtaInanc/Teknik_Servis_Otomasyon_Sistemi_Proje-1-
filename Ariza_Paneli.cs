using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Ariza_Paneli : Form
    {
        // 1. GLOBAL BAĞLANTI AYARLARI
        // Veritabanı bağlantısı ve verileri hafızada tutmak için tablo oluşturuyoruz
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=Teknik_Servis_DB;Integrated Security=True");
        DataTable tablo = new DataTable(); 

        public Ariza_Paneli()
        {
            InitializeComponent();
        }

        // --- FORM YÜKLENİRKEN ---
        private void Ariza_Paneli_Load(object sender, EventArgs e)
        {
            VerileriGetir();      // 1. SQL'den verileri çek
            TasarimiDuzenle();    // 2. Tabloyu renklendir
            ComboBoxlariDoldur(); // 3. Filtre kutularını doldur
        }

        // --- SQL'DEN VERİLERİ ÇEKME METODU ---
        void VerileriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // ID yerine İSİM getiren ve tablolari birleştiren (JOIN) SQL Sorgusu
                string sorgu = @"
                    SELECT 
                        a.Ariza_ID,
                        (m.Ad + ' ' + m.Soyad) AS [Müşteri],
                        a.Cihaz_Ad AS [Cihaz],
                        a.Cihaz_Marka_Model AS [Model],
                        a.Seri_No AS [Seri No],
                        d.Durum_Ad AS [Durum],
                        (p.Ad + ' ' + p.Soyad) AS [Teknisyen],
                        a.Gelis_Tarihi AS [Geliş Tarihi],
                        a.Atama_Tarihi AS [Atama Tarihi],
                        a.Bitis_Tarihi AS [Bitiş Tarihi],
                        a.Musteri_Sikayet AS [Şikayet]
                    FROM Arizalar a
                    INNER JOIN Musteriler m ON a.Musteri_ID = m.Musteri_ID
                    LEFT JOIN Personeller p ON a.Teknisyen_ID = p.Personel_ID
                    INNER JOIN Ariza_Durumlari d ON a.Durum_ID = d.Durum_ID
                    ORDER BY a.Gelis_Tarihi DESC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                
                tablo.Clear();  // Önceki verileri temizle
                da.Fill(tablo); // Yeni verileri doldur

                // Grid'e kaynağı bağla
                dgv_Ariza_Kayit.DataSource = tablo;

                // ID sütununu gizle (Kullanıcı görmesin)
                if (dgv_Ariza_Kayit.Columns["Ariza_ID"] != null)
                    dgv_Ariza_Kayit.Columns["Ariza_ID"].Visible = false;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Çekme Hatası: " + ex.Message);
            }
        }

        // --- TASARIM GÜZELLEŞTİRME ---
        void TasarimiDuzenle()
        {
            // Eğer tablo boş değilse stillendirme yap
            if (dgv_Ariza_Kayit.Rows.Count > 0 || dgv_Ariza_Kayit.Columns.Count > 0)
            {
                dgv_Ariza_Kayit.BorderStyle = BorderStyle.None;
                dgv_Ariza_Kayit.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dgv_Ariza_Kayit.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv_Ariza_Kayit.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
                dgv_Ariza_Kayit.DefaultCellStyle.SelectionForeColor = Color.White;
                dgv_Ariza_Kayit.BackgroundColor = Color.White;

                dgv_Ariza_Kayit.EnableHeadersVisualStyles = false;
                dgv_Ariza_Kayit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv_Ariza_Kayit.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
                dgv_Ariza_Kayit.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                
                dgv_Ariza_Kayit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_Ariza_Kayit.RowTemplate.Height = 30;
            }
        }

        // --- FİLTRE KUTULARINI DOLDURMA ---
        void ComboBoxlariDoldur()
        {
            // Durum Filtresi (CMB_Durum)
            CMB_Durum.Items.Clear();
            CMB_Durum.Items.Add("Tüm Durumlar");
            CMB_Durum.Items.Add("Bekliyor");
            CMB_Durum.Items.Add("İnceleniyor");
            CMB_Durum.Items.Add("Parça Bekleniyor");
            CMB_Durum.Items.Add("Tamamlandı");
            CMB_Durum.Items.Add("İptal");
            CMB_Durum.SelectedIndex = 0;

            // Arıza Türü (CMB_Ariza_Türü) 
            // Not: Veritabanında Arıza Türü kolonu yoksa burası sadece görsel kalır.
            CMB_Ariza_Türü.Items.Clear();
            CMB_Ariza_Türü.Items.Add("Tüm Arızalar");
            CMB_Ariza_Türü.Items.Add("Donanım");
            CMB_Ariza_Türü.Items.Add("Yazılım");
            CMB_Ariza_Türü.SelectedIndex = 0;
        }

        // --- FİLTRELEME BUTONU (BTN_Filter) ---
        private void BTN_Filter_Click(object sender, EventArgs e)
        {
            string durumSecimi = CMB_Durum.SelectedItem?.ToString();
            string filtre = "";

            // "Tüm Durumlar" seçili değilse filtre uygula
            if (durumSecimi != "Tüm Durumlar" && !string.IsNullOrEmpty(durumSecimi))
            {
                // [Durum] sütunu SQL sorgusunda belirlediğimiz isimdir
                filtre = string.Format("[Durum] LIKE '%{0}%'", durumSecimi);
            }

            // Hafızadaki tabloya filtreyi uygula
            if (tablo.Rows.Count > 0)
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = filtre;
                dgv_Ariza_Kayit.DataSource = dv;
            }
        }

        // --- FİLTRE KALDIR BUTONU (BTN_Filtre_Kaldır) ---
        private void BTN_Filtre_Kaldır_Click(object sender, EventArgs e)
        {
            // Seçimleri başa döndür
            CMB_Durum.SelectedIndex = 0;
            CMB_Ariza_Türü.SelectedIndex = 0;

            // Filtreyi temizle ve tüm veriyi göster
            if (tablo.Rows.Count > 0)
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = ""; 
                dgv_Ariza_Kayit.DataSource = dv;
            }
        }

        private void Ariza_Paneli_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'teknik_Servis_DBDataSet.Arizalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arizalarTableAdapter.Fill(this.teknik_Servis_DBDataSet.Arizalar);

        }
    }
}