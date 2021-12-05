using SynthesisAssignment.Models;
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
    public partial class FormInventory : Form
    {

        InventoryAdministration manageGear;

        public FormInventory()
        {
            InitializeComponent();

            manageGear = new InventoryAdministration();
        }


        private void FormInventory_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            dataGridViewBoats.Columns.Clear();

            List<Inventory> gear = manageGear.AllGear();

            //table of boats
            dataGridViewBoats.DataSource = gear.OfType<Boat>().Select(o => new {
                Boat_Type = o.BoatType,
                Capacity = o.Capacity,
                Costs = o.Cost,
                Deposit = o.Deposit,
                Quantity = o.Quantity,
                Remark = o.Remark
            }).ToList();

            //table of items
            dataGridViewItems.DataSource = gear.OfType<Item>().Select(o => new {
                Item = o.ItemType,
                Costs = o.Cost,
                Deposit = o.Deposit,
                Quantity = o.Quantity,
                Remark = o.Remark
            }).ToList();
        }


        //back to previous form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();

            dashboard.Show();
            this.Hide();
        }


        //logout 
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSelectOption selectOpt = new FormSelectOption();

            selectOpt.Show();
            this.Hide();
        }
    }
}
