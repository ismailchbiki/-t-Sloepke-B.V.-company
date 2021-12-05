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

        Inventory gear;
        InventoryAdministration managerBoats;
        Validation validate;
        GuidingMessages message;

        public FormBoats()
        {
            InitializeComponent();

            gear = new Inventory();
            managerBoats = new InventoryAdministration();
            validate = new Validation();
            message = new GuidingMessages();

        }

        private void FormAddBoat_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            //populating the comboBoxes with enums
            comboBoxBoatType.DataSource = Enum.GetValues(typeof(BOATTYPE));
            comboBoxCapacity.DataSource = Enum.GetValues(typeof(CAPACITY));
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

            selectOption.Show();
            this.Hide();
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
                    MessageBox.Show(message.EmptyFieldsError());
                }

                else if (validate.ContainLetters(textBoxCost.Text) || validate.ContainLetters(textBoxDeposit.Text)
                    || validate.ContainLetters(textBoxQuantity.Text))
                {
                    MessageBox.Show(message.GearFieldsError()) ;
                }

                else
                {
                    gear = new Boat((BOATTYPE)comboBoxBoatType.SelectedItem,
                        (CAPACITY)comboBoxCapacity.SelectedItem, Convert.ToDouble(textBoxCost.Text),
                        Convert.ToDouble(textBoxDeposit.Text), Convert.ToInt32(textBoxQuantity.Text), textBoxRemark.Text);
                    
                    if (!managerBoats.AddBoat((Boat)gear))
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
