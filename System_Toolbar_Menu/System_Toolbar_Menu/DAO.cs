using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;

namespace System_Toolbar_Menu
{
    class DAO
    {
        public SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Manage"].ToString();
            return new SqlConnection(strCon);
        }
        

        /// <summary>
        ///  User Information
        /// </summary>
        /// <returns></returns>
        public DataTable getDataUser()
        {
            
                string sql = "select * from UserInfor";
                SqlCommand cmd = new SqlCommand(sql, getConnection());
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                //DataTable dtb1 = new DataTable();
                DataSet ds = new DataSet(); // database Cache
                ds.Clear();
                da.Fill(ds);
                return ds.Tables[0];
        }
        public DataTable getAccount(string user, string pass)
        {
            string sql = "select * from UserInfor where Username='" + user + "' and Password ='" + pass + "' ";
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // database Cache
            da.Fill(ds);
            return ds.Tables[0];
        }
        
        public void deleteUser(string uid)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();
                string sql = "delete from UserInfor where CodeID = " + uid + "";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

        }
        public void insertUser(string username, string password, string fullname, string address, string email)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();
                string sql = "insert into UserInfor values('" + username + "','" + password + "','" + fullname + "','" + address + "','" + email + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }  
        }
        public void updateUser(string username, string password, string fullname, string address, string email, string id)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();
                string sql = "update UserInfor set Username = '" + username + "', Password ='" + password + "'," +
                    "FullName = '" + fullname + "',Address = '" + address + "',Email = '" + email + "' " +
                    "where CodeID = " + id + "";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
          
        }
        // Student Information
        public DataTable getStudentInfor()
        {
            string sql = "select * from StudentInfo";
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            //DataTable dtb1 = new DataTable();
            DataSet ds = new DataSet(); // database Cache
            ds.Clear();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void deleteStudent(string sid)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();
                string sql = "delete from StudentInfo where Sid = " + sid + "";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

        }
        public void insertStudent(string Fname, string Lname, string dob, string address, string phone, string email, string religion, string nation, string gender, string Slanguage, string images)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();
                string sql = "insert into StudentInfo values('" + Fname + "','" + Lname + "','" + dob + "','" + address + "','" + phone + "','"+email+"','"+religion+"','"+nation+"','"+gender+"','"+Slanguage+"','"+images+"')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
        public void updateStudent(string Fname, string Lname, string dob, string address, string phone, string email, string religion, string nation, string gender, string Slanguage, string images, string sid)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();
                string sql = "update StudentInfo set FirstName = '" + Fname + "', LastName ='" + Lname + "'," +
                    "Dob = '" + dob + "',Address = '" + address + "',Phone = '"+phone+"',Email = '" + email + "',Religion = '"+religion+"'," +
                    "Nation = '"+nation+"',Gender = "+gender+",SLanguage = '"+Slanguage+"',Images = '"+images+"' " +
                    "where Sid = " + sid + "";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

        }

 
        // Student Family 
        //public DataTable getFamily(string pid)
        //{
        //    string sql = "  select FatherName,FaAddress,FaCareer,MotherName,MoAddress,MoCareer from StudentInfo,StudentFamily where StudentInfo.Sid = StudentFamily.Pid and sid = " + pid + "";
        //    SqlCommand cmd = new SqlCommand(sql, getConnection());
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    //DataTable dtb1 = new DataTable();
        //    DataSet ds = new DataSet(); // database Cache
        //    ds.Clear();
        //    da.Fill(ds);
            
        //    return ds.Tables[0];
        //}

    }
}
