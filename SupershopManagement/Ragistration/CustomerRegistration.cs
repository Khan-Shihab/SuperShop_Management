using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupershopManagement.Ragistration
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       

        private void contact_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void C_contactInfo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c_i_name.Text == "" || c_i_gender.Text == "" || c_i_DOB.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                C_information_panel.Visible = false;
                C_contactInfo_panel.Visible = true;
            }

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignupFor signupFor = new SignupFor();
            signupFor.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            C_contactInfo_panel.Visible = false;
            C_information_panel .Visible = true;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (c_i_phone.Text == "" || c_i_email.Text == "" || c_i_address.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if (c_i_phone.Text.Length < 11)
                {
                    MessageBox.Show("Phone number must be 11 digit");
                }
                else
                {
                    C_contactInfo_panel.Visible = false;
                    C_accountCredentialPanel.Visible = true;
                }
            }
           
                       
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (c_a_uname.Text == "" || c_a_pass.Text == "" || c_a_repass.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if (c_a_pass.Text.Length <= 7)
                {
                    MessageBox.Show("Password must be 8 digit");
                }
                else
                {
                    if (c_a_pass.Text != c_a_repass.Text)
                    {
                        MessageBox.Show("Please enter same password");
                    }
                    else
                    {
                        C_accountCredentialPanel.Visible = false;
                        C_Submit_panel.Visible = true;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            C_accountCredentialPanel.Visible = false;
            C_contactInfo_panel .Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            C_Submit_panel.Visible = false;
            C_accountCredentialPanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void C_Submit_panel_Paint(object sender, PaintEventArgs e)
        {

            c_s_name.Text = c_i_name.Text;
            //c_s_nid.Text = e_p_nid.Text;
            c_s_gender.Text = c_i_gender.Text;
            c_s_DOB.Text = c_i_DOB.Text;
            c_s_phone.Text = c_i_phone.Text;
            c_s_email.Text = c_i_email.Text;
            c_s_address.Text = c_i_address.Text;
            c_s_uname.Text = c_a_uname.Text;
            c_s_pass.Text = c_a_pass.Text;
            c_s_repass.Text = c_a_repass.Text;
        }
    }
    
}
