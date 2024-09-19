using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProductCatalog
{
    public partial class RegWindow : Form
    {

        public RegWindow()
        {
            InitializeComponent();
            PassBoxOne.PasswordChar = PassBoxTwo.PasswordChar = '*';
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }

        private void HideShow(object sender, EventArgs e)
        {
            PassBoxOne.PasswordChar = CheckPass.Checked ? '\0' : '*';
            PassBoxTwo.PasswordChar = CheckPass.Checked ? '\0' : '*';
        }

        private void SignUp(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PassBoxOne.Text) && !string.IsNullOrWhiteSpace(PassBoxTwo.Text))
                EnterToApp();

            else
                MessageBox.Show("У вас есть незаполненные поля!", "Внимание!", MessageBoxButtons.OK);
        }

        private void CompareText()
        {
            string text1 = PassBoxOne.Text;
            string text2 = PassBoxTwo.Text;
            bool isEqual = string.Equals(text1, text2, StringComparison.OrdinalIgnoreCase);

            if (!isEqual)
            {
                label5.Text = "Пароли не совпадают!";
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.Text = "Пароли совпадают!";
                label5.ForeColor = Color.Green;
            }
        }

        private void Check(object sender, EventArgs e)
        {
            CompareText();
        }

        private void EnterToApp()
        {
            if (PassBoxOne.Text.Length >= 5 && textBox1.Text.Length >= 4)
            {
                using var db = new ProductDataBase();

                bool userExists = db.users.Any(u => u.Login == textBox1.Text);
                if (userExists)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует. Пожалуйста, выберите другой логин или войдите под сущетсвующим логином");
                    label6.Show();
                    return;
                }
                db.Add(new User { Login = textBox1.Text, Password = PassBoxOne.Text });
                db.SaveChanges();
                this.Hide();
                (new Form1(textBox1.Text)).ShowDialog();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            (new EnterToProgramm()).Show();
        }

        private void CheckPassBox(object sender, EventArgs e)
        {
            if (PassBoxOne.Text != null)
            {
                if (string.IsNullOrWhiteSpace(PassBoxOne.Text) || PassBoxOne.Text.Length < 5)
                {
                    label7.Text = "Пароль должен \nсостоять хотя бы из 5 символов";
                    label7.ForeColor = Color.Red;
                    label7.Show();
                }
                else
                {
                    label7.Hide();
                }
            }
        }

        private void CheckBoxLog(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length < 4)
                {
                    label8.Text = "Логин должен быть \nсостоять хотя бы из 4 символов";
                    label8.ForeColor = Color.Red;
                    label8.Show();
                }
                else
                {
                    label8.Hide();
                }
            }
        }
    }
}
