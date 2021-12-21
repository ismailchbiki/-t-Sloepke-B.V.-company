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
    public partial class FormPayment : Form
    {
        Quote quote;

        public FormPayment(Quote quote)
        {
            InitializeComponent();

            this.quote = quote;

            if (quote.DepositStatus == "Done")
            {
                lblDepositStatus.ForeColor = Color.SpringGreen;
            }

            if (quote.PaymentStatus == "Done")
            {
                lblPaymentStatus.ForeColor = Color.SpringGreen;
            }
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            if (quote != null)
            {
                lblLastname.Text = quote.Customer.LastName;
                lblRefNum.Text = quote.RefNumber;

                lblStartDate.Text = quote.StartDateTime.ToString("dd/MM/yyyy HH.mm");
                lblEndDate.Text = quote.EndDateTime.ToString("dd/MM/yyyy HH.mm");
                lblLocation.Text = quote.Location;
                lblDeposit.Text = quote.Deposit.ToString();
                lblTotalPrice.Text = quote.TotalPrice.ToString();
                lblBoat.Text = quote.Boat.BoatType;
                lblBoatQuantity.Text = quote.Boat.Quantity.ToString();
                lblItem.Text = quote.Item.ItemType;
                lblItemQuantity.Text = quote.Item.Quantity.ToString();

                lblDepositStatus.Text = quote.DepositStatus;
                lblPaymentStatus.Text = quote.PaymentStatus;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormFindCustomer customer = new FormFindCustomer();

            customer.Show();
            this.Hide();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {

        }
    }
}
