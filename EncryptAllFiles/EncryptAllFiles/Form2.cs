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
using SplashScreen;
using System.Threading;

namespace EncryptAllFiles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Use Admin as username with password pass123 to log in
        //Also make sure to refresh the data connections in the Server Explorer

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SplashStart()
        {
            Application.Run(new SplashScreen.Form1());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data.mdf;Integrated Security=True;Connect Timeout = 30");
            //C:\Users\User\Desktop\CMPG215_EncryptionProgram
            SqlDataAdapter ad = new SqlDataAdapter("Select Count (*) From [Table] where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Thread t = new Thread(new ThreadStart(SplashStart));
                t.Start();
                Thread.Sleep(5000);
                t.Abort();
                this.WindowState = FormWindowState.Normal;
                Form1 Form = new Form1();
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
    }
}
   
