using System.Collections.Generic;
using UnityEngine;


namespace Objects.ActiveObject
{
    public class ActiveObject : MysteriousQuestObject
    {
        public List<ActiveObjectState> states;

        public HUD hUD;
        
        [SerializeField] public ActiveObjectState currentState;
        public Item.Item requiredItem;
        public TextWritingSystem writingSystem;
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

            hUD.Open(this, writingSystem);
        }

        private void OnTriggerExit2D(Collider2D inputCollider)
        {
            if (!inputCollider.CompareTag("Player"))
            {
                return;
            }

            hUD.Close();
        }

        public void Interact()
        {
            Invoke(currentState.methodName, 0);

            if (currentState.closingInteraction)
            {
                hUD.Close();
            }
        }
    }
}
