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
    public partial class EmployeRegistration : Form
    {
        public EmployeRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeRegistration_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (e_p_name.Text == "" || e_p_gender.Text == "" || e_p_nid.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if(e_p_nid.Text.Length>10 && e_p_nid.Text.Length < 17)
                {
                    information_panel.Visible = false;
                    contact_panel.Visible = true;
                }
                else
                {
                    MessageBox.Show("NID number should be 11 to 17");
                }
            }
           
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if(e_c_phone.Text == "" || e_c_email.Text == "" || e_c_address.Text == "")    
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if (e_c_phone.Text.Length < 11)
                {
                    MessageBox.Show("Phone number must be 11 digit");
                }
                else
                {
                    contact_panel.Visible = false;
                    E_accountCredential.Visible = true;
                }
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(e_a_uname.Text==""|| e_a_pass.Text == ""||e_a_re_pass.Text=="")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if (e_a_pass.Text.Length <= 7)
                {
                    MessageBox.Show("Password must be 8 digit");
                }
                else
                {
                    if(e_a_pass.Text != e_a_re_pass.Text)
                    {
                        MessageBox.Show("Please enter same password");
                    }
                    else
                    {
                        E_accountCredential.Visible = false;
                        E_submit_panel.Visible = true;
                    }
                }
            }
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            contact_panel.Visible = false;
            information_panel.Visible = true;

        }


        private void button6_Click_2(object sender, EventArgs e)
        {
            E_accountCredential.Visible = false;
            contact_panel.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            E_submit_panel.Visible = false;
            E_accountCredential.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            e_s_name.Text = e_p_name.Text;
            e_s_nid.Text = e_p_nid.Text;
            e_s_gender.Text = e_p_gender.Text;
            e_s_DOB.Text = dateTimePicker1.Text;
            e_s_phone.Text = e_c_phone.Text;
            e_s_email.Text = e_c_email.Text;
            e_s_address.Text = e_c_address.Text;
            e_s_uname.Text = e_a_uname.Text;
            e_s_pass.Text = e_a_pass.Text;
            e_s_retype_pass.Text = e_a_re_pass.Text;
        }
    }
}
