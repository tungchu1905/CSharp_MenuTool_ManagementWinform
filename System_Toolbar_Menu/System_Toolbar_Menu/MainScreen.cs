using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System_Toolbar_Menu
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            picBoxMain.ImageLocation = @"..\Images\trithuc.jpg";
            picBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSmall.ImageLocation = @"..\Images\trithuc.jpg";
            pictureBoxSmall.SizeMode = PictureBoxSizeMode.StretchImage;
            DateTime DATE = DateTime.Now;
            toolStripLabelDateTime.Text = DATE.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfor user = new UserInfor();
            this.Hide();
            user.ShowDialog();
            this.Close();
        }

        private void studentRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfor ST = new StudentInfor();
            this.Hide();
            ST.ShowDialog();
            this.Close();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UserInfor user = new UserInfor();
            this.Hide();
            user.ShowDialog();
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StudentInfor student = new StudentInfor();
            this.Hide();
            student.ShowDialog();
            this.Close();
        }
    }
}
