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
 * RegisterButton_Click - переход к форме регистрации;
 * button1_Click - авторизация;
 * Form1_MouseMove и Form1_MouseDown - перемещение окна.
 */

namespace proga1
{
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();
        }

        /*Кнопка авторизации
         * Формальные параметры:
         * sender - объект, вызвавший обработчик;
         * e - аргументы события, которое вызвал разработчик;
         * Локальные переменные:
         * db - экземпляр класса DB;
         * command2 - запрос SQL;
         * table - вывод данных из БД;
         * adapter - чтение данных из БД;
         * command - запрос SQL.
         */

        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка на наличие пустых полей
            if (loginField.Text == "")
            {
                MessageBox.Show("Введите логин.");
                return;
            }
            //Проверка корекктности введенных данных
            String loginUser = loginField.Text;
            String passUser = passField.Text;
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Формирование запроса
            MySqlCommand command = new MySqlCommand("Select * From users Where Login = @lu And Pass = @pu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
                //Переход к главному меню
            {
                this.Hide();
                mainForm mainForm = new mainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Неверный логин/пароль");
        }
        Point lastPoint;

        /*Функции позволящие перемещать окно по экрану
         * Формальные параметры:
         * sender - объект, вызвавший обработчик;
         * e - аргументы события, которое вызвал разработчик.
         */

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        /*Кнопка перехода к форме регистрации
         * Формальные параметры:
         * sender - объект, вызвавший обработчик;
         * e - аргументы события, которое вызвал разработчик.
         */

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.Show();
        }
    }
}
