using SynthesisAssignment.Models;
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
    public partial class FormConfirmDeletion : Form
    {

        Inventory gear;
        InventoryAdministration manageGear;

        public FormConfirmDeletion(Inventory gear)
        {
            InitializeComponent();

            this.gear = gear;
            manageGear = new InventoryAdministration();
        }

        private void FormConfirmDeletion_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        //confirm
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //if gear is deleted
            if (manageGear.DeleteGear(gear))
            {
                MessageBox.Show("Item Removed successfully");
                FormInventory inventory = new FormInventory();

                //to clear the variables
                gear = new Boat();
                gear = new Item();

                inventory.Show();
                this.Hide();
            }
        }

        //cancel
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormInventory inventory = new FormInventory();

            //to clear the variables
            gear = new Boat();
            gear = new Item();

            inventory.Show();
            this.Hide();
        }
    }
}
