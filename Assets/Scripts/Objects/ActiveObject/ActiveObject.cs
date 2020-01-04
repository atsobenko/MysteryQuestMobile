using System.Collections.Generic;
using UnityEngine;


namespace Objects.ActiveObject
{
    public class ActiveObject : MysteriousQuestObject
    {
        public List<ActiveObjectState> states;
        
        [SerializeField] protected ActiveObjectState currentState;
        public Item.Item requiredItem;
        protected Collider2D Player;

        private void Awake()
        {
            Player = GameObject.FindWithTag("Player").GetComponent<Collider2D>();
        }

        private void OnTriggerEnter2D(Collider2D inputCollider)
        {
            if (!inputCollider.CompareTag("Player"))
            {
                return;
            }
            Interact();
        }

        private void Interact()
        {
            Invoke(currentState.methodName, 0);
            Debug.Log(currentState.stateDescription);
        }
    }
}
