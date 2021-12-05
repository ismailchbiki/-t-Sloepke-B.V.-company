using SynthesisAssignment.Models;
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
    public partial class FormItems : Form
    {

        Inventory gear;
        InventoryAdministration gearManager;
        Validation validate;
        GuidingMessages message;

        public FormItems()
        {
            InitializeComponent();

            gear = new Inventory();
            gearManager = new InventoryAdministration();
            validate = new Validation();
            message = new GuidingMessages();
        }

        private void FormItems_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            //populating the comboBoxes with enums
            comboBoxItem.DataSource = Enum.GetValues(typeof(ITEMTYPE));
        }

        //logout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();
            this.Hide();
        }

        //back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSelectOption selectOption = new FormSelectOption();

            selectOption.Show();
            this.Hide();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                //check if all fields are filled
                if (string.IsNullOrEmpty(textBoxCost.Text)  || string.IsNullOrEmpty(textBoxQuantity.Text))
                {
                    MessageBox.Show(message.EmptyFieldsError());
                }

                else if (validate.ContainLetters(textBoxCost.Text) || validate.ContainLetters(textBoxDeposit.Text)
                    || validate.ContainLetters(textBoxQuantity.Text))
                {
                    MessageBox.Show(message.GearFieldsError());
                }

                else
                {

                    gear = new Item((ITEMTYPE)comboBoxItem.SelectedItem, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);

                    if (!gearManager.AddItem((Item)gear))
                    {
                        MessageBox.Show(message.UnsuccessfulSave());
                    }
                    else
                    {
                        MessageBox.Show(message.SuccessfulSave());
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
