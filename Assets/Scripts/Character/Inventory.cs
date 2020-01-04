using System.Collections.Generic;
using Objects.Item;
using UnityEngine;

namespace Character
{
    public class Inventory : MonoBehaviour
    {
        public List<Item> items;

        public bool UseItem(Item item)
        {
            if (item == null || !ContainsItem(item))
            {
                return false;
            }
            
            if (item.deletable)
            {
                items.Remove(item);
            }

            return true;

        }
        
        public bool ContainsItem(Item item)
        {
            return items.Contains(item);
        }
    }
}
