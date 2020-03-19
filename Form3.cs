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
using Emgu.CV.Structure;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        bool _streaming;
        Capture _capture;
        Form2 form2;
        public Form3(Form2 form2)
        {
            this.form2 = form2;
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            _streaming = false;

            _capture = new Capture(1);
            Application.Idle += streaming;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }
        private void streaming(object sender, System.EventArgs e)
        {
            Image<Bgr, byte> img = null;
            try
            {
                img = _capture.QueryFrame().ToImage<Bgr, byte>();
            }
            catch
            {
                _capture = new Capture(0);
                img = _capture.QueryFrame().ToImage<Bgr, byte>();
            }
            
            var bmp = img.Bitmap;
            pictureBox1.Image = bmp;
        }
        private void discardButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            this.form2.set_Profile_picture(Image.FromFile(@"C:\Program Files\GymManager\Images\profile_picture.png"));
             
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Save("C:/Program Files/GymManager/Members/Images/i.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                this.form2.set_Profile_picture(pictureBox2.Image);
            }
            else
            {
                MessageBox.Show("Please click \"Capture\" first!");
            }

        }
    }
}
