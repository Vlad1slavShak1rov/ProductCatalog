using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCatalog
{
    public partial class EnterToProgramm : Form
    {
        public EnterToProgramm()
        {
            InitializeComponent();
            passBox.PasswordChar = '*';
            label5.Hide();
            label6.Hide();
        }

        private void EnterPress(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(passBox.Text) && !string.IsNullOrWhiteSpace(loginBox.Text)
                && loginBox.Text.Length >= 4 && passBox.Text.Length >= 5)
            {
                using var db = new ProductDataBase();
                bool pass = db.users.Any(u => u.Password == passBox.Text);
                bool login = db.users.Any(u => u.Login == loginBox.Text);
                if (pass && login)
                {
                    this.Hide();
                    (new Form1(loginBox.Text)).ShowDialog();
                }
                else MessageBox.Show("Неправильно введен пароль и/или логин", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(passBox.Text) && string.IsNullOrWhiteSpace(loginBox.Text))
                    MessageBox.Show("У вас есть незаполненные поля!", "Внимание!", MessageBoxButtons.OK);
                else if (loginBox.Text.Length < 3 || passBox.Text.Length < 4)
                    MessageBox.Show("Ваш пароль и / или логн не соответствуют критериям", "Внимание!", MessageBoxButtons.OK);

            }
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            this.Hide();
            (new RegWindow()).ShowDialog();
        }

        private void HideShowPass(object sender, EventArgs e)
        {
            passBox.PasswordChar = CheckPass.Checked ? '\0' : '*';
        }

        private void CheckLoginBox(object sender, EventArgs e)
        {

            if (loginBox.Text != null)
            {
                if (string.IsNullOrWhiteSpace(loginBox.Text) || loginBox.Text.Length < 4)
                {
                    label5.Text = "Логин должен быть \nсостоять хотя бы из 4 символов";
                    label5.ForeColor = Color.Red;
                    label5.Show();
                }
                else
                {
                    label5.Hide();
                }
            }
        }

        private void CheckBoxPass(object sender, EventArgs e)
        {
            if (passBox.Text != null)
            {
                if (string.IsNullOrWhiteSpace(passBox.Text) || passBox.Text.Length < 5)
                {
                    label6.Text = "Пароль должен \nсостоять хотя бы из 5 символов";
                    label6.ForeColor = Color.Red;
                    label6.Show();
                }
                else
                {
                    label6.Hide();
                }
            }
        }
    }
}
