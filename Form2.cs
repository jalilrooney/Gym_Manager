using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Program Files\GymManager\Images\profile_picture.png");
            pictureBox1.Image = image;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var photoForm = new Form3(this);
            photoForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fileDialog.FileName);
                pictureBox1.Image.Save("C:/Program Files/GymManager/Members/Images/lk.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        public void set_Profile_picture(Image image)
        {
            pictureBox1.Image = image;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
