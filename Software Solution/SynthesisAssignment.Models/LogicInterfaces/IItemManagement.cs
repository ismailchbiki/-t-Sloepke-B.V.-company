using SynthesisAssignment.Services;
using System.Collections.Generic;

namespace SynthesisAssignment.Models
{
    public interface IItemManagement
    {
        bool AddItem(Item item);
        bool DeleteItem(Item item);
        List<Item> GetAllItems();
        Item GetItemByType(Item item);
        bool UpdateItem(Item item);
    }
}