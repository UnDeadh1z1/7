using System;
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
 * button1_Click - процедура получения информации о состоянии работы;
 * panel1_MouseMove и panel1_MouseDown - перемещение окна.
 */

namespace proga1
{
    public partial class Condition : Form
    {
        public Condition()
        {
            InitializeComponent();
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

        /* Процедура получения информации о состоянии работы
      * Формальные параметры:
      * sender - объект, вызвавший обработчик;
      * e - аргументы события, которое вызвал разработчик.
      * Локальные переменные:
      * db - экземпляр класса DB;
      * adapter - чтение данных из БД;
      * result, result1; - считываемые даты из БД;
      * dateInput,dateInput1 - переменные для перезаписи даты в string;
      * parsedDate, parsedDate1 - переменные для перезаписи даты в DateTime;
      * command1 - запрос SQL;
      * command - запрос SQL.
      */

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            
                db.OpenConnection();
                // Формирование запроса
                MySqlCommand command = new MySqlCommand("SELECT Date_extradition FROM rabota where Id_rab=@pr ;", db.getConnection());
                command.Parameters.Add("@pr", MySqlDbType.Int32).Value = Field1.Text;


                var result = command.ExecuteScalar().ToString();
               

                db.CloseConnection();

           
            string dateInput = result;
            var parsedDate = DateTime.Parse(dateInput);

            db.OpenConnection();
            // Формирование запроса
            MySqlCommand command1 = new MySqlCommand("SELECT Date_delivery FROM rabota where Id_rab=@pr ;", db.getConnection());
            command1.Parameters.Add("@pr", MySqlDbType.Int32).Value = Field1.Text;


            var result1 = command1.ExecuteScalar().ToString();


            db.CloseConnection();

            //Вывод информации о состоянии работы
            string dateInput1 = result1;
            var parsedDate1 = DateTime.Parse(dateInput1);
            if(parsedDate>DateTime.Now)
            {
                MessageBox.Show("Работа еще не начата");
            }
            else
            {
                if (parsedDate1<=DateTime.Now)
                {
                    MessageBox.Show("Работа выполнена");
                }
                else
                {
                    MessageBox.Show("Работа в процессе");
                }
            }
        }
    }
}
