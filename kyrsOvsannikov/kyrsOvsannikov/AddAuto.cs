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
    public partial class AddAuto : Form
    {
        DataBase database = new DataBase();
        public AddAuto()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var AddNameAuto = NameAutoBox.Text;
            var AddMarkaAuto = MarkaAutoBox.Text;
            int kat;
            var AddOpisanieAuto = OpisanieAutoBox.Text;
            int cena;
            if(int.TryParse(CenaAutoBox.Text, out cena))
            {
                if (int.TryParse(KategoriaAutoBox.Text, out kat))
                {
                    if (kat <= 16 & kat > 0)
                    {
                        var addQuery = $"insert into Автомобили(Категория, АвтоИмя, МаркаАвто, Описание, Цена) values('{kat}', '{AddNameAuto}', '{AddMarkaAuto}', '{AddOpisanieAuto}', '{cena}')";
                        var command = new SqlCommand(addQuery, database.getConnection());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Категория должна быть от 1 до 16!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Категория должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            database.closeConnection();
        }

        private void pictureSteret_Click(object sender, EventArgs e)
        {
            NameAutoBox.Text = "";
            MarkaAutoBox.Text = "";
            KategoriaAutoBox.Text = "";
            CenaAutoBox.Text = "";
            OpisanieAutoBox.Text = "";
        }
    }
}
