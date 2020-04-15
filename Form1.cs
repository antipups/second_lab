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
        private String path_to_img = "";
        public Form1()
        {
            InitializeComponent();
            trackBar1.Visible = false;
            trackBar3.Visible = false;
            trackBar2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            button2.Visible = false;
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
                path_to_img = openDialog.InitialDirectory + openDialog.FileName;
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
            
            trackBar1.Visible = true;
            trackBar3.Visible = true;
            trackBar2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            button2.Visible = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(path_to_img);
            Graphics gr = Graphics.FromImage(pictureBox2.Image);
            Random rnd = new Random();
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    gr.FillRectangle(new SolidBrush(Color.FromArgb(rnd.Next(1, 255) , trackBar1.Value, trackBar3.Value, trackBar2.Value)), i, j, 1, 1);
                }
            }
            gr.Save();
            pictureBox2.Refresh();
        }
    }
}