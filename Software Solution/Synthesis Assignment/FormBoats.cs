using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Classes;
using SynthesisAssignment.Models.Enums;
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

        //To get the id of the selected row (in case of an update request)
        int id = FormInventory.BoatID;

        Inventory gear;
        InventoryAdministration gearManager;
        Validation validate;
        MessageInventoryGuide message;

        public FormBoats()
        {
            InitializeComponent();

            gearManager = new InventoryAdministration();
            validate = new Validation();
            message = new MessageInventoryGuide();
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
            if (id != 0)
            {
                gear = new Boat();
                gear.ID = id;

                //retrieve data of the item to update
                Boat b = (Boat)gearManager.GetGearByID(gear);

                //control visibility some items on the form on update click event
                comboBoxBoatType.Visible = false;
                buttonAddBoat.Visible = false;
                buttonUpdateBoat.Visible = true;

                //fill in fields with data
                labelBType.Text = b.BoatType.ToString();
                comboBoxCapacity.Text = b.Capacity.ToString();
                textBoxCost.Text = b.Cost.ToString();
                textBoxDeposit.Text = b.Deposit.ToString();
                textBoxQuantity.Text = b.Quantity.ToString();
                textBoxRemark.Text = b.Remark;
            }
        }
        
        //logout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            FormInventory.BoatID = 0;
            login.Show();
            this.Hide();
        }

        //go back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSelectOption selectOption = new FormSelectOption();
            FormInventory inventoryForm = new FormInventory();

            // in case of an update event => back to inventory or dashboard
            if (FormInventory.BoatID != 0)
            {
                FormInventory.BoatID = 0;
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
                    MessageBox.Show(message.EmptyFieldsErrorMessage());
                }

                else if (validate.ContainLetters(textBoxCost.Text) || validate.ContainLetters(textBoxDeposit.Text)
                    || validate.ContainLetters(textBoxQuantity.Text))
                {
                    MessageBox.Show(message.LettersNotAllowedErrorMessage()) ;
                }

                else
                {

                    gear = new Boat((BOATTYPE)comboBoxBoatType.SelectedItem,
                        (CAPACITY)comboBoxCapacity.SelectedItem, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    // add boat
                    if (!gearManager.AddGear(gear))
                    {
                        MessageBox.Show(message.UnsuccessfulAddingMessage());
                    }
                    else
                    {
                        MessageBox.Show(message.SuccessfulAddingMessage());
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
                    MessageBox.Show(message.EmptyFieldsErrorMessage());
                }

                else if (validate.ContainLetters(textBoxCost.Text) || validate.ContainLetters(textBoxDeposit.Text)
                    || validate.ContainLetters(textBoxQuantity.Text))
                {
                    MessageBox.Show(message.LettersNotAllowedErrorMessage());
                }

                else
                {

                    gear = new Boat((BOATTYPE)comboBoxBoatType.SelectedItem,
                        (CAPACITY)comboBoxCapacity.SelectedItem, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    //update boat
                    if (!gearManager.UpdateGear(id, (Boat)gear))
                    {
                        MessageBox.Show(message.UnsuccessfulUpdateMessage());
                    }
                    else
                    {
                        MessageBox.Show(message.SuccessfulUpdateMessage());
                        FormInventory inventoryForm = new FormInventory();

                        inventoryForm.Show();
                        this.Hide();
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
