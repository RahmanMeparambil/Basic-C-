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

namespace WindowsFormsApplication6.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            pf_UpdateButton.Visible = false;
            display_data();
            pf_slnoLabel.Enabled = true;
            pf_slnoTextbox.Enabled = false;

            // DISABLE BOTH DELETE AND EDIT (Enable after find)
            pf_DeleteButton.Enabled = false;
            pf_EditButton.Enabled = false;

        }


        private void FormProduct_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'testDbDataSet.ProductRegistration' table. You can move, or remove it, as needed.
                this.productRegistrationTableAdapter.Fill(this.testDbDataSet.ProductRegistration);
                refreshSearch();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }




        /* FORM MAIN FUNCTIONs 
         * save
         * update
         * delete
         * clear
         * search
         */

        // editing function
        private void pf_EditButton_Click(object sender, EventArgs e)
        {

            // value
            // string itemCode = this.itemCode.Text;

            // check if the itemcode is already present in the table
            // SqlCommand cmd = new SqlCommand("Select ItemCode From ProductRegistration where ItemCode = '" + itemCode + "'",ConnectionClass.sqlconnection);

            /* if(itemCode =="")
             {
                 MessageBox.Show("Itemcode should not be empty !");
             }*/

            // this.itemCode.Enabled = false;
            activeFunctionality();
            pf_slnoTextbox.Enabled = true;
            pf_UpdateButton.Visible = true;

        }




        // update function
        private void pf_UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // return if the boxes are emty 
                if (itemCode.Text == "" || itemName.Text == "")
                {
                    return;
                }
               
                // verify the slno exists
                int Slno = Convert.ToInt32(pf_slnoTextbox.Text);
                SqlCommand cmd = new SqlCommand("Select Slno From ProductRegistration where Slno = '" + Slno + "'", ConnectionClass.sqlconnection);

                // sql update command
                if ((int)cmd.ExecuteScalar() == Slno)
                {
                    SqlCommand UpdateItemName = new SqlCommand("Update ProductRegistration set ItemName ='" + this.itemName.Text + "'where Slno ='" + Slno + "'", ConnectionClass.sqlconnection);
                    SqlCommand UpdateItemCode = new SqlCommand("Update ProductRegistration set ItemCode ='" + this.itemCode.Text + "'where Slno ='" + Slno + "'", ConnectionClass.sqlconnection);
                    UpdateItemName.ExecuteNonQuery();
                    UpdateItemCode.ExecuteNonQuery();
                }


                // hide updateButton & disable slnoTextbox
                pf_UpdateButton.Visible = false;
                pf_slnoTextbox.Enabled = false;

                // enable save , clear and disable del , edit
                sherakSwitch();


                // rituals
                pf_ClearText();
                display_data();
                refreshSearch();
                /* stored procedure method
                 SqlCommand cmd = new SqlCommand("exec UpdateProduct");
                }

                */
            }
            catch (Exception NullRefereceException)
            {
                MessageBox.Show("item not registered !");
            }
        }




        // find function
        private void pf_FindButton_Click(object sender, EventArgs e)
        {
            activeFunctionality();
            try 
            {
                string itemNametxt = this.itemName.Text;

                if (itemNametxt == "")
                {
                    return;
                }

                // sql commands
                SqlCommand get_slno = new SqlCommand("Select SlNo from ProductRegistration where itemName = '" + itemNametxt + "'", ConnectionClass.sqlconnection);
                SqlCommand get_itemCode = new SqlCommand("Select ItemCode from ProductRegistration where itemName = '" + itemNametxt + "'", ConnectionClass.sqlconnection);
                
                // variables
                int slnotxt = (int)get_slno.ExecuteScalar();
                string itemCodetxt = (string)get_itemCode.ExecuteScalar();

                // assigning the value
                this.itemCode.Text = itemCodetxt;
                this.pf_slnoTextbox.Text = slnotxt.ToString();

                // enable both edit and delete
                pf_EditButton.Enabled = true;
                pf_DeleteButton.Enabled = true;
                pf_SaveButton.Enabled = false;
                pf_ClearButton.Enabled = false;

            }
            catch (Exception NullRefereceException)
            {
                MessageBox.Show("Name does'nt exist !");
            }

        }





        // clear function
        private void pf_ClearButton_Click(object sender, EventArgs e)
        {
            pf_ClearText();
        }





        // insert function
        private void pf_SaveButton_Click(object sender, EventArgs e)
        {
            activeFunctionality();
            try
            {
                // get values from the boxes
                string itemCode = this.itemCode.Text;
                string itemName = this.itemName.Text;


                //check if the element is already exist
                SqlCommand itemName_exist = new SqlCommand("Select ItemName From ProductRegistration where ItemCode = '" + itemCode + "'", ConnectionClass.sqlconnection);
                SqlCommand itemCode_exist = new SqlCommand("Select ItemCode From ProductRegistration where ItemName = '" + itemName + "'", ConnectionClass.sqlconnection);

                SqlDataAdapter da = new SqlDataAdapter(itemName_exist);
                SqlDataAdapter da2 = new SqlDataAdapter(itemCode_exist);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da2.Fill(dt);

                // boxes should not be empty 
                // item name should be unique
                // ((string)itemcode_exist.ExecuteScalar() == )  ((string)itemName_exist.ExecuteScalar() == itemName)
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Item code/name already exist ! ");
                }
                else if (pf_UpdateButton.Visible == true)
                {
                    return;
                }
                else if (itemName == "")
                {
                    MessageBox.Show("Enter item name ! ");
                }
                else if (itemCode == "")
                {
                    MessageBox.Show("Enter item code !");
                }
                else
                {

                    //MessageBox.Show((string)itemCode_exist.ExecuteScalar());

                    // insert into table
                    /*
                    SqlCommand cmd = new SqlCommand("Insert into ProductRegistration (ItemCode , ItemName) values(@ItemCode,@ItemName)",ConnectionClass.sqlconnection);
                    cmd.Parameters.AddWithValue("@ItemCode", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ItemName", textBox2.Text); 
                    cmd.ExecuteNonQuery();
                    display_data();
                    */

                    //insert into table using db Stored Procedure
                    SqlCommand cmd = new SqlCommand("exec insertProduct '" + itemCode + "','" + itemName + "'", ConnectionClass.sqlconnection);
                    cmd.ExecuteNonQuery();

                    display_data();
                    pf_ClearText();
                    refreshSearch();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }




        // delete function
        private void pf_DeleteButton_Click(object sender, EventArgs e)
        {
            activeFunctionality();
            if (pf_UpdateButton.Visible == true)
            {
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Delete '" + itemName.Text + "'", ConnectionClass.sqlconnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("row deleted !");
                display_data();
                refreshSearch();
                pf_ClearText();
                sherakSwitch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }




        /* Helper functions :
         * 
         * includes search refresh function -refresh the search items
         * update slno - update the slno 
         * clear itemName and itemCode - clear function 
         * display the data - data inside the grid from sql table
         * active functionality - activates the current pressed function
         * 
        */

        private void refreshSearch()
        {
            SqlCommand cmd = new SqlCommand("exec sp_RefreshSearch", ConnectionClass.sqlconnection);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                collection.Add(dr["ItemName"].ToString());
            }
            itemName.AutoCompleteMode = AutoCompleteMode.Suggest;
            itemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            itemName.AutoCompleteCustomSource = collection;

            dr.Close();
        }





        // update slno
        private void updateSlno()
        {
            try
            {
                /*
                    SqlCommand cmd = new SqlCommand("Select count (Slno) from ProductRegistration", ConnectionClass.sqlconnection);
                    SqlCommand cmd = new SqlCommand("Select Top(1) Slno from ProductRegistration sort by Slno desc", ConnectionClass.sqlconnection);
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    i++;
                    pf_slnoTextbox.Text = i.ToString();
                */
                SqlCommand cmd = new SqlCommand("exec sp_UpdateSlno", ConnectionClass.sqlconnection);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                i++;
                pf_slnoTextbox.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }




        // active functionality
        private void activeFunctionality()
        {
            pf_UpdateButton.Visible = false;
            pf_slnoTextbox.Enabled = false;
            updateSlno();
        }




        // clear function
        private void pf_ClearText()
        {
            this.itemCode.Text = "";
            this.itemName.Text = "";
            updateSlno();
        }




        // display 
        private void display_data()
        {
            try
            {
                // display function
                //SqlCommand cmd = new SqlCommand("Select * from ProductRegistration", ConnectionClass.sqlconnection);
                SqlCommand cmd = new SqlCommand("exec sp_ListAll", ConnectionClass.sqlconnection);
                cmd.ExecuteNonQuery();

                // update slno
                updateSlno();
                /*
                 SqlCommand cmd = new SqlCommand("exec listAll", ConnectionClass.sqlconnection);
                cmd.ExecuteNonQuery();
                */

                // show data table
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        // sherak switch
        private void sherakSwitch()
        {
            pf_EditButton.Enabled = false;
            pf_DeleteButton.Enabled = false;
            pf_SaveButton.Enabled = true;
            pf_ClearButton.Enabled = true;
        }
    } 
}
