using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second_lab
{
    public partial class Form1 : Form
    {
        private bool click = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = @"Файлы изображений|*.bmp;*.png;*.jpg";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;
            
            Image first, bmp;
            try
            {
                first = Image.FromFile(openDialog.InitialDirectory + openDialog.FileName);
                bmp = Image.FromFile(openDialog.InitialDirectory + openDialog.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(@"Ошибка чтения картинки");
                return;
            }
            
            pictureBox1.Width = 500;
            pictureBox1.Height = 500;
            pictureBox1.Image = first;
            pictureBox2.Width = 500;
            pictureBox2.Height = 500;
            pictureBox2.Image = bmp;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = Graphics.FromImage(pictureBox2.Image);
            int i = 0;
            Random rnd = new Random();
            while (i < 50)
            {
                int value = rnd.Next(-25, 25);
                int value2 = rnd.Next(-25, 25);
                button1.Text = value.ToString();
                gr.DrawLine(new Pen(Color.FromArgb(rnd.Next(0, 254), trackBar1.Value, trackBar2.Value, trackBar3.Value), 2), e.X, e.Y, e.X + value, e.Y + value2);
                i++;
            }
            gr.Save();
            pictureBox2.Refresh();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}