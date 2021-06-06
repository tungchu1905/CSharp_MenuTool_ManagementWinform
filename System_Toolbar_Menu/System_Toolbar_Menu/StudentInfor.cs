using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System_Toolbar_Menu
{
    public partial class StudentInfor : Form
    {
        DAO dao = new DAO();
        public StudentInfor()
        {
            InitializeComponent();
            dgvStudentInfor.DataSource = dao.getStudentInfor();
           
        }

        private void StudentInfor_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void dgvStudentInfor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvStudentInfor.CurrentRow.Index;


            txtSid.Text = dgvStudentInfor.Rows[i].Cells[0].Value.ToString();
            txtFN.Text = dgvStudentInfor.Rows[i].Cells[1].Value.ToString();
            txtLN.Text = dgvStudentInfor.Rows[i].Cells[2].Value.ToString();
            dateTime.Text = dgvStudentInfor.Rows[i].Cells[3].Value.ToString();
            txtAddress.Text = dgvStudentInfor.Rows[i].Cells[4].Value.ToString();
            txtPhone.Text = dgvStudentInfor.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dgvStudentInfor.Rows[i].Cells[6].Value.ToString();
            txtReligion.Text = dgvStudentInfor.Rows[i].Cells[7].Value.ToString();
            txtNation.Text = dgvStudentInfor.Rows[i].Cells[8].Value.ToString();
            if (dgvStudentInfor.Rows[i].Cells[9].Value.ToString() == "True")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            if (dgvStudentInfor.Rows[i].Cells[10].Value.ToString() == "English")
            {
                cbEnglish.Checked = true;
                cbJapan.Checked = false;
                cbVietnam.Checked = false;
            }
            else if (dgvStudentInfor.Rows[i].Cells[10].Value.ToString() == "Vietnamese")
            {
                cbVietnam.Checked = true;
                cbEnglish.Checked = false;
                cbJapan.Checked = false;
            }
            else
            {
                cbJapan.Checked = true;
                cbEnglish.Checked = false;
            }

            picbox.ImageLocation = @"" + dgvStudentInfor.Rows[i].Cells[11].Value.ToString() + "";
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            using (SqlConnection con = dao.getConnection())
            {
                con.Open();
                string sql = "  select FatherName,FaAddress,FaCareer,MotherName,MoAddress,MoCareer from StudentInfo,StudentFamily where StudentInfo.Sid = StudentFamily.Pid and sid = " + dgvStudentInfor.Rows[i].Cells[0].Value.ToString() + "";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtfaname.Text = da.GetValue(0).ToString();
                    txtfaaddress.Text = da.GetValue(1).ToString();
                    txtfacareer.Text = da.GetValue(2).ToString();
                    txtmomname.Text = da.GetValue(3).ToString();
                    txtmomaddress.Text = da.GetValue(4).ToString();
                    txtmomcareer.Text = da.GetValue(5).ToString();

                }
                con.Close();
            }
                
        }
        public string maleFmale()
        {
            if (rbMale.Checked == true)
            {
                return "1";
            }
            else {
                return "0";
                    }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            dao.updateStudent(txtFN.Text, txtLN.Text, dateTime.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, txtReligion.Text, txtNation.Text ,maleFmale(), cbEnglish.Text, picbox.ImageLocation.Trim(), txtSid.Text);
           dgvStudentInfor.DataSource =  dao.getStudentInfor();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dao.insertStudent(txtFN.Text, txtLN.Text, dateTime.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, txtReligion.Text, txtNation.Text, maleFmale(), cbEnglish.Text, picbox.ImageLocation.Trim());
            dgvStudentInfor.DataSource = dao.getStudentInfor();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dao.deleteStudent(txtSid.Text);
            dgvStudentInfor.DataSource = dao.getStudentInfor();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvStudentInfor.DataSource = dao.getStudentInfor();
        }
    }
}
