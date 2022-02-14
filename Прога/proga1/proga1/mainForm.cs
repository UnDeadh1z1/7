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
 * AuthButton_Click - переход к форме авторизации;
 * StudentButton_Click - переход к форме student;
 * OtchetButton_Click - переход к форме Condition;
 * SvyazTable_Click - переход к форме RukRabForm;
 * RabotiTable_Click - переход к форме rabForm;
 * RukovoTable_Click - переход к форме rukForm;
 * button3_Click - переход к форме Oblast;
 * GruppaTable_Click - переход к форме Grupa;
 * panel1_MouseMove и panel1_MouseDown - перемещение окна.
 */

namespace proga1
{
    public partial class mainForm : Form
    {
        public mainForm()
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

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        /*Кнопка перехода к форме авторизации
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void AuthButton_Click(object sender, EventArgs e)
        {
                this.Hide();
                authForm authForm = new authForm();
                authForm.Show();
        }

        /*Кнопка перехода к форме Student
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentForm studentForm = new studentForm();
            studentForm.Show();
        }

        /*Кнопка перехода к форме Grupa
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void GruppaTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            grupaForm grupaForm= new grupaForm();
            grupaForm.Show();
        }

        /*Кнопка перехода к форме Oblast
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            oblastForm oblastForm = new oblastForm();
            oblastForm.Show();
        }

        /*Кнопка перехода к форме rukForm
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void RukovoTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            rukForm rukForm = new rukForm();
            rukForm.Show();
        }

        /*Кнопка перехода к форме rabForm
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void RabotiTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            rabForm rabForm = new rabForm();
            rabForm.Show();
        }

        /*Кнопка перехода к форме RukRabForm
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void SvyazTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            RukRabForm rukRabForm = new RukRabForm();
            rukRabForm.Show();
        }

        /*Кнопка перехода к форме Condition
        * Формальные параметры:
        * sender - объект, вызвавший обработчик;
        * e - аргументы события, которое вызвал разработчик.
        */

        private void OtchetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Condition condition = new Condition();
            condition.Show();
        }
    }
}

