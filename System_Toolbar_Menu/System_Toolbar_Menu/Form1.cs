using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace System_Toolbar_Menu
{
    public partial class Form1 : Form
    {
        DAO dao = new DAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool ValidAccount()
        {
            // kiem tra neu username hoac pass word rong, 
            if (textBoxuser.Text.Trim() == "" || textBoxpass.Text.Trim() == "")
            {
                return false;

            }
            // kiem tra neu du lieu 1 truy van kieu SQLInjection
            Regex regex = new Regex(@"^([a-zA-Z0-9\.\@_]+)$");
            if (!regex.IsMatch(textBoxuser.Text.Trim()) && !regex.IsMatch(textBoxpass.Text.Trim()))
            {
                return false;
            }
            return true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxuser.Text.Trim();
            string pass = textBoxpass.Text.Trim();
            if (ValidAccount())
            {
                if (dao.getAccount(user, pass).Rows.Count > 0)
                {
                    MainScreen main = new MainScreen();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                    //new FrmMain().Show();

                }
                else
                {
                    MessageBox.Show("Your Account is wrong", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxuser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid Account", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxuser.Focus();
            }
        }
    }
}
