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
    public partial class FormItems : Form
    {

        string type = null;
        Item item;
        IItemManagement manageItems;

        public FormItems()
        {
            InitializeComponent();
            manageItems = new ItemManagement(new DALItem());
            item = new Item();
        }

        public FormItems(string type)
        {
            InitializeComponent();
            manageItems = new ItemManagement(new DALItem());
            item = new Item();
            this.type = type;
        }

        //form
        private void FormItems_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            buttonUpdateItem.Visible = false;

            //in case of a boat update => fill in all the fields
            if (type != null)
            {

                textBoxItemType.Visible = false;
                buttonAddItem.Visible = false;
                buttonUpdateItem.Visible = true;

                //fill in fields with data
                item = new Item(type);
                item = manageItems.GetItemByType(item);
                labelItmType.Text = item.ItemType.ToString();
                textBoxCost.Text = item.UnitCost.ToString();
                textBoxDeposit.Text = item.Deposit.ToString();
                textBoxQuantity.Text = item.Quantity.ToString();
                textBoxRemark.Text = item.Remark;
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

        //back
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

        //add new item
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                //check if all fields are filled
                if (string.IsNullOrEmpty(textBoxCost.Text) || string.IsNullOrEmpty(textBoxQuantity.Text)
                    || string.IsNullOrEmpty(textBoxItemType.Text))
                {
                    MessageBox.Show(MyMessage.AllfieldsAreRequired);
                }
                else if (Verify.ContainNumbers(textBoxItemType.Text))
                {
                    MessageBox.Show("Item type cannot contain numbers");
                }

                //prevent letters for input numbers
                else if (Verify.ContainLetters(textBoxCost.Text) || Verify.ContainLetters(textBoxDeposit.Text)
                    || Verify.ContainLetters(textBoxQuantity.Text))
                {
                    MessageBox.Show(MyMessage.GearInfoLettersUnallowed);
                }

                else
                {

                    item = new Item(textBoxItemType.Text, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    //add item
                    if (manageItems.AddItem(item))
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
                if (string.IsNullOrEmpty(textBoxCost.Text) || string.IsNullOrEmpty(textBoxQuantity.Text)
                    || string.IsNullOrEmpty(textBoxDeposit.Text))
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

                    item = new Item(type, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    //update item
                    if (manageItems.UpdateItem(item))
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
