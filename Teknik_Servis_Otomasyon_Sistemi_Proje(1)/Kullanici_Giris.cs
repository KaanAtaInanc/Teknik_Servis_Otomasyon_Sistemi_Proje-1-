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
    public partial class Kullanici_Giris : Form
    {
        public Kullanici_Giris()
        {
            InitializeComponent();
        }

        private void Kullanici_Giris_Load(object sender, EventArgs e)
        {
            this.ApplyModernStyling();
            this.SubscribeToEvents();
        }

        /// <summary>
        /// Modern stillendirmeyi uygular
        /// </summary>
        private void ApplyModernStyling()
        {
            // TextBox stillendirmesi
            this.StyleTextBox(this.txtUsername);
            this.StyleTextBox(this.txtPassword);

            // Form merkezde konumlandır
            this.CenterToScreen();
        }

        /// <summary>
        /// TextBox'ı stillendirir
        /// </summary>
        private void StyleTextBox(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.White;
            txt.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Event handler'ları abone ettirir
        /// </summary>
        private void SubscribeToEvents()
        {
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            this.lnkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkForgotPassword_LinkClicked);
        }

        /// <summary>
        /// Giriş Yap butonu
        /// </summary>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Lütfen şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPassword.Focus();
                return;
            }

            // ÖNEMLI: Burada veritabanı doğrulaması yapılacak
            // Örnek: if (AuthenticateUser(this.txtUsername.Text, this.txtPassword.Text))

            MessageBox.Show($"Hoşgeldiniz {this.txtUsername.Text}!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ÖNEMLI: Başarılı giriş sonrası ana paneli aç
            // Ana_Panel mainForm = new Ana_Panel();
            // mainForm.Show();
            // this.Hide();
        }

        /// <summary>
        /// Temizle butonu
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            //this.chkRememberMe.Checked = false;
            this.txtUsername.Focus();
        }

        /// <summary>
        /// Şifremi Unuttum linki
        /// </summary>
        private void LnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şifre sıfırlama sayfasına yönlendirileceksiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ÖNEMLI: Şifre sıfırlama formunu aç
            // Sifre_Sifirla_Panel resetForm = new Sifre_Sifirla_Panel();
            // resetForm.ShowDialog();
        }

        /// <summary>
        /// Form tasarımını çizme işlemi
        /// </summary>
        private void PnlForm_Paint(object sender, PaintEventArgs e)
        {
            // Hafif gölge efekti
            using (Pen pen = new Pen(System.Drawing.Color.FromArgb(200, 200, 200), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.pnlForm.Width - 1, this.pnlForm.Height - 1);
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
