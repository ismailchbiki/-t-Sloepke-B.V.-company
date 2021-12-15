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
    public partial class FormItems : Form
    {

        //id of the selected row
        int id = FormInventory.ItemID;

        Inventory gear;

        public FormItems()
        {
            InitializeComponent();
        }

        //form
        private void FormItems_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            //populating the comboBoxes with enums
            comboBoxItem.DataSource = Enum.GetValues(typeof(ITEMTYPE));

            buttonUpdateItem.Visible = false;

            //in case of a boat update => fill in all the fields
            if (id != 0)
            {
                gear = new Item();
                gear.ID = id;

                //retrieve data of the item to update
                Item item = (Item)InventoryAdministration.GetGearByID(gear);

                //control visibility some items on the form on update click event
                comboBoxItem.Visible = false;
                buttonAddItem.Visible = false;
                buttonUpdateItem.Visible = true;

                //fill in fields with data
                labelItmType.Text = item.ItemType.ToString();
                textBoxCost.Text = item.Cost.ToString();
                textBoxDeposit.Text = item.Deposit.ToString();
                textBoxQuantity.Text = item.Quantity.ToString();
                textBoxRemark.Text = item.Remark;
            }
        }

        //logout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            FormInventory.ItemID = 0;
            login.Show();
            this.Hide();
        }

        //back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSelectOption selectOption = new FormSelectOption();
            FormInventory inventoryForm = new FormInventory();

            // in case of an update event => back to inventory or dashboard
            if (FormInventory.ItemID != 0)
            {
                FormInventory.ItemID = 0;
                inventoryForm.Show();
                this.Hide();
            }
            else
            {
                selectOption.Show();
                this.Hide();
            }
        }

        //add new item
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                //check if all fields are filled
                if (string.IsNullOrEmpty(textBoxCost.Text) || string.IsNullOrEmpty(textBoxQuantity.Text))
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

                    gear = new Item((ITEMTYPE)comboBoxItem.SelectedItem, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    //add item
                    if (InventoryAdministration.AddGear((Item)gear))
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

        //update item
        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                //check if all fields are filled
                if (string.IsNullOrEmpty(textBoxCost.Text) || string.IsNullOrEmpty(textBoxQuantity.Text))
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

                    gear = new Item((ITEMTYPE)comboBoxItem.SelectedItem, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    //update item
                    if (InventoryAdministration.UpdateGear(id, (Item)gear))
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
