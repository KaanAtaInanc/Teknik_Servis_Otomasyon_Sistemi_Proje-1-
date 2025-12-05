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
    public partial class Danisma_Panel : Form
    {
        public Danisma_Panel()
        {
            InitializeComponent();
        }

        private void Danisma_Panel_Load(object sender, EventArgs e)
        {

        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Sistem_Kapat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Sistemden çıkmak istediğinize emin misiniz?\n\nHerhangi bir kaydedilmemiş veri kaybolabilir.",
              "⚠️  Sistemi Kapat",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //this.timerDateTime.Stop();
                Application.Exit();
            }
        }

        private void BTN_Oturum_Kapat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Oturumu kapatmak istediğinize emin misiniz?",
              "⚠️  Oturumu Kapat",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //this.timerDateTime.Stop();
                this.Hide();
                Kullanici_Giris loginForm = new Kullanici_Giris();
                loginForm.Show();
            }
        }
    }
}
