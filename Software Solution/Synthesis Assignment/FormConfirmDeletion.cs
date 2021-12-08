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

        //id of the gear to delete
        Inventory gear;
        InventoryAdministration gearManager;


        public FormConfirmDeletion(Inventory gear)
        {
            InitializeComponent();

            this.gear = gear;
            gearManager = new InventoryAdministration();

        }

        private void FormConfirmDeletion_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //if gear is deleted
            if (gearManager.DeleteGear(gear))
            {
                MessageBox.Show("Item Removed successfully");
                FormInventory inventory = new FormInventory();

                //to clear the variables
                FormInventory.BoatID = 0;
                FormInventory.ItemID = 0;

                inventory.Show();
                this.Hide();
            }
        }

        //cancel
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormInventory inventory = new FormInventory();

            //to clear the variables
            FormInventory.BoatID = 0;
            FormInventory.ItemID = 0;

            inventory.Show();
            this.Hide();
        }
    }
}
