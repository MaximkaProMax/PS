using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.password.AutoSize = false; //Выключить авто высоту и ширину
            this.password.Size = new Size(this.password.Size.Width, 25); //Высота поля

            login.Text = "Введите имя";
            login.ForeColor = Color.Gray;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Введите имя")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            { 
                login.Text = "Введите имя";
                login.ForeColor = Color.Gray;
            }
        }
    }
}