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
    }
}