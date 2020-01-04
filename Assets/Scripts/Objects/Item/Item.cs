using Character;
using UnityEngine;

namespace Objects.Item
{
    public class Item : MysteriousQuestObject
    {
        public bool deletable;
        
        private void OnTriggerEnter2D(Collider2D inputCollider)
        {
            if (!inputCollider.CompareTag("Player"))
            {
                return;
            }
            
            inputCollider.GetComponent<Inventory>().items.Add(gameObject.GetComponent<Item>());
            gameObject.SetActive(false);
        }
    }
}
