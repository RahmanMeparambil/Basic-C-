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

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        // fields
        private Button currentButton;
        private Form activeForm;

        // constructor
        public Form1()
        {
            InitializeComponent();

            // init connection
            ConnectionClass.Con = @"Data Source=RKO-PC\SQLEXPRESS;Initial Catalog=TestDb;User id=sa;Password=997755;";
            ConnectionClass.OpenConnection();

            // no close button at main menu
            closeButton.Visible = false;

            /* remove border
            this.Text = String.Empty;
            this.ControlBox = false;*/

        }

        /* HELPER FUNCTIONS
            * Reset : reset all the selected buttons
            * Activate Button : activate the button on press
            * Disable Button : disable the previously pressed button
            * Child Form : form inside the form function
        */
        private void Reset()
        {
            DisableButton();
            panelTitleBartxt.Text = @"Home";
            currentButton = null;
            closeButton.Visible = false;
        }

        
        private void ActivateButton(object btnSender)
        {
            // changes the color of the button in the left panel when pressed
            if (btnSender != null)
            {
                DisableButton();
                currentButton = (Button)btnSender;
                currentButton.BackColor = Color.Red;
                panelTitleBartxt.Text = currentButton.Text;
                closeButton.Visible = true;
            }
        }

        private void DisableButton()
        {
            // remove the previously activated button
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                }
            }
        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            // create a form inside the form
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        

        /* BUTTON ACTIVITIES
             * products button
             * purchase button
             * sales button
             * close button
        */
        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduct(),sender);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPurchase(), sender);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSales(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // close the form and disable the button
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            Reset();
        }

    }
}
