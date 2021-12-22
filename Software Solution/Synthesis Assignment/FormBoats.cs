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
    public partial class FormBoats : Form
    {

        string type = null;
        Boat boat;
        InventoryAdministration manageGear;

        public FormBoats()
        {
            InitializeComponent();
            manageGear = new InventoryAdministration();
            boat = new Boat();
        }

        public FormBoats(string bType)
        {
            InitializeComponent();
            manageGear = new InventoryAdministration();
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
                labelBType.Text = ((Boat)manageGear.GetGearByType(boat)).BoatType.ToString();
                textBoxCapacity.Text = ((Boat)manageGear.GetGearByType(boat)).Capacity.ToString();
                textBoxCost.Text = ((Boat)manageGear.GetGearByType(boat)).UnitCost.ToString();
                textBoxDeposit.Text = ((Boat)manageGear.GetGearByType(boat)).Deposit.ToString();
                textBoxQuantity.Text = ((Boat)manageGear.GetGearByType(boat)).Quantity.ToString();
                textBoxRemark.Text = ((Boat)manageGear.GetGearByType(boat)).Remark;
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
                    if (manageGear.AddGear(boat))
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
                    if (manageGear.UpdateGear(boat))
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
