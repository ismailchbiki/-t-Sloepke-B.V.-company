using SynthesisAssignment.Models.Administration;
using SynthesisAssignment.Models.Classes;
using SynthesisAssignment.MyClasses.Classes;
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
    public partial class FormFindCustomer : Form
    {

        Quote quote;
        QuoteAdministration manageQuote;

        public FormFindCustomer()
        {
            InitializeComponent();

            quote = new Quote();
            manageQuote = new QuoteAdministration();
        }

        private void FormDeposit_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDashboard formDash = new FormDashboard();

            formDash.Show();
            this.Hide();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            //validate fields
            if (string.IsNullOrEmpty(textBoxLastName.Text) ||
                string.IsNullOrEmpty(textBoxRefNum.Text))
            {
                MessageBox.Show("Please fill in the fields");
            }

            else if (Verify.ContainNumbers(textBoxLastName.Text))
            {
                MessageBox.Show("Last name cannot contain numbers");
            }

            //search for the typed quote
            quote.Customer.LastName = textBoxLastName.Text;
            quote.RefNumber = (textBoxRefNum.Text);
            quote = manageQuote.GetQuoteByID(quote);
            

            if (quote.Boat.BoatType != null)
            {
                FormPayment payment = new FormPayment(quote);

                payment.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("No reservation is found");
            }
        }
    }
}
