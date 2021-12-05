﻿using SynthesisAssignment.Models;
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

            //List<Boat> boats = manageGear.AllBoats().OfType<Boat>().ToList();
            //List<Item> items = manageGear.AllBoats().OfType<Item>().ToList();


            dataGridViewBoats.DataSource = manageGear.AllBoats().Select(o => new { ID = o.ID, Boat_Type = o.BoatType, Capacity = o.Capacity, Costs = o.Cost, Deposit = o.Deposit, Quantity = o.Quantity, Remark = o.Remark }).ToList();
            //dataGridViewItems.DataSource = items.Select(o => new { ID = o.ID, Item = o.ItemType, Costs = o.Cost, Deposit = o.Deposit, Quantity = o.Quantity, Remark = o.Remark }).ToList();
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
