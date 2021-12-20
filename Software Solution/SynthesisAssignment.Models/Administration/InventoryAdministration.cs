﻿using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models
{

    public class InventoryAdministration
    {
        
        //data access layer
        DALInventory dalGear = new DALInventory();

        //add gear
        public bool AddGear(Inventory gear)
        {

            //to prevent creating duplicate gear
            if ((GetGearByType(gear)) == null)
            {
                //if insertion is successful
                if (dalGear.AddGear(gear))
                {
                    return true;
                }
            }
            
            //if there is an error
            return false;
        }

        //update gear
        public bool UpdateGear(Inventory gear)
        {
            if (dalGear.UpdateGear(gear))
            {
                return true;
            }

            return false;
        }

        //get gear by type
        public Inventory GetGearByType(Inventory gear)
        {

            if (gear is Boat)
            {
                foreach (var b in GetAllGear().OfType<Boat>().ToList())
                {
                    if (b.BoatType == ((Boat)gear).BoatType)
                    {
                        return b;
                    }
                }
            }

            else if (gear is Item)
            {
                foreach (var item in GetAllGear().OfType<Item>().ToList())
                {
                    if (item.ItemType == ((Item)gear).ItemType)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        //get gear by ID
        public Inventory GetGearByID(Inventory gear)
        {

            if (gear is Boat)
            {
                foreach (var b in GetAllGear().OfType<Boat>().ToList())
                {
                    if (b.ID == ((Boat)gear).ID)
                    {
                        return b;
                    }
                }
            }

            else if (gear is Item)
            {
                foreach (var item in GetAllGear().OfType<Item>().ToList())
                {
                    if (item.ID == ((Item)gear).ID)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        //delete gear
        public bool  DeleteGear(Inventory gear)
        {
            if (dalGear.DeleteGear(gear))
            {
                return true;
            }
            
            return false;
        }

        //all gear
        public List<Inventory> GetAllGear()
        {
            return dalGear.GetAllGear().ToList();
        }
    }
}
