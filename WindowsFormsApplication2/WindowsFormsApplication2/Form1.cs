using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text =="")
            {
                MessageBox.Show("enter username !");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("enter password !");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * from loginInfo where username = @username and password = @password", connectionClass1.sqlconnection);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Connected ! ");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Not Connected !");
                }

            }


           
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            connectionClass1.Con = @"Data Source=RKO-PC\SQLEXPRESS;Initial Catalog=TestDb;User id=sa;Password=997755;";
            connectionClass1.OpenConnection();
        }
    }
}
