using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Login : Form
    {
        //Data Source=DESKTOP-057N016\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True      
        List<Person> admin = new List<Person>();
        public Login()
        {
            InitializeComponent();

        }
        private void bt_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Person ta = new Person();
                ta.Email1 = txt_Email.Text;
                ta.Password1 = txt_Password.Text;
                admin.Add(ta);
                DATA ass = new DATA();
                ass.SELECT(ta.Email1, ta.Password1);              
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }           
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {                 
            try
            {
                Person ta = new Person();
                ta.Email1 = txt_Email.Text;
                ta.Password1 = txt_Password.Text;
                admin.Add(ta);
                DATA ass = new DATA();
                ass.REGISTER(ta.Email1, ta.Password1);
                this.Hide();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message );
                
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string s = @"Data Source=DESKTOP-057N016\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(s);
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }
        private void bt_ChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                Person ta = new Person();
                ta.Email1 = txt_Email.Text;
                ta.Password1 = txt_Password.Text;
                admin.Add(ta);
                DATA ass = new DATA();
                ass.CHANGE_PASSWORD(ta.Email1, ta.Password1);                
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }
    }
}
