using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connect sql

            //insert cmd
            SqlCommand cmd = new SqlCommand("Insert into studentInfo values (@id,@Student,@Excellence)", connectionClass1.sqlconnection);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Student", textBox2.Text);
            cmd.Parameters.AddWithValue("@Excellence", textBox3.Text);
            cmd.ExecuteNonQuery();  

            //close connection

            //final message

            //MessageBox.Show("Successfully Inserted ! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // sql query and assigning values
            SqlCommand cmd = new SqlCommand("Update studentInfo set Id = @Id ,Student = @Student ,Excellence = @Excellence",connectionClass1.sqlconnection );
            cmd.Parameters.AddWithValue("@Id",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Student", textBox2.Text);
            cmd.Parameters.AddWithValue("@Excellence", textBox3.Text);
            cmd.ExecuteNonQuery();

            // final message
            //MessageBox.Show("Successfully Updated ! ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sql query for search
            try {
                SqlCommand cmd = new SqlCommand("Select * from studentInfo where Id = @Id ", connectionClass1.sqlconnection);
                cmd.Parameters.AddWithValue("Id", int.Parse(textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }

            //cmd.ExecuteNonQuery();

            //message
            //MessageBox.Show("Successfully  ! ");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // sql query for delete
            SqlCommand cmd = new SqlCommand("Delete studentInfo where Id = @Id ",connectionClass1.sqlconnection );
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            //message
            //MessageBox.Show("Successfully deleted ! ");
        }
    }
}
