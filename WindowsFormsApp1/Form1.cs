using MySql.Data.MySqlClient; //Библиотека клиента SQL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.password.AutoSize = false; //Выключить авто высоту и ширину
            this.password.Size = new Size(this.password.Size.Width, 25); //Высота поля
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black; //При наведении черный
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#003087"); //При НЕ наведении цвет из PS
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // Если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                // Перемещаем панель
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

                /* 
                Вычисляется разница между текущими и предыдущими значениями координат, 
                а затем прибавляется к соответствующим свойствам объекта (в данном случае this.Left и this.Top).
                */

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Сохраняем координаты курсора мыши
            lastPoint = new Point(e.X, e.Y);
        }

        private void butlog_Click(object sender, EventArgs e)
        {
            String loguser = login.Text; //Записываем лог
            String passuser = password.Text; //Записываем пароль

            DB db = new DB(); //Работаем с БД

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `pass` = @up", db.getConnection()); //Новая команда на яз SQL, выбрать лог и пароль (WPF данные == SQL данные) (@заглушка)
            
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login; //Внутри заглушки переменная (Тип данных VarChar, и далее самое значение login)
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password; //Внутри заглушки переменная (Тип данных VarChar, и далее самое значение password)

            adapter.SelectCommand = command; //Выбрать команду
            adapter.Fill(table); //Сформировать массив данных (Сколько элементов/записей)

            if (table.Rows.Count > 0) //Если рядов больше 0, то пользователь есть, авторизация
            {
                MessageBox.Show("Вошел"); //Вывести сообщение
            }

            else //Иначе
                MessageBox.Show("Не вошел");
        }
    }
}