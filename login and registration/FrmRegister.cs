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

//problem to read

namespace view
{
    public partial class FormRegister : Form
    {
       
        public FormRegister()
        {
            InitializeComponent();


        }
        //Database linking code
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RRB1RS4;Initial Catalog=DublinBank;Integrated Security=True");
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();

        //REGISTER button
        private void button1_Click_1(object sender, EventArgs e )
        {
            conn.Open();
            string customer = "SELECT * FROM Customer WHERE AccountNo = '" + txtAccountNumber.Text + "' and Name = '" + txtUsername.Text + "'";

            cmd = new SqlCommand(customer, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            //Condition to check matching
            if (reader.Read() == false || txtUsername.Text == "" || txtAccountNumber.Text == "" || txtPassword.Text == "" || txtConPassword.Text == "")
            {
                MessageBox.Show("Please check fields", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
            }
            

            //if password match insert information
            else if (txtPassword.Text == txtConPassword.Text)
            {
                reader.Close(); //conn.Open();
                string register = "INSERT INTO Login VALUES ('" + txtAccountNumber.Text + "', '" + txtPassword.Text + "')";
                cmd = new SqlCommand(register, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();

                //set the field to empty
                txtUsername.Text = "";
                txtAccountNumber.Text = "";
                txtPassword.Text = "";
                txtConPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();
            }
            conn.Close();



        }
        //check to show password
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                //if checked show password
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                //otherwise bullet points to hide password
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }
        //Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtAccountNumber.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtUsername.Focus();

        }
        //Back to login
        private void label6_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
  
            
        }
    }
}
