using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Administration
{
    public class ItemManagement : IItemManagement
    {
        //data access layer
        IDALItem _dalItem;

        public ItemManagement(IDALItem itemDA)
        {
            this._dalItem = itemDA;
        }

        //CRUD
        public bool AddItem(Item item)
        {
            bool status = false;
            //to prevent creating duplicate gear
            if ((GetItemByType(item)) == null)
            {
                //if insertion is successful
                if (_dalItem.AddGear(item))
                {
                    status = true;
                }
            }

            //if there is an error
            return status;
        }
        public bool UpdateItem(Item item)
        {
            bool status = false;
            if (_dalItem.UpdateGear(item))
            {
                status = true;
            }

            return status;
        }
        public bool DeleteItem(Item item)
        {
            bool status = false;
            if (_dalItem.DeleteGear(item))
            {
                status = true;
            }

            return status;
        }
        //Get By Type using Linq Query
        public Item GetItemByType(Item item)
        {
            Item itm = null;
            itm = GetAllItems().FirstOrDefault
                (i => i.GetInventoryType().Equals(item.GetInventoryType(), StringComparison.OrdinalIgnoreCase));

            return itm;
        }
        public List<Item> GetAllItems()
        {
            return _dalItem.GetAllItems().OfType<Item>().ToList();
        }
    }
}
