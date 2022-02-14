﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


/* Процедуры:
 * CloseButton_Click - выход из программы;
 * BackButton_Click - переход в главное меню;
 * addButton_Click - добавление данных;
 * RukRabForm_Load - просмотр данных;
 * deleteButton_Click - удаление данных;
 * editButton_Click - обновление данных;
 * checkUser - проверка на повторяющиеся данные;
 * searchButton_Click - поиск данных;
 * panel1_MouseMove и panel1_MouseDown - перемещение окна.
 */

namespace proga1
{
    public partial class RukRabForm : Form
    {
        public RukRabForm()
        {
            InitializeComponent();
        }

        /* Процедура вывода данных
         * Формальные параметры:
         * sender - объект, вызвавший обработчик;
         * e - аргументы события, которое вызвал разработчик.
         * Локальные переменные:
         * db - экземпляр класса DB;         
         * table - вывод данных из БД;
         * adapter - чтение данных из БД;
         * command - запрос SQL.
         */

        private void RukRabForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command = new MySqlCommand("Select * From rab_and_ruk ", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            Data2.DataSource = table;
        }

        /*Кнопка выхода из программы
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Кнопка, ведущая в главное меню
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }

        /*Функции позволящие перемещать окно по экрану
       * Формальные параметры:
       * sender - объект, вызвавший обработчик;
       * e - аргументы события, которое вызвал разработчик.
       */

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        /* Процедура поиска данных
       * Формальные параметры:
       * sender - объект, вызвавший обработчик;
       * e - аргументы события, которое вызвал разработчик.
       * Локальные переменные:
       * i - строки таблицы;
       * j - столбцы таблицы.
       */

        private void searchButton_Click(object sender, EventArgs e)
        {//Выделение совпадений в таблице
            for (int i = 0; i < Data2.RowCount; i++)
            {
                Data2.Rows[i].Selected = false;
                for (int j = 0; j < Data2.ColumnCount; j++)
                    if (Data2.Rows[i].Cells[j].Value != null)
                        if
                       (Data2.Rows[i].Cells[j].Value.ToString().Contains(SearchField.Text))
                        {
                            Data2.Rows[i].Selected = true;
                            break;
                        }
            }
        }//Проверка на повторяющиеся данные
        public Boolean checkUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command = new MySqlCommand("Select * From rab_and_ruk Where id_ru = @lu and id_ra=@pr ", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.Int32).Value = Field1.Text;
            command.Parameters.Add("@pr", MySqlDbType.Int32).Value = Field2.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)

            {
                MessageBox.Show("Данное значение уже есть в бд");
                return true;
            }
            else
                return false;
        }

        /* Процедура добавления данных
         * Формальные параметры:
         * sender - объект, вызвавший обработчик;
         * e - аргументы события, которое вызвал разработчик.
         * Локальные переменные:
         * db - экземпляр класса DB;
         * Reader - чтение данных из БД;
         * command2 - запрос SQL;
         * table - вывод данных из БД;
         * adapter - чтение данных из БД;
         * command - запрос SQL.
         */

        private void addButton_Click(object sender, EventArgs e)
        {//Проверка на наличие незаполненных полей
            if (Field1.Text == "" || Field2.Text == "")
            {
                MessageBox.Show("Заполните все поля для ввода.");
                return;
            }//Проверка на повторяющиеся данные
            if (checkUser())
                return;
            DB db = new DB();
            try
            {   // Формирование запроса
                MySqlCommand command = new MySqlCommand("insert into rab_and_ruk(id_ru,id_ra) values(@n,@id);", db.getConnection());
                command.Parameters.Add("@n", MySqlDbType.Int32).Value = Field1.Text;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Field2.Text;
                MySqlDataReader MyReader2;
                db.OpenConnection();
                MyReader2 = command.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                db.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }// Добавление данных
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command2 = new MySqlCommand("Select * From rab_and_ruk ", db.getConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(table);
            Data2.DataSource = table;
        }

        /* Процедура редактирования данных
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        * Локальные переменные:
        * db - экземпляр класса DB;
        * Reader - чтение данных из БД;
        * command2 - запрос SQL;
        * table - вывод данных из БД;
        * adapter - чтение данных из БД;
        * command - запрос SQL.
        */

        private void editButton_Click(object sender, EventArgs e)
        {//Проверка на наличие незаполненных полей
            if (idField.Text == "")
            {
                MessageBox.Show("Заполните поле ID.");
                return;
            }
            if (Field1.Text == "" || Field2.Text == "")
            {
                MessageBox.Show("Заполните все полz для ввода.");
                return;
            }//Проверка на повторяющиеся данные
            if (checkUser())
                return;
            DB db = new DB();
            try
            {
                // Формирование запроса
                MySqlCommand command = new MySqlCommand("update rab_and_ruk set id_ru=@n,id_ra=@id where id_g=@id2", db.getConnection());
                command.Parameters.Add("@n", MySqlDbType.Int32).Value = Field1.Text;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Field2.Text;
                command.Parameters.Add("@id2", MySqlDbType.Int32).Value = idField.Text;
                MySqlDataReader MyReader2;
                db.OpenConnection();
                MyReader2 = command.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }// Редактирование данных
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command2 = new MySqlCommand("Select * From rab_and_ruk ", db.getConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(table);
            Data2.DataSource = table;
        }

        /* Процедура удаления данных
       * Формальные параметры:
       * sender - объект, вызвавший обработчик;
       * e - аргументы события, которое вызвал разработчик.
       * Локальные переменные:
       * db - экземпляр класса DB;
       * Reader - чтение данных из БД;
       * command2 - запрос SQL;
       * table - вывод данных из БД;
       * adapter - чтение данных из БД;
       * command - запрос SQL.
       */

        private void deleteButton_Click(object sender, EventArgs e)
        {//Проверка на наличие незаполненных полей
            if (idField.Text == "")
            {
                MessageBox.Show("Заполните поле ID.");
                return;
            }
            DB db = new DB();
            try
            {
                // Формирование запроса
                MySqlCommand command = new MySqlCommand("delete from rab_and_ruk where id_g=@id2", db.getConnection());
                command.Parameters.Add("@id2", MySqlDbType.Int32).Value = idField.Text;
                MySqlDataReader MyReader2;
                db.OpenConnection();
                MyReader2 = command.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }// Удаление данных
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command2 = new MySqlCommand("Select * From rab_and_ruk ", db.getConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(table);
            Data2.DataSource = table;
        }
    }
}
