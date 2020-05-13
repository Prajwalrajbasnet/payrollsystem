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
using System.Data.Sql;

namespace BackupForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\basne\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\msdbdata.mdf; Integrated Security = True; Connect Timeout = 30;");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from naya where username='" + textBox1.Text + "' and password='" + textBox2.Text + "';", con);
                DataTable ta = new DataTable();
                sda.Fill(ta);
                if (ta.Rows[0][0].ToString() == "1")
                {
                    //MessageBox.Show("It reached here");
                    this.Hide();
                    Form1 obj = new Form1();
                    obj.Show();
                }

                else
                {
                    MessageBox.Show("Enter correct credentials");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
