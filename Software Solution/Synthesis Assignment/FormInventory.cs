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
    public partial class FormInventory : Form
    {

        //get type of the selected row
        string type = null;
        Inventory gear;
        InventoryAdministration manageGear;

        public FormInventory()
        {
            InitializeComponent();
            manageGear = new InventoryAdministration();
        }

        //on load fill in the tables
        private void FormInventory_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            dataGridViewBoats.Columns.Clear();

            List<Inventory> gear = manageGear.GetAllGear();

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

        // add new gear
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSelectOption selectOpt = new FormSelectOption();

            selectOpt.Show();
            this.Hide();
        }

        //update existing gear
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            //forwarding user depends on the selected row from which tabPage
            if (tabControlAdministration.SelectedTab == tabPageBoats)
            {

                type = dataGridViewBoats.SelectedRows[0].Cells["Boat_Type"].Value.ToString();
                FormBoats boats = new FormBoats(type);

                boats.Show();
                this.Hide();
            }
            else if (tabControlAdministration.SelectedTab == tabPageItems)
            {

                type = dataGridViewItems.SelectedRows[0].Cells["Item"].Value.ToString();
                FormItems items = new FormItems(type);

                items.Show();
                this.Hide();
            }
        }

        //delete selected row
        private void buttonDeleteSelectedRow_Click(object sender, EventArgs e)
        {
            //forwarding user depends on the selected row from which tabPage
            if (tabControlAdministration.SelectedTab == tabPageBoats)
            {

                type = dataGridViewBoats.SelectedRows[0].Cells["Boat_Type"].Value.ToString();
                gear = new Boat(type);
                FormConfirmDeletion boats = new FormConfirmDeletion(gear);

                boats.Show();
                this.Hide();
            }
            else if (tabControlAdministration.SelectedTab == tabPageItems)
            {

                type = dataGridViewItems.SelectedRows[0].Cells["Item"].Value.ToString();
                gear = new Item(type);
                FormConfirmDeletion items = new FormConfirmDeletion(gear);

                items.Show();
                this.Hide();
            }
        }
    }
}
