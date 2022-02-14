using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Процедуры:
 * closeButton_Click - выход из программы;
 * BackButton_Click - переход к форме авторизации;
 * button1_Click - авторизация;
 * SaveButton_Click - сохранение введенных данных;
 * checkUser - проверка на одинаковые логины;
 * panel1_MouseMove и panel1_MouseDown - перемещение окна.
 */

namespace proga1
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }
        Point lastPoint;

        /*Функции позволящие перемещать окно по экрану
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        /*Кнопка выхода из программы
          * Формальные параметры:
          * sender - объект, вызвавший обработчик;
          * e - аргументы события, которое вызвал разработчик.
          */

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Кнопка перехода к форме авторизации
         * Формальные параметры:
         * sender - объект, вызвавший обработчик;
         * e - аргументы события, которое вызвал разработчик.
         */

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
           authForm authForm = new authForm();
            authForm.Show();
        }

        /*Кнопка сохранения пользователя
         * Формальные параметры:
         * sender - объект, вызвавший обработчик;
         * e - аргументы события, которое вызвал разработчик.
         * Локальные переменные:
         * db - экземпляр класса DB;
         * table - вывод данных из БД;
         * adapter - чтение данных из БД;
         * command - запрос SQL.
         */

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Проверка на наличие пустых полей
            if (loginField.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            
            if (checkUser())
                return;
            // Формирование запроса
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("insert into `users` (`login`, `pass`) Values (@l, @p)",db.getConnection());
            command.Parameters.Add("@l",MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@p",MySqlDbType.VarChar).Value = passField.Text;

            db.OpenConnection();

          
            if (command.ExecuteNonQuery() == 1)
            
                MessageBox.Show("Аккаунт создан");
            
            else
                MessageBox.Show("Аккаунт не создан");

            db.CloseConnection();
        }
        //Проверка на повторяющиеся данные
        public Boolean checkUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command = new MySqlCommand("Select * From users Where Login = @lu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)

            {
                MessageBox.Show("Придумайте другой Логин");
                return true;
            }
            else
                return false;
        }
    }
}

