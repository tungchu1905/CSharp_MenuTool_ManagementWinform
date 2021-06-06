using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace System_Toolbar_Menu
{
    
    public partial class UserInfor : Form
    {
       
        DAO dao = new DAO();
        
        public UserInfor()
        {
            InitializeComponent();
            dgv1.DataSource = dao.getDataUser();
        }
        





        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dao.insertUser(txtUN.Text, txtPassw.Text, txtSname.Text, txtAddress.Text, txtEmail.Text);

            dgv1.DataSource = dao.getDataUser();
        }

        private void UserInfor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dao.updateUser(txtUN.Text, txtPassw.Text, txtSname.Text, txtAddress.Text, txtEmail.Text, txtCode.Text);
            dgv1.DataSource = dao.getDataUser();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dao.deleteUser(txtCode.Text);
            dgv1.DataSource = dao.getDataUser();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = dao.getDataUser();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;
            txtCode.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            txtUN.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            txtPassw.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            txtSname.Text = dgv1.Rows[i].Cells[3].Value.ToString();
            txtAddress.Text = dgv1.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = dgv1.Rows[i].Cells[5].Value.ToString();
        }
    }
}
