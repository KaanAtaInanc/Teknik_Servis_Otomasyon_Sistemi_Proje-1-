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
        private int currentTechnicianId = 0;
        private string currentTechnicianName = "";

        // Örnek parça deposu (gerçekte veritabanından gelecek)
        private Dictionary<string, List<(string partName, int stock)>> partsByCategory =
            new Dictionary<string, List<(string, int)>>
            {
                    { "Tümü", new List<(string, int)>
                        { ("SSD 240GB", 15), ("RAM 8GB", 22), ("Ekran 15.6\"", 8), ("Pil", 45),
                          ("Konnektör USB", 120), ("Şarj Aleti 65W", 12), ("Kasa Plastik", 30) } },
                    { "Ekran", new List<(string, int)> { ("Ekran 15.6\" FHD", 8), ("Ekran 13.3\" HD", 5) } },
                    { "Batarya", new List<(string, int)> { ("Pil Standart", 45), ("Pil Extended", 18) } },
                    { "Kasa", new List<(string, int)> { ("Kasa Plastik", 30), ("Kasa Metal", 12) } },
                    { "Bellek", new List<(string, int)> { ("RAM 8GB DDR4", 22), ("RAM 16GB DDR4", 10) } },
                    { "Depolama", new List<(string, int)> { ("SSD 240GB", 15), ("SSD 512GB", 8), ("HDD 1TB", 5) } },
                    { "Konnektör", new List<(string, int)> { ("Konnektör USB", 120), ("HDMI Adaptör", 45) } },
                    { "Şarj Aleti", new List<(string, int)> { ("Şarj Aleti 65W", 12), ("Şarj Aleti 100W", 7) } },
                    { "Başka", new List<(string, int)> { ("Termal Macun", 35), ("Sistem Fanı", 14) } }
            };

        public Atanan_Islemler()
        {
            InitializeComponent();
        }

        public Atanan_Islemler(int technicianId, string technicianName)
        {
            InitializeComponent();
            this.currentTechnicianId = technicianId;
            this.currentTechnicianName = technicianName;
        }

        private void Atanan_Islemler_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTechnicianInfo();
                InitializeStatusCombo();
                LoadPartsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Teknisyen bilgisini başlık olarak gösterir
        /// </summary>
        private void LoadTechnicianInfo()
        {
            if (string.IsNullOrEmpty(currentTechnicianName))
                currentTechnicianName = "Teknisyen";

            lblTechnicianInfo.Text = $"👤 Teknisyen: {currentTechnicianName}";
        }

        /// <summary>
        /// İş durumu combobox'ını doldurur
        /// </summary>
        private void InitializeStatusCombo()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] {
                    "Bakımda",
                    "Beklemede",
                    "Tamamlanan Parça Bekleniyor",
                    "Tamamlandı",
                    "İptal Edildi"
                });
            cmbStatus.SelectedIndex = 0;
        }

        /// <summary>
        /// Parça kategorilerini ve arama seçeneklerini yükler
        /// </summary>
        private void LoadPartsData()
        {
            cmbPartCategory.SelectedIndex = 0;
            RefreshPartsList();
        }

        /// <summary>
        /// Seçilen kategoriye göre parça listesini günceller
        /// </summary>
        private void CmbPartCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPartsList();
        }

        /// <summary>
        /// Arama metnine göre parça listesini filtreler
        /// </summary>
        private void TxtPartSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshPartsList();
        }

        /// <summary>
        /// Parça listesini kategori ve arama kriterlerine göre yeniler
        /// </summary>
        private void RefreshPartsList()
        {
            try
            {
                string selectedCategory = cmbPartCategory.SelectedItem?.ToString() ?? "Tümü";
                string searchText = txtPartSearch.Text.ToLower();

                cmbUsedParts.Items.Clear();
                cmbUsedParts.Items.Add("Parça Seçiniz...");

                if (partsByCategory.ContainsKey(selectedCategory))
                {
                    var parts = partsByCategory[selectedCategory];

                    foreach (var (partName, stock) in parts)
                    {
                        if (partName.ToLower().Contains(searchText))
                        {
                            cmbUsedParts.Items.Add($"{partName} (Stok: {stock})");
                        }
                    }
                }

                if (cmbUsedParts.Items.Count > 1)
                    cmbUsedParts.SelectedIndex = 0;
                else
                    lblStockValue.Text = "0 Adet";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtre hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Seçilen parçanın stok bilgisini gösterir
        /// </summary>
        private void CmbUsedParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cmbUsedParts.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedItem) || selectedItem == "Parça Seçiniz...")
                {
                    lblStockValue.Text = "0 Adet";
                    lblStockValue.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
                    return;
                }

                // Stok miktarını çıkar: "Parça Adı (Stok: X)" formatından
                int stockStart = selectedItem.LastIndexOf("(Stok: ");
                if (stockStart > -1)
                {
                    int stockEnd = selectedItem.LastIndexOf(")");
                    string stockStr = selectedItem.Substring(stockStart + 7, stockEnd - stockStart - 7);

                    if (int.TryParse(stockStr, out int stock))
                    {
                        // Stok seviyesine göre renk değişikliği
                        if (stock <= 5)
                        {
                            lblStockValue.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60); // Kırmızı
                            lblStockValue.Text = $"⚠️ {stock} Adet (Düşük Stok!)";
                        }
                        else if (stock <= 15)
                        {
                            lblStockValue.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15); // Sarı
                            lblStockValue.Text = $"⚡ {stock} Adet (Uyarı)";
                        }
                        else
                        {
                            lblStockValue.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113); // Yeşil
                            lblStockValue.Text = $"✅ {stock} Adet (Yeterli)";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Parça seçim hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
