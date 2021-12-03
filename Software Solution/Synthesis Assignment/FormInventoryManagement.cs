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
    public partial class FormInventoryManagement : Form
    {

        Inventory inventory;
        InventoryAdministration manageGear;

        Boat item1;
        Item item2;

        //dummy data for testing
        int id = 1;
        double cost = 10;
        double deposit = 100;
        int qnty = 500;
        string remark = "inventory gear";

        BOATTYPE boat = BOATTYPE.Canoe;
        ITEMTYPE item = ITEMTYPE.LifeJacket;


        public FormInventoryManagement()
        {
            InitializeComponent();

            inventory = new Inventory();
            manageGear = new InventoryAdministration();

            item1 = new Boat()
            {
                ID = 101,
                BoatType = BOATTYPE.Sailboat_Valk,
                Cost = 1000,
                Deposit = 2000,
                Quantity = 20,
                Remark = "boat description here"
            };

            item2 = new Item()
            {
                ID = 102,
                ItemType = ITEMTYPE.Waterproof_Container,
                Cost = 100,
                Deposit = 200,
                Quantity = 70,
                Remark = "Waterproof Container description here"
            };

            manageGear.GearList().Add(item1);
            manageGear.GearList().Add(item2);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<Boat> boats = manageGear.GearList().OfType<Boat>().ToList();
            List<Item> items = manageGear.GearList().OfType<Item>().ToList();

            foreach (var item in boats)
            {
                listBox1.Items.Add(item.BoatType);
            }

            foreach (var item in items)
            {
                listBox1.Items.Add(item.ItemType);
            }

        }
    }
}
