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
    public partial class FormPayment : Form
    {
        Quote reservation;
        ProcessQuotePayment processPayment;
        QuoteAdministration manageQuote;

        public FormPayment(Quote quote)
        {
            InitializeComponent();

            this.reservation = quote;
            processPayment = new ProcessQuotePayment();
            manageQuote = new QuoteAdministration();

            if (reservation.DepositStatus == "Done")
            {
                lblDepositStatus.ForeColor = Color.SpringGreen;
                textBoxDeposit.Visible = false;
                buttonDeposit.Visible = false;
            }

            if (reservation.PaymentStatus == "Done")
            {
                lblPaymentStatus.ForeColor = Color.SpringGreen;
                textBoxPayment.Visible = false;
                buttonPay.Visible = false;
            }
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            if (reservation != null)
            {
                lblLastname.Text = reservation.Customer.LastName;
                lblRefNum.Text = reservation.RefNumber;

                lblStartDate.Text = reservation.StartDateTime.ToString("dd/MM/yyyy HH.mm");
                lblEndDate.Text = reservation.EndDateTime.ToString("dd/MM/yyyy HH.mm");
                lblLocation.Text = reservation.Location;
                lblDeposit.Text = reservation.Deposit.ToString();
                lblTotalPrice.Text = reservation.TotalPrice.ToString();
                lblBoat.Text = reservation.Boat.BoatType;
                lblBoatQuantity.Text = reservation.Boat.Quantity.ToString();
                lblItem.Text = reservation.Item.ItemType;
                lblItemQuantity.Text = reservation.Item.Quantity.ToString();

                lblDepositStatus.Text = reservation.DepositStatus;
                lblPaymentStatus.Text = reservation.PaymentStatus;
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
            if (string.IsNullOrEmpty(textBoxDeposit.Text))
            {
                MessageBox.Show("Please fill in the deposit field");
            }
            else if (Verify.ContainLetters(textBoxDeposit.Text))
            {
                MessageBox.Show("Deposit cannot conatin letters");
            }

            //code to submit deposit
            if (reservation.Deposit > Convert.ToDouble(textBoxDeposit.Text))
            {
                MessageBox.Show("Insufficient deposit amount");
            }
            else
            {
                if (processPayment.SettleDeposit(reservation))
                {
                    double result = Convert.ToDouble(textBoxDeposit.Text) - reservation.Deposit;
                    MessageBox.Show("Deposit submitted successfully\nAn amount of " + result + " should be returned to the customer");

                    Quote booking = new Quote();
                    booking = manageQuote.GetQuoteByID(reservation);

                    FormPayment refresh = new FormPayment(booking);
                    refresh.Show();
                    this.Hide();
                }
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPayment.Text))
            {
                MessageBox.Show("Please fill in the payment field");
            }
            else if (Verify.ContainLetters(textBoxPayment.Text))
            {
                MessageBox.Show("payment cannot conatin letters");
            }

            //code to submit deposit
            if (reservation.TotalPrice > Convert.ToDouble(textBoxPayment.Text))
            {
                MessageBox.Show("Insufficient payment amount");
            }
            else
            {
                if (processPayment.SettlePayment(reservation))
                {
                    double result = Convert.ToDouble(textBoxPayment.Text) - reservation.TotalPrice;
                    MessageBox.Show("Payment submitted successfully\nAn amount of " + result + " should be returned to the customer");

                    FormFindCustomer previousForm = new FormFindCustomer();
                    previousForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
