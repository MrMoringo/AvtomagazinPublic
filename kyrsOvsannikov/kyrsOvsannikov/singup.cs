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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kyrsOvsannikov
{
    public partial class singup : Form
    {
        DataBase dataBase = new DataBase();
        public singup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void singup_Load(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            textBox_login2.MaxLength = 50;
            textBox_password2.MaxLength = 50;
            HideBox2.Visible = false;
        }

        private void ClearBox2_Click(object sender, EventArgs e)
        {
            textBox_login2.Text = "";
            textBox_password2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var NewLoginUser = textBox_login2.Text;
            var NewPassUser = textBox_password2.Text;    
            if (checkUser())
            {
                return;
            }
            string querystring = $"insert into Регистрация(Логин, Пароль) values('{NewLoginUser}','{NewPassUser}')";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login frm_login = new login();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }
        private Boolean checkUser()
        {
            var loginUser = textBox_login2;
            var passUser = textBox_password2;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select РегистрацияID, Логин, Пароль from Регистрация where Логин = '{loginUser}' and Пароль = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ShowBox2_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = false;
            ShowBox2.Visible = false;
            HideBox2.Visible = true;
        }

        private void HideBox2_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            ShowBox2.Visible = true;
            HideBox2.Visible = false;
        }
    }
}
