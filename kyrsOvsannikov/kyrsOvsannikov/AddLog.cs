using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsOvsannikov
{
    public partial class AddLog : Form
    {
        DataBase database = new DataBase();
        public AddLog()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var lg = textBoxLog.Text;
            var ps = textBoxPass.Text;
            var addQuery = $"insert into Регистрация(Логин, Пароль) values('{lg}', '{ps}')";
            var command = new SqlCommand(addQuery, database.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }

        private void pictureSteret_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = "";
            textBoxPass.Text = "";
        }
    }
}
