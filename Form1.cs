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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = @"Файлы изображений|*.bmp;*.png;*.jpg";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;
            
            Image bmp = Image.FromFile(@"C:\Users\kurku\Documents\C#Projects\second_lab_C#\second_lab\1.jpg");
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawLine(Pens.Black, 1, 1, 100, 100);
            gr.Save();
            pictureBox1.Image = bmp;

            // PixelFormat pf = img.PixelFormat;
            // pf.
            // try
            // {
            //     image = Image.FromFile(openDialog.FileName);
            // }
            // catch (OutOfMemoryException ex)
            // {
            //     MessageBox.Show(@"Ошибка чтения картинки");
            //     return;
            // }
            //
            // pictureBox1.Image = image;
            // pictureBox1.AutoSize = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }
    }
}