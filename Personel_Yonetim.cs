using MetroFramework.Forms;
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
    public partial class Personel_Yonetim : Form
    {
        public Personel_Yonetim()
        {
            InitializeComponent();
        }

        private void Personel_Yonetim_Load(object sender, EventArgs e)
        {
            this.ApplyModernStyling();
            this.LoadInitialData();
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
            this.StyleDataGridView(this.dgvStaffList);
            this.StyleDataGridView(this.dgvPerformanceList);
            this.StyleDataGridView(this.dgvIssueTypes);
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
        /// İlk verileri yükler
        /// </summary>
        private void LoadInitialData()
        {
            // Başlangıç veri yükleme
            // Veritabanından veri çekme işlemleri burada yapılacak
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
