using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Classes;
using SynthesisAssignment.Models.Enums;
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

        Inventory gear;
        InventoryAdministration manageGear;

        public FormBoats()
        {
            InitializeComponent();
            manageGear = new InventoryAdministration();
            gear = new Boat();
        }

        public FormBoats(Inventory gear)
        {
            InitializeComponent();
            manageGear = new InventoryAdministration();
            this.gear = gear;
        }

        //form
        private void FormAddBoat_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            //populating the comboBoxes with enums
            comboBoxBoatType.DataSource = Enum.GetValues(typeof(BOATTYPE));
            comboBoxCapacity.DataSource = Enum.GetValues(typeof(CAPACITY));

            buttonUpdateBoat.Visible = false;

            //in case of a boat update => fill in all the fields
            if (gear.ID != 0)
            {

                //control visibility some items on the form on update click event
                comboBoxBoatType.Visible = false;
                buttonAddBoat.Visible = false;
                buttonUpdateBoat.Visible = true;

                //fill in fields with data
                labelBType.Text = ((Boat)manageGear.GetGearByID(gear)).BoatType.ToString();
                comboBoxCapacity.Text = ((Boat)manageGear.GetGearByID(gear)).Capacity.ToString();
                textBoxCost.Text = ((Boat)manageGear.GetGearByID(gear)).Cost.ToString();
                textBoxDeposit.Text = ((Boat)manageGear.GetGearByID(gear)).Deposit.ToString();
                textBoxQuantity.Text = ((Boat)manageGear.GetGearByID(gear)).Quantity.ToString();
                textBoxRemark.Text = ((Boat)manageGear.GetGearByID(gear)).Remark;
            }
        }
        
        //logout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        //go back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSelectOption selectOption = new FormSelectOption();
            FormInventory inventoryForm = new FormInventory();

            // in case of an update event => back to inventory or dashboard
            if (gear.ID != 0)
            {
                gear = new Boat();
                gear = new Item();
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
                if (string.IsNullOrEmpty(textBoxCost.Text) || string.IsNullOrEmpty(textBoxDeposit.Text) ||
                    string.IsNullOrEmpty(textBoxQuantity.Text) || string.IsNullOrEmpty(textBoxRemark.Text))
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
                    gear = new Boat((BOATTYPE)comboBoxBoatType.SelectedItem,
                        (CAPACITY)comboBoxCapacity.SelectedItem, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    // add boat
                    if (manageGear.AddGear(gear))
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
                if (string.IsNullOrEmpty(textBoxCost.Text) || string.IsNullOrEmpty(textBoxDeposit.Text) ||
                    string.IsNullOrEmpty(textBoxQuantity.Text) || string.IsNullOrEmpty(textBoxRemark.Text))
                {
                    MessageBox.Show(MyMessage.AllfieldsAreRequired);
                }

                else if (Verify.ContainLetters(textBoxCost.Text) || Verify.ContainLetters(textBoxDeposit.Text)
                    || Verify.ContainLetters(textBoxQuantity.Text))
                {
                    MessageBox.Show(MyMessage.GearInfoLettersUnallowed);
                }

                else
                {

                    gear = new Boat(gear.ID, (BOATTYPE)comboBoxBoatType.SelectedItem,
                        (CAPACITY)comboBoxCapacity.SelectedItem, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    //update boat
                    if (manageGear.UpdateGear((Boat)gear))
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
