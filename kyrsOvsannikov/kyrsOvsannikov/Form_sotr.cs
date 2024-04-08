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
using QRCoder;
using System.Drawing.Printing;

namespace kyrsOvsannikov
{
    public partial class Form_sotr : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        DateTime date = DateTime.Now;
        public Form_sotr()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ПользовательId", "№");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("Адрес", "Адрес");
            dataGridView1.Columns.Add("Телефон", "Номер телефона");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[6].Visible = false;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Пользователи";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void CreateColumns2()
        {
            dataGridView2.Columns.Add("АвтоId", "№");
            dataGridView2.Columns.Add("Категория", "Категория");
            dataGridView2.Columns.Add("АвтоИмя", "Марка");
            dataGridView2.Columns.Add("МаркаАвто", "Модель");
            dataGridView2.Columns.Add("Описание", "Описание");
            dataGridView2.Columns.Add("Цена", "Цена");
            dataGridView2.Columns.Add("IsNew2", String.Empty);
            dataGridView2.Columns[6].Visible = false;
        }

        private void ReadSingleRow2(DataGridView dgw2, IDataRecord record)
        {
            dgw2.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), RowState2.ModifiedNew);
        }

        private void RefreshDataGrid2(DataGridView dgw2)
        {
            dgw2.Rows.Clear();
            string queryString = $"select * from Автомобили";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow2(dgw2, reader);
            }
            reader.Close();
        }

        private void CreateColumns3()
        {
            dataGridView3.Columns.Add("ЗаказID", "№");
            dataGridView3.Columns.Add("ПользовательID", "№ Пользователя");
            dataGridView3.Columns.Add("АвтоID", "Номер авто");
            dataGridView3.Columns.Add("Дата", "Дата");
            dataGridView3.Columns.Add("IsNew3", String.Empty);
            dataGridView3.Columns[4].Visible = false;
        }

        private void ReadSingleRow3(DataGridView dgw3, IDataRecord record)
        {
            dgw3.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetDateTime(3), RowState4.ModifiedNew);
        }

        private void RefreshDataGrid3(DataGridView dgw3)
        {
            dgw3.Rows.Clear();
            string queryString = $"select * from Заказы";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow3(dgw3, reader);
            }
            reader.Close();
        }

        private void Form_sotr_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            CreateColumns2();
            RefreshDataGrid2(dataGridView2);
            CreateColumns3();
            RefreshDataGrid3(dataGridView3);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];
                textBoxKodUser.Text = row.Cells[1].Value.ToString();
                textBoxKodAuto.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
            }
        }

        private void pictureRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void pictureRefresh2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid2(dataGridView2);
        }

        private void pictureRefresh3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid3(dataGridView3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAuto auto = new AddAuto();
            auto.ShowDialog();
        }

        private void buttonZakaz_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var kodus = textBoxKodUser.Text;
            var kodau = textBoxKodAuto.Text;
            var date = dateTimePicker1.Value;
            if (textBoxKodUser.Text == "")
            {
                MessageBox.Show("Введите код пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxKodAuto.Text == "")
            {
                MessageBox.Show("Введите код авто!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var addQuery = $"insert into Заказы(ПользовательID, АвтоID, ДатаЗаказа) values('{kodus}', '{kodau}', '{date}')";
                var command = new SqlCommand(addQuery, database.getConnection());
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Запись не добавлена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            database.closeConnection();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Авто-магазин «Покатаимся»", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.IndianRed, new Point(70));
            e.Graphics.DrawString("Чек покупки товара: ", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 25));
            e.Graphics.DrawString($"Покупатель: {lbF.Text} {lbI.Text}", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 50));
            e.Graphics.DrawString($"Название товара: {lbName.Text} {lbM.Text}", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString("Дата: " + dateTimePicker1.Text, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString("Стоимость: " + lbCost.Text + " руб.", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 170));
            int newWidth = picQR.Width / 2;
            int newHeight = picQR.Height / 2;
            e.Graphics.DrawImage(picQR.Image, new Rectangle(80, 207, 250, 250));
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            database.openConnection();
            string id = textBoxKodUser.Text;
            string query = $"select * from Пользователи where ПользовательID = '{id}'";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbF.Text = reader["Имя"].ToString();
                lbI.Text = reader["Фамилия"].ToString();
            }
            database.closeConnection();
            database.openConnection();
            string autoID = textBoxKodAuto.Text;
            query = $"select * from Автомобили where АвтоID = '{autoID}'";
            cmd = new SqlCommand(query, database.getConnection());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbCost.Text = reader["Цена"].ToString();
                lbName.Text = reader["АвтоИмя"].ToString();
                lbM.Text = reader["МаркаАвто"].ToString();
            }
            reader.Close();
            database.openConnection();
            string idus = textBoxKodUser.Text;
            query = $"select * from Пользователи where ПользовательID = '{idus}'";
            cmd = new SqlCommand(query, database.getConnection());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbF.Text = reader["Имя"].ToString();
                lbI.Text = reader["Фамилия"].ToString();
            }
            database.closeConnection();
            string txtQrCode = "Авто-магазин «Покатаемся»" + "\nЧек покупки товара" + $"\nПокупатель: {lbF.Text} {lbI.Text}" + $"\nНазвание товара: {lbName.Text} {lbM.Text}" +
            "\nДата: " + dateTimePicker1.Text + $"\nСтоимость: {lbCost.Text}";
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQrCode, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQR.Image = code.GetGraphic(5);
            if (textBoxKodUser.Text == "" || textBoxKodAuto.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 415, 500);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Пользователи where concat(Имя, Фамилия, Отчество, Адрес, Телефон) like '%" + textBoxSearch.Text + "%' ";
            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Search2(DataGridView dgw2)
        {
            dgw2.Rows.Clear();
            string searchString = $"select * from Автомобили where concat(Категория, АвтоИмя, МаркаАвто, Цена) like '%" + textBoxSearch2.Text + "%' ";
            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow2(dgw2, read);
            }
            read.Close();
        }

        private void textBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            Search2(dataGridView2);
        }

        private void Search3(DataGridView dgw3)
        {
            dgw3.Rows.Clear();
            string searchString = $"select * from Заказы where concat(ЗаказID, АвтоID, ПользовательID) like '%" + textBoxSearch3.Text + "%' ";
            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow3(dgw3, read);
            }
            read.Close();
        }

        private void textBoxSearch3_TextChanged(object sender, EventArgs e)
        {
            Search3(dataGridView3);
        }
    }
}
