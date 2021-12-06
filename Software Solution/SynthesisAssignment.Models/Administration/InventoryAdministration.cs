using SynthesisAssignment.Models.Interfaces;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models
{

    public class InventoryAdministration
    {

        static Boat boat = new Boat();
        static Item item = new Item();

        //DAL
        DALInventory dalGear = new DALInventory();

        //add new boat
        public bool AddBoat(Boat gear)
        {

            List<Boat> boats = AllGear().OfType<Boat>().ToList();

            //if the list is empty
            if (boats.Count == 0)
            {
                dalGear.AddBoat(gear);
                return true;
            }

            else
            {

                for (int i = 0; i < boats.Count; i++)
                {
                    Boat b = new Boat();
                    b.BoatType = boats[i].BoatType;

                    if (b.BoatType == gear.BoatType)
                    {
                        return false;
                    }
                }

                dalGear.AddBoat(gear);
                return true;
            }
        }

        //update boat
        public bool UpdateBoat(int id, Boat boat)
        {
            if (dalGear.UpdateBoat(id, boat))
            {
                return true;
            }

            return false;
        }

        //update item
        public bool UpdateItem(int id, Item item)
        {
            if (dalGear.UpdateItem(id, item))
            {
                return true;
            }

            return false;
        }

        //add new item
        public bool AddItem(Item item)
        {

            List<Item> items = AllGear().OfType<Item>().ToList();

            //if the list is empty
            if (items.Count == 0)
            {
                dalGear.AddItem(item);
                return true;
            }

            else
            {

                for (int i = 0; i < items.Count; i++)
                {
                    Item itm = new Item();

                    itm.ItemType = items[i].ItemType;

                    if (itm.ItemType == item.ItemType)
                    {
                        return false;
                    }
                }

                dalGear.AddItem(item);
                return true;
            }
        }

        //get boat by id
        public Boat GetBoatByID(int id)
        {

            List<Boat> boats = AllGear().OfType<Boat>().ToList();

            foreach (var item in boats)
            {
                if (item.ID == id)
                {
                    boat = item;
                    return boat;
                }
            }

            return null;
        }

        //get item by id
        public Item GetItemByID(int id)
        {

            List<Item> items = AllGear().OfType<Item>().ToList();

            foreach (var itm in items)
            {
                if (itm.ID == id)
                {
                    item = itm;
                    return item;
                }
            }

            return null;
        }

        public bool DeleteGear(Inventory gear)
        {
            if (dalGear.DeleteGear(gear))
            {
                return true;
            }
            
            return false;
        }

        //all gear
        public List<Inventory> AllGear()
        {
            return dalGear.GetAllGear().ToList();
        }
    }
}
