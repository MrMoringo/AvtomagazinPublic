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
using System.Threading;
using MySqlX.XDevAPI.Common;
using QRCoder;
using System.Collections;
using System.Xml.Linq;
using System.IO;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace kyrsOvsannikov
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    enum RowState2
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    enum RowState4
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    enum RowState5
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form_Admin : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        DateTime date = DateTime.Now;
        public Form_Admin()
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
            dataGridView3.Columns.Add("ПользовательID", "№ Пользователи");
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

        private void CreateColumns4()
        {
            dataGridView4.Columns.Add("РегистрацияID", "№");
            dataGridView4.Columns.Add("Логин", "Логин");
            dataGridView4.Columns.Add("Пароль", "Пароль");
            dataGridView4.Columns.Add("IsNew4", String.Empty);
            dataGridView4.Columns[3].Visible = false;
        }

        private void ReadSingleRow4(DataGridView dgw4, IDataRecord record)
        {
            dgw4.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState5.ModifiedNew);
        }

        private void RefreshDataGrid4(DataGridView dgw4)
        {
            dgw4.Rows.Clear();
            string queryString = $"select * from Регистрация";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow4(dgw4, reader);
            }
            reader.Close();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            CreateColumns2();
            RefreshDataGrid2(dataGridView2);
            CreateColumns3();
            RefreshDataGrid3(dataGridView3);
            CreateColumns4();
            RefreshDataGrid4(dataGridView4);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                IdBox.Text = row.Cells[0].Value.ToString();
                NameBox.Text = row.Cells[1].Value.ToString();
                FamiliaBox.Text = row.Cells[2].Value.ToString();
                Ot4estvoBox.Text = row.Cells[3].Value.ToString();
                AdresBox.Text = row.Cells[4].Value.ToString();
                TelefonBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void pictureRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Пользователи where concat(Имя, Фамилия, Отчество, Адрес, Телефон) like '%" + SearchBox.Text + "%' ";
            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddAuto auto = new AddAuto();
            auto.ShowDialog();
        }

        private void Search2(DataGridView dgw2)
        {
            dgw2.Rows.Clear();
            string searchString = $"select * from Автомобили where concat(Категория, АвтоИмя, МаркаАвто, Цена) like '%" + SearchBox2.Text + "%' ";
            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow2(dgw2, read);
            }
            read.Close();
        }

        private void SearchBox2_TextChanged(object sender, EventArgs e)
        {
            Search2(dataGridView2);
        }

        private void pictureRefresh2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid2(dataGridView2);
            ClearFields2();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                IdAutoBox.Text = row.Cells[0].Value.ToString();
                KategoriaAutoBox.Text = row.Cells[1].Value.ToString();
                NameAutoBox.Text = row.Cells[2].Value.ToString();
                MarkaAutoBox.Text = row.Cells[3].Value.ToString();
                OpisanieAutoBox.Text = row.Cells[4].Value.ToString();
                CenaAutoBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }
        private void deleteRow2()
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = false;
            dataGridView2.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void deleteRow3()
        {
            int index = dataGridView3.CurrentCell.RowIndex;
            dataGridView3.Rows[index].Visible = false;
            dataGridView3.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void Update()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Пользователи where ПользовательID = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    dataGridView1.AllowUserToAddRows = false;
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var familia = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var ot4estvo = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var adres = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var telefon = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var data = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var changeQuery = $"update Пользователи set Имя = '{name}', Фамилия = '{familia}', Отчество = '{ot4estvo}', Адрес = '{adres}', Телефон = '{telefon}' where ПользовательID = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Update2()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[6].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Автомобили where АвтоID = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    dataGridView2.AllowUserToAddRows = false;
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var kat = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var nameauto = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var marka = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var opisanie = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    var cena = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    var changeQuery = $"update Автомобили set Категория = '{kat}', АвтоИмя = '{nameauto}', МаркаАвто = '{marka}', Описание = '{opisanie}', Цена = '{cena}' where АвтоID = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = IdBox.Text;
            var name = NameBox.Text;
            var familia = FamiliaBox.Text;
            var ot4estvo = Ot4estvoBox.Text;
            var adres = AdresBox.Text;
            var telefon = TelefonBox.Text;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, familia, ot4estvo, adres, telefon);
                dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
            }
        }

        private void Change2()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            var id = IdAutoBox.Text;
            int kat;
            var name = NameAutoBox.Text;
            var marka = MarkaAutoBox.Text;
            var opisanie = OpisanieAutoBox.Text;
            int cena;
            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(CenaAutoBox.Text, out cena))
                {
                    if (int.TryParse(KategoriaAutoBox.Text, out kat))
                    {
                        if (kat <= 16 & kat > 0)
                        {
                            dataGridView2.Rows[selectedRowIndex].SetValues(id, kat, name, marka, opisanie, cena);
                            dataGridView2.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
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
            }
        }

        private void buttonIzmena_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            deleteRow2();
            ClearFields2();
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            Update2();
        }

        private void buttonIzmena2_Click(object sender, EventArgs e)
        {
            Change2();
            ClearFields2();
        }
        private void ClearFields()
        {
            IdBox.Text = "";
            NameBox.Text = "";
            FamiliaBox.Text = "";
            Ot4estvoBox.Text = "";
            AdresBox.Text = "";
            TelefonBox.Text = "";
        }

        private void ClearFields2()
        {
            IdAutoBox.Text = "";
            NameAutoBox.Text = "";
            MarkaAutoBox.Text = "";
            KategoriaAutoBox.Text = "";
            CenaAutoBox.Text = "";
            OpisanieAutoBox.Text = "";
        }

        private void pictureSteret_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void pictureSteret2_Click(object sender, EventArgs e)
        {
            ClearFields2();
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

        private void pictureRefresh3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid3(dataGridView3);
        }

        private void Update3()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView3.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView3.Rows[index].Cells[4].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView3.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Заказы where ЗаказID = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    dataGridView3.AllowUserToAddRows = false;
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView3.Rows[index].Cells[0].Value.ToString();
                    var idus = dataGridView3.Rows[index].Cells[1].Value.ToString();
                    var autoid = dataGridView3.Rows[index].Cells[2].Value.ToString();
                    var data = dataGridView3.Rows[index].Cells[3].Value.ToString();
                    var changeQuery = $"update Заказы set ПользовательID = {idus}, АвтоID = '{autoid}', Дата = '{data}' where Заказ = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void buttonSave3_Click(object sender, EventArgs e)
        {
            Update3();
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

        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            deleteRow3();
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxKodAuto.Text = "";
            textBoxKodUser.Text = "";
            dateTimePicker1.Text = "";
            textBoxSearch3.Text = "";
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[selectedRow];
                textBoxIDReg.Text = row.Cells[0].Value.ToString();
                textBoxLogReg.Text = row.Cells[1].Value.ToString();
                textBoxPassReg.Text = row.Cells[2].Value.ToString();
            }
        }

        private void ClearFields4()
        {
            textBoxIDReg.Text = "";
            textBoxLogReg.Text = "";
            textBoxPassReg.Text = "";
        }

        private void pictureBoxSteret4_Click(object sender, EventArgs e)
        {
            ClearFields4();
        }

        private void pictureBoxRefresh4_Click(object sender, EventArgs e)
        {
            RefreshDataGrid4(dataGridView4);
        }

        private void Search4(DataGridView dgw4)
        {
            dgw4.Rows.Clear();
            string searchString = $"select * from Регистрация where concat(РегистрацияID, Логин, Пароль) like '%" + textBoxSearch4.Text + "%' ";
            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow4(dgw4, read);
            }
            read.Close();
        }

        private void textBoxSearch4_TextChanged(object sender, EventArgs e)
        {
            Search4(dataGridView4);
        }

        private void buttonNew4_Click(object sender, EventArgs e)
        {
            AddLog log = new AddLog();
            log.ShowDialog();
        }

        private void deleteRow4()
        {
            int index = dataGridView4.CurrentCell.RowIndex;
            dataGridView4.Rows[index].Visible = false;
            dataGridView4.Rows[index].Cells[3].Value = RowState.Deleted;
        }

        private void buttonDelete4_Click(object sender, EventArgs e)
        {
            deleteRow4();
            ClearFields4();
        }

        private void Change4()
        {
            var selectedRowIndex = dataGridView4.CurrentCell.RowIndex;
            var id = textBoxIDReg.Text;
            var lg = textBoxLogReg.Text;
            var ps = textBoxPassReg.Text;
            if (dataGridView4.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView4.Rows[selectedRowIndex].SetValues(id, lg, ps);
                dataGridView4.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
            }
        }

        private void buttonIzmena4_Click(object sender, EventArgs e)
        {
            Change4();
            ClearFields4();
        }

        private void Update4()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView4.Rows.Count; index++)
            {
                var rowState = (RowState4)dataGridView4.Rows[index].Cells[3].Value;
                if (rowState == RowState4.Existed)
                    continue;
                if (rowState == RowState4.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView4.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Регистрация where РегистрацияID = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    dataGridView4.AllowUserToAddRows = false;
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState4.Modified)
                {
                    var id = dataGridView4.Rows[index].Cells[0].Value.ToString();
                    var lg = dataGridView4.Rows[index].Cells[1].Value.ToString();
                    var ps = dataGridView4.Rows[index].Cells[2].Value.ToString();
                    var changeQuery = $"update Регистрация set Логин = '{lg}', Пароль = '{ps}' where РегистрацияID = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void buttonSave4_Click(object sender, EventArgs e)
        {
            Update4();
        }
    }
}