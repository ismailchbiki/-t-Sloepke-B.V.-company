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
        InventoryAdministration gearManager;


        public FormConfirmDeletion(Inventory gear)
        {
            InitializeComponent();

            gearManager = new InventoryAdministration();
            this.gear = gear;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (gear.GetType() == typeof(Boat))
            {
                gearManager.DeleteGear((Boat)gear);
            }
            else if (gear.GetType() == typeof(Item))
            {
                gearManager.DeleteGear((Item)gear);
            }
        }
    }
}
