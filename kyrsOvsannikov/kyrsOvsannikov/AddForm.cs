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
    public partial class AddForm : Form
    {
        DataBase database = new DataBase();
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var AddNameUser = NameBox.Text;
            var AddFamiliaUser = FamiliaBox.Text;
            var AddOt4estvoUser = Ot4estvoBox.Text;
            var AddNumberUser = TelefonBox.Text;
            var AddAdressUser = AdresBox.Text;
            var addQuery = $"insert into Пользователи(Имя, Фамилия, Отчество, Телефон, Адрес) values('{AddNameUser}', '{AddFamiliaUser}', '{AddOt4estvoUser}', '{AddNumberUser}', '{AddAdressUser}')";
            var command = new SqlCommand(addQuery, database.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не создана!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }

        private void pictureSteret_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            FamiliaBox.Text = "";
            Ot4estvoBox.Text = "";
            AdresBox.Text = "";
            TelefonBox.Text = "";
        }
    }
}
