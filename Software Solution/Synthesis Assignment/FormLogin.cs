using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Classes;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthesis_Assignment
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        //show and hide password
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        //login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = "Ismail";
            string password = "123";

            try
            {
                if (string.IsNullOrEmpty(textBoxUsername.Text))
                {
                    MessageBox.Show(MyMessage.UsernameRequired);
                }
                else if (string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    MessageBox.Show(MyMessage.PasswordRequired);
                }
                else
                {
                    //method here to validate username fields (not a number)
                    if (Verify.ContainNumbers(textBoxUsername.Text))
                    {
                        MessageBox.Show(MyMessage.UsernameNumbersUnallowed);
                    }

                    else if (textBoxUsername.Text == username && textBoxPassword.Text == password)
                    {
                        FormDashboard dashboard = new FormDashboard();

                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(MyMessage.IncorrectCredentials);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
