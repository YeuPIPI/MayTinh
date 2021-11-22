using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Cal : Form
    {
        //tb_Result
        Double results = 0;
        String operation = " ";
        bool enter_value = false;
        public Cal()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            if ((tb_Result.Text == "0") || (enter_value))
                tb_Result.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!tb_Result.Text.Contains("."))
                    tb_Result.Text = tb_Result.Text + num.Text;
            }
            else
                tb_Result.Text = tb_Result.Text + num.Text;
        }

        private void bt_Operator(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                operation = b.Text;
                results = Convert.ToDouble(tb_Result.Text);
                enter_value = true;
                labelShow.Text = results + " " + operation;
               
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void bt_Bang_Click(object sender, EventArgs e)
        {
            try
            {

                enter_value = false;
                labelShow.Text = labelShow.Text + " " + tb_Result.Text;
                
                switch (operation)
                {
                    case "+":
                        tb_Result.Text = (results + Double.Parse(tb_Result.Text)).ToString();
                        break;
                    case "-":
                        tb_Result.Text = (results - Double.Parse(tb_Result.Text)).ToString();
                        break;
                    case "X":
                        tb_Result.Text = (results * Double.Parse(tb_Result.Text)).ToString();
                        break;
                    case "/":
                        if (tb_Result.Text.Equals("0"))
                        {
                            tb_Result.Text = results.ToString();
                            MessageBox.Show("dot chia cho 0");
                            break;

                        }
                        else
                        {
                            tb_Result.Text = (results / Convert.ToDouble(tb_Result.Text)).ToString();
                            break;
                        }
                    case "%":
                        if (tb_Result.Text.Equals("0"))
                        {
                            tb_Result.Text = results.ToString();
                            MessageBox.Show("dot chia cho 0");
                            break;
                        }
                        else
                        {
                            tb_Result.Text = (results % Convert.ToDouble(tb_Result.Text)).ToString();
                            break;
                        }
                    case " ":
                        results = 0;
                        tb_Result.Text = "0";
                        break;
                    default:
                        
                        break;
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void bt_ND_Click(object sender, EventArgs e)
        {
            tb_Result.Text = (1 / Convert.ToDouble(tb_Result.Text)).ToString();
            labelShow.Text = "";
        }

        private void bt_Binhphuong_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(tb_Result.Text);
            tb_Result.Text = (a * a).ToString();
            labelShow.Text = "";
        }

        private void bt_canx_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(tb_Result.Text);
            tb_Result.Text = (Math.Sqrt(a)).ToString();
            labelShow.Text = "";
        }

        private void bt_SD_Click(object sender, EventArgs e)
        {
            tb_Result.Text = (Convert.ToDouble(tb_Result.Text) * (-1)).ToString();
            labelShow.Text = "";
        }

        private void bt_Xoa1kytu_Click(object sender, EventArgs e)
        {
            if (tb_Result.Text.Length > 0)
            {
                tb_Result.Text = tb_Result.Text.Remove(tb_Result.Text.Length - 1, 1);
            }
            if (tb_Result.Text == " ")
            {
                tb_Result.Text = "0";
            }
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            try
            {
                results = 0;
                tb_Result.Text = "0";
                labelShow.Text = " ";
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void bt_CE_Click(object sender, EventArgs e)
        {
            if (tb_Result.Text.Length > 0)
            {
                tb_Result.Text = "0";
            }
            if (tb_Result.Text == "")
            {
                tb_Result.Text = "0";
            }
        }

        private void bt_OUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
