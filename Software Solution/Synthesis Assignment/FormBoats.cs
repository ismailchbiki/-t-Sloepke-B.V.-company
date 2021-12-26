using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Administration;
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
    /// <summary>
    /// The inversion of control:
    /// the infrastructure (UI Method) injects the logic class with an instance of the needed service class
    /// </summary>
    public partial class FormBoats : Form
    {
        /// <summary>
        /// the infrastructure (UI Method) injects the logic class with an instance of the needed service class
        /// </summary>
        /// new DALBoat(): an instance of the lower level object (service class)
        /// new BoatManagement(): an instance of the higher level object (client class)

        string type = null;
        Boat boat;
        IBoatManagement manageBoats;

        public FormBoats()
        {
            InitializeComponent();
            //dependency injection
            manageBoats = new BoatManagement(new DALBoat());
            boat = new Boat();
        }

        public FormBoats(string bType)
        {
            InitializeComponent();
            //dependency injection
            manageBoats = new BoatManagement(new DALBoat());
            boat = new Boat();
            this.type = bType;
        }

        //form
        private void FormAddBoat_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            buttonUpdateBoat.Visible = false;

            //in case of a boat update => fill in all the fields
            if (type != null)
            {
                
                textBoxBoatType.Visible = false;
                buttonAddBoat.Visible = false;
                buttonUpdateBoat.Visible = true;

                //fill in fields with data
                boat = new Boat(type);
                boat = manageBoats.GetBoatByType(boat);
                labelBType.Text = boat.BoatType.ToString();
                textBoxCapacity.Text = boat.Capacity.ToString();
                textBoxCost.Text = boat.UnitCost.ToString();
                textBoxDeposit.Text = boat.Deposit.ToString();
                textBoxQuantity.Text = boat.Quantity.ToString();
                textBoxRemark.Text = boat.Remark;
            }
        }
        
        //logout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            type = null;
            login.Show();
            this.Hide();
        }

        //go back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSelectOption selectOption = new FormSelectOption();
            FormInventory inventoryForm = new FormInventory();

            // in case of an update event => back to inventory or dashboard
            if (type != null)
            {
                type = null;
                inventoryForm.Show();
                this.Hide();
            }
            else
            {
                selectOption.Show();
                this.Hide();
            }
        }

        //add new boat
        private void buttonAddBoat_Click(object sender, EventArgs e)
        {
            try
            {
                //check if all fields are filled
                if (string.IsNullOrEmpty(textBoxCost.Text) || string.IsNullOrEmpty(textBoxCapacity.Text) ||
                    string.IsNullOrEmpty(textBoxDeposit.Text) || string.IsNullOrEmpty(textBoxQuantity.Text)
                    || string.IsNullOrEmpty(textBoxBoatType.Text))
                {
                    MessageBox.Show(MyMessage.AllfieldsAreRequired);
                }

                //prevent letters input for numbers
                else if (Verify.ContainLetters(textBoxCost.Text) || Verify.ContainLetters(textBoxDeposit.Text)
                    || Verify.ContainLetters(textBoxQuantity.Text))
                {
                    MessageBox.Show(MyMessage.GearInfoLettersUnallowed);
                }

                else
                {
                    boat = new Boat(textBoxBoatType.Text, textBoxCapacity.Text, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    // add boat
                    if (manageBoats.AddBoat(boat))
                    {
                        MessageBox.Show(MyMessage.SuccessfulSaving);
                    }
                    else
                    {
                        MessageBox.Show(MyMessage.UnsuccessfulSaving);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //update boat
        private void buttonUpdateBoat_Click(object sender, EventArgs e)
        {
            try
            {
                //check if all fields are filled
                if (string.IsNullOrEmpty(textBoxCost.Text) || string.IsNullOrEmpty(textBoxCapacity.Text) ||
                    string.IsNullOrEmpty(textBoxDeposit.Text) || string.IsNullOrEmpty(textBoxQuantity.Text))
                {
                    MessageBox.Show(MyMessage.AllfieldsAreRequired);
                }

                //prevent letters input
                else if (Verify.ContainLetters(textBoxCost.Text) || Verify.ContainLetters(textBoxDeposit.Text)
                    || Verify.ContainLetters(textBoxQuantity.Text))
                {
                    MessageBox.Show(MyMessage.GearInfoLettersUnallowed);
                }

                else
                {

                    boat = new Boat(type, textBoxCapacity.Text, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    //update boat
                    if (manageBoats.UpdateBoat(boat))
                    {
                        MessageBox.Show(MyMessage.SuccessfulUpdate);
                        FormInventory inventoryForm = new FormInventory();

                        inventoryForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(MyMessage.UnsuccessfulUpdate);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
