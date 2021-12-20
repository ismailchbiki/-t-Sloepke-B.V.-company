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

        //get id of selected row
        int id = 0;

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
                ID = o.ID,
                Boat_Type = o.BoatType,
                Capacity = o.Capacity,
                Costs = o.Cost,
                Deposit = o.Deposit,
                Quantity = o.Quantity,
                Remark = o.Remark
            }).ToList();

            //table of items
            dataGridViewItems.DataSource = gear.OfType<Item>().Select(o => new {
                ID = o.ID,
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

                id = (int)dataGridViewBoats.SelectedRows[0].Cells["ID"].Value;
                Boat b = new Boat(id);
                FormBoats boats = new FormBoats(b);

                boats.Show();
                this.Hide();
            }
            else if (tabControlAdministration.SelectedTab == tabPageItems)
            {

                id = (int)dataGridViewItems.SelectedRows[0].Cells["ID"].Value;
                Item item = new Item(id);
                FormItems items = new FormItems(item);

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

                id = (int)dataGridViewBoats.SelectedRows[0].Cells["ID"].Value;

                Boat b = new Boat(id);
                FormConfirmDeletion boats = new FormConfirmDeletion(b);

                boats.Show();
                this.Hide();
            }
            else if (tabControlAdministration.SelectedTab == tabPageItems)
            {

                id = (int)dataGridViewItems.SelectedRows[0].Cells["ID"].Value;

                Item item = new Item(id);
                FormConfirmDeletion items = new FormConfirmDeletion(item);

                items.Show();
                this.Hide();
            }
        }
    }
}
