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
    public partial class Sifre_Sifirla : Form
    {
        /// <summary>
        /// Doğrulama için geçerli Captcha kodu
        /// </summary>
        private string validCaptchaCode;

        public Sifre_Sifirla()
        {
            InitializeComponent();
        }

        private void Sifre_Sifirla_Load(object sender, EventArgs e)
        {
            this.GenerateCaptcha();
            this.SubscribeToEvents();
        }

        /// <summary>
        /// Yeni Captcha kodu oluşturur
        /// </summary>
        private void GenerateCaptcha()
        {
            // Rastgele 8 karakterlik kod oluştur
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            this.validCaptchaCode = "";

            for (int i = 0; i < 8; i++)
            {
                this.validCaptchaCode += chars[random.Next(chars.Length)];
            }

            this.lblCaptchaImage.Text = this.validCaptchaCode;
        }

        /// <summary>
        /// Event handler'ları abone ettirir
        /// </summary>
        private void SubscribeToEvents()
        {
            this.btnRefreshCaptcha.Click += new System.EventHandler(this.BtnRefreshCaptcha_Click);
            this.btnResetPassword.Click += new System.EventHandler(this.BtnResetPassword_Click);
            this.btnBackToLogin.Click += new System.EventHandler(this.BtnBackToLogin_Click);
        }

        /// <summary>
        /// Captcha Yenile
        /// </summary>
        private void BtnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            this.GenerateCaptcha();
        }

        /// <summary>
        /// Şifre Sıfırla
        /// </summary>
        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            // Doğrulamalar
            if (string.IsNullOrWhiteSpace(this.txtNewPassword.Text))
            {
                MessageBox.Show("Lütfen yeni şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtConfirmPassword.Text))
            {
                MessageBox.Show("Lütfen şifreyi onaylayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtConfirmPassword.Focus();
                return;
            }

            if (this.txtNewPassword.Text != this.txtConfirmPassword.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNewPassword.Clear();
                this.txtConfirmPassword.Clear();
                return;
            }

            if (this.txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtCaptchaCode.Text))
            {
                MessageBox.Show("Lütfen Captcha kodunu giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCaptchaCode.Focus();
                return;
            }

            if (this.txtCaptchaCode.Text.ToUpper() != this.validCaptchaCode)
            {
                MessageBox.Show("Captcha kodu hatalı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCaptchaCode.Clear();
                this.GenerateCaptcha();
                return;
            }

            // ÖNEMLI: Burada veritabanında şifre güncellemesi yapılacak
            // UPDATE Kullanicilar SET Sifre = '@NewPassword' WHERE Username = '@Username'

            MessageBox.Show("Şifreniz başarıyla sıfırlanmıştır. Lütfen yeni şifrenizle giriş yapınız.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            Kullanici_Giris loginForm = new Kullanici_Giris();
            loginForm.Show();
        }

        /// <summary>
        /// Giriş Ekranına Dön
        /// </summary>
        private void BtnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Kullanici_Giris loginForm = new Kullanici_Giris();
            loginForm.Show();
        }

        /// <summary>
        /// Form tasarımını çizme
        /// </summary>
        private void PnlForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(200, 200, 200), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.pnlForm.Width - 1, this.pnlForm.Height - 1);
            }
        }
    }
}
