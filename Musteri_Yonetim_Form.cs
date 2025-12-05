using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Musteri_Yonetim_Form : Form
    {
        // 1. GLOBAL BAĞLANTI
        // Veritabanı bağlantı adresimiz
        SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;");

        // Filtreleme yapabilmek için verileri hafızada tutacak tablo
        DataTable tablo = new DataTable();

        public Musteri_Yonetim_Form()
        {
            InitializeComponent();
        }

        private void Musteri_Yonetim_Form_Load(object sender, EventArgs e)
        {
            // !!! KRİTİK DÜZELTME: !!!
            // Burada daha önce 'this.musterilerTableAdapter.Fill...' satırı vardı.
            // O satır sistemi kilitliyordu. Onu sildik.
            // Artık sadece kendi yazdığımız temiz kodlar çalışacak.

            VerileriGetir();      // Verileri SQL'den çek
            TasarimiDuzenle();    // Tabloyu renklendir
            FiltreleriDoldur();   // Şehir ve Cihaz kutularını doldur
        }

        // --- SQL'DEN VERİLERİ ÇEKME METODU ---
        void VerileriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // Müşterileri ve getirdikleri cihaz türlerini çeken sorgu
                // VerileriGetir() içindeki string sorgu = ... kısmını bununla değiştir:
                string sorgu = @"
    SELECT DISTINCT
        m.Musteri_ID,
        m.Ad AS [Ad],
        m.Soyad AS [Soyad],
        m.Telefon_No AS [Telefon],
        m.Email AS [E-Mail],
        m.Il AS [Şehir],
        m.Ilce AS [İlçe],
        m.Acık_Adres AS [Adres],  
        a.Cihaz_Ad AS [Cihaz Türü]
    FROM Musteriler m
    LEFT JOIN Arizalar a ON m.Musteri_ID = a.Musteri_ID
    ORDER BY m.Ad ASC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                tablo.Clear();  // Eski verileri temizle
                da.Fill(tablo); // Yeni verileri doldur

                dgvCustomers.DataSource = tablo; // Grid'e bağla

                // ID sütununu gizle (Kullanıcı görmesin)
                if (dgvCustomers.Columns["Musteri_ID"] != null)
                    dgvCustomers.Columns["Musteri_ID"].Visible = false;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        // --- TABLO TASARIMI (GÖRSELLİK) ---
        void TasarimiDuzenle()
        {
            if (dgvCustomers.Rows.Count > 0 || dgvCustomers.Columns.Count > 0)
            {
                dgvCustomers.BorderStyle = BorderStyle.None;
                dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
                dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvCustomers.BackgroundColor = Color.White;

                dgvCustomers.EnableHeadersVisualStyles = false;
                dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
                dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCustomers.RowTemplate.Height = 30;
            }
        }

        // --- COMBOBOX DOLDURMA ---
        void FiltreleriDoldur()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // 1. ŞEHİRLERİ DOLDUR
                SqlCommand komutSehir = new SqlCommand("SELECT DISTINCT Il FROM Musteriler WHERE Il IS NOT NULL ORDER BY Il ASC", baglanti);
                SqlDataReader dr = komutSehir.ExecuteReader();

                cmbCity.Items.Clear();
                cmbCity.Items.Add("Tüm Şehirler");
                while (dr.Read()) cmbCity.Items.Add(dr["Il"].ToString());
                dr.Close();
                cmbCity.SelectedIndex = 0;

                // 2. CİHAZ TÜRLERİNİ DOLDUR
                SqlCommand komutCihaz = new SqlCommand("SELECT DISTINCT Cihaz_Ad FROM Arizalar WHERE Cihaz_Ad IS NOT NULL", baglanti);
                SqlDataReader drCihaz = komutCihaz.ExecuteReader();

                cmbDeviceType.Items.Clear();
                cmbDeviceType.Items.Add("Tüm Cihazlar");
                while (drCihaz.Read()) cmbDeviceType.Items.Add(drCihaz["Cihaz_Ad"].ToString());
                drCihaz.Close();
                cmbDeviceType.SelectedIndex = 0;

                baglanti.Close();
            }
            catch
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        // --- FİLTRELEME BUTONU ---
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string sehir = cmbCity.SelectedItem?.ToString();
            string cihaz = cmbDeviceType.SelectedItem?.ToString();
            string filtre = "";

            // Şehir Filtresi
            if (sehir != "Tüm Şehirler" && !string.IsNullOrEmpty(sehir))
            {
                filtre += string.Format("[Şehir] LIKE '%{0}%'", sehir);
            }

            // Cihaz Filtresi
            if (cihaz != "Tüm Cihazlar" && !string.IsNullOrEmpty(cihaz))
            {
                if (filtre.Length > 0) filtre += " AND "; // Önceki filtre varsa 'VE' ekle
                filtre += string.Format("[Cihaz Türü] LIKE '%{0}%'", cihaz);
            }

            // Filtreyi Uygula
            if (tablo.Rows.Count > 0)
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = filtre;
                dgvCustomers.DataSource = dv;
            }
        }

        // --- FİLTRE KALDIR BUTONU ---
        private void BtnClearFilter_Click(object sender, EventArgs e)
        {
            cmbCity.SelectedIndex = 0;
            cmbDeviceType.SelectedIndex = 0;

            if (tablo.Rows.Count > 0)
            {
                DataView dv = tablo.DefaultView;
                dv.RowFilter = ""; // Filtreyi temizle
                dgvCustomers.DataSource = dv;
            }
        }
    }
}
