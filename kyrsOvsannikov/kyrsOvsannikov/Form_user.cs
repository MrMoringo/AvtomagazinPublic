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
    enum RowState3
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form_user : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        public Form_user()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("АвтоId", "№");
            dataGridView1.Columns.Add("Категория", "Категория");
            dataGridView1.Columns.Add("АвтоИмя", "Марка");
            dataGridView1.Columns.Add("МаркаАвто", "Модель");
            dataGridView1.Columns.Add("Описание", "Описание");
            dataGridView1.Columns.Add("Цена", "Цена");
            dataGridView1.Columns.Add("IsNew2", String.Empty);
            dataGridView1.Columns[6].Visible = false;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), RowState2.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Автомобили";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form_user_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Автомобили where concat(Категория, АвтоИмя, МаркаАвто, Цена) like '%" + textBoxSearch.Text + "%' ";
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

        private void pictureRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }
        private void ClearFields()
        { 
            textBoxOpisanie.Text = "";
            textBoxSearch.Text = "";
        }

        private void pictureSteret2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBoxIDAuto.Text = row.Cells[0].Value.ToString();
                textBoxOpisanie.Text = row.Cells[4].Value.ToString();
            }
        }

        private void ЗаказатьItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хотите заказать у нас авто? Приходите в наш автомагазин по адресу г. Феодосия, ул. Пушкина, дом 13! Будем вас ждать!", "Заказ", MessageBoxButtons.OK);
        }

        private void ПрофильItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }
    }
}
