﻿using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Classes;
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
        Validation validate;

        public FormLogin()
        {
            InitializeComponent();

            validate = new Validation();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = "Ismail";
            string password = "123";

            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Username and password are required fields");
            }
            else
            {
                //method here to validate username fields (not a number)
                if (validate.ContainNumbers(textBoxUsername.Text))
                {
                    MessageBox.Show("Username cannot contain numbers");
                }

                else if (textBoxUsername.Text == username && textBoxPassword.Text == password)
                {
                    FormDashboard dashboard = new FormDashboard();

                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }
    }
}
