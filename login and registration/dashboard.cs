using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace view
{

    public partial class dashboard : Form
    {
        //make rounded
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public dashboard()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);


        }
        //Database linking code
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RRB1RS4;Initial Catalog=DublinBank;Integrated Security=True");
        private SqlCommand cmd = new SqlCommand();

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);


        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalitics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAnalitics.Height;
            PnlNav.Top = BtnAnalitics.Top;
            BtnAnalitics.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void BtnCalendar_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnCalendar.Height;
            PnlNav.Top = BtnCalendar.Top;
            BtnCalendar.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnContact.Height;
            PnlNav.Top = BtnContact.Top;
            BtnContact.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void BtnAnalitics_Leave(object sender, EventArgs e)
        {
            BtnAnalitics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalendar_Leave(object sender, EventArgs e)
        {
            BtnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnContact_Leave(object sender, EventArgs e)
        {
            BtnContact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);

        }
        //Show balance
        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Balance = "SELECT * FROM Customer";

                cmd = new SqlCommand(Balance, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Condition to check matching
                if (reader.Read() == true)
                {
                    //show customer information
                    
                   

                    conn.Close();
                }
                else
                {
                

                 

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Information not found.");
            }
        }


    }
    
}
