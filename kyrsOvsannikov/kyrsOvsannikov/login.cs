using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kyrsOvsannikov
{
    public partial class login : Form
    {

        DataBase dataBase = new DataBase();

        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
            HideBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = textBox_login.Text.CompareTo(textBox_Test.Text);
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select РегистрацияID, Логин, Пароль from Регистрация where Логин = '{loginUser}' and Пароль = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (n == 0)
                {   
                    Form_Admin frm1 = new Form_Admin();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show(); 
                }
                else 
                {
                    Form_sotr frms = new Form_sotr();
                    this.Hide();
                    frms.ShowDialog();
                    this.Show();
                }
            }
            else
                MessageBox.Show("Введен не верный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            singup frm_sing = new singup();
            frm_sing.Show();
            this.Hide();
        }

        private void ClearBox_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void ShowBox_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            ShowBox.Visible = false;
            HideBox.Visible = true;
        }

        private void HideBox_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            ShowBox.Visible = true;
            HideBox.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_user frm_sing = new Form_user();
            frm_sing.Show();
            this.Close();
        }
    }
}
