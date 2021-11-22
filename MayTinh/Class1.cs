using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace MayTinh
{
    //Data Source=DESKTOP-057N016\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True
    class Person
    {
        private string Email;
        private string Password;

        public Person(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public Person() { }
        public string Email1 { get => Email; set => Email = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
    class DATA : Form
    {
        public DATA() { }
        public void SELECT(string email , string password)
        {
            try
            {
                string s = @"Data Source=DESKTOP-057N016\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(s))
                {
                    string query = "Select * from DBEP Where email = '" + email + "' and password = '" + password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    if (ds.Rows.Count == 1)
                    {
                        Login form1 = new Login();
                        this.Hide();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ban da nhap sai tai khoan hoac mat khau , co the khong ton tai tai khoan");
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }
        public void REGISTER(string email, string password)
        {
            try
            {
                string s = @"Data Source=DESKTOP-057N016\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(s))
                {
                    if (email != "" && password != "")
                    {
                        bool check = true;
                          string query = "Select * from DBEP Where email = '" + email + "'";
                         SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                         DataTable ds = new DataTable();
                         sda.Fill(ds);
                         if (ds.Rows.Count == 1)
                         {
                            check = false;
                           MessageBox.Show("DA TON TAI TAI KHOAN NAY");
                         }
                        if (check == true)
                        {
                            connection.Open();
                            string sql = "INSERT INTO DBEP(email,password)VALUES (";
                            sql += "N'" + email + "',N'" + password + "')";
                            SqlCommand cmd = new SqlCommand(sql, connection);
                            int v = (int)cmd.ExecuteNonQuery();
                            if (v > 0)
                            {
                                MessageBox.Show("DANG KY THANH CONG");
                            }
                            else
                            {
                                MessageBox.Show("DANG KY THAT BAI LAI BUG ROI BAN TRE");
                            }
                        }
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }
        public void CHANGE_PASSWORD(string email, string password)
        {
            try
            {
                string a = @"Data Source=DESKTOP-057N016\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(a))
                {
                    connection.Open();
                    string query = "UPDATE DBEP SET password = ' " + password + " ' WHERE email = '" + email + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int v = (int)cmd.ExecuteNonQuery();
                    if (v > 0)
                    {
                        MessageBox.Show("THAY DOI THANH CONG");
                    }
                    else
                    {
                        MessageBox.Show("THAY DOI THAT BAI");
                    }
                }
            }
            catch(Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }
    }
}
