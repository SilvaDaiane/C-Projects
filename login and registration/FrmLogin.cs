using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace view
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
           
        }
        //Database linking code
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RRB1RS4;Initial Catalog=DublinBank;Integrated Security=True");
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();

        //LOGIN button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string login = "SELECT * FROM Login WHERE AccountNo = '" + txtAccountNumber.Text + "' and Password = '" + txtPassword.Text + "'";

                cmd = new SqlCommand(login, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Condition to check matching
                if (reader.Read() == true)
                {
                    //show customer information
                    new dashboard().Show();
                    this.Hide();

                    conn.Close();
                }
                else
                {
                    //error message
                    MessageBox.Show("Invalid Account Number or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //reset the text boxes             
                    txtAccountNumber.Text = "";
                    txtPassword.Text = "";
                    txtAccountNumber.Focus();

                }

            }catch (SqlException ex) 
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error connecting database");
            }
        }
        //Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            //reset the text boxes 
            txtAccountNumber.Text = "";
            txtPassword.Text = "";
            txtAccountNumber.Focus();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                //if checked show password               
                txtPassword.PasswordChar = '\0';
                
            }
            else
            {
                //otherwise bullet points to hide password
                txtPassword.PasswordChar = '•';
           
            }

        }
        //Create an account button, change form to register
        private void label6_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }
    }
}
