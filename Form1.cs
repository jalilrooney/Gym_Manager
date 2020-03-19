using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists("C:/Program Files/GymManager/Members"))
            {
                Directory.CreateDirectory("C:/Program Files/GymManager/Members");
            }
            if (!Directory.Exists("C:/Program Files/GymManager/Members/Images"))
            {
                Directory.CreateDirectory("C:/Program Files/GymManager/Members/Images");
            }
            if (!Directory.Exists("C:/Program Files/GymManager/Images"))
            {
                Directory.CreateDirectory("C:/Program Files/GymManager/Images");
                File.Copy(Path.Combine(Directory.GetCurrentDirectory(), "profile_picture.png"), Path.Combine("C:/Program Files/GymManager/Images", "profile_picture.png"), true);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaurerBox.Visible = true;
            minBox.Visible = false;
        }

        private void restaurerBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurerBox.Visible = false;
            minBox.Visible = true;
        }

        private void menuBox_Click(object sender, EventArgs e)
        {
            if (verticalPanel.Width == 250)
            {
                verticalPanel.Width = 70;
            }
            else
                verticalPanel.Width = 250;
        }

        public static Form activeForm = new Form2();
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(ChildForm);
            centerPanel.Tag = ChildForm;
            centerPanel.BringToFront();
            ChildForm.Show();


        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.horizontalPanel.GradientBottomLeft = System.Drawing.Color.Green;
            this.horizontalPanel.GradientBottomRight = System.Drawing.Color.Green;
            this.horizontalPanel.GradientTopLeft = System.Drawing.Color.MediumSpringGreen;
            this.horizontalPanel.GradientTopRight = System.Drawing.Color.MediumSpringGreen;
            openChildForm(new Form2());           
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void horizontalPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}