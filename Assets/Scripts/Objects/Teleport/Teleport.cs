using System.Linq;
using Character;
using Effects;
using UnityEngine;

namespace Objects.Teleport
{
    public class Teleport : ActiveObject.ActiveObject
    {
        [DraggablePoint] public Vector3 teleportTo;

        public Blackout blackout;
        
        private bool _whaitIn, _whaitOut;

        // Update is called once per frame
        void Update()
        {
            TeleportPlayer();
        }

        private void ClosedInteraction()
        {
            if (Player.GetComponent<Inventory>().UseItem(requiredItem))
            {
                currentState = states.First(i => i.stateName == "opened");
            }
        }
        
        private void OpenInteraction()
        {
            blackout.ForceFadeIn();
            Player.SendMessage("ToggleMovementAbility");
            _whaitIn = true;
        }
        

        private void TeleportPlayer()
        {
            if (_whaitIn && !blackout.IsFadeIn())
            {
                Player.transform.position = teleportTo;
                blackout.ForceFadeOut();
                _whaitIn = false;
                _whaitOut = true;
            }
            else if (_whaitOut && !blackout.IsFadeOut())
            {
                _whaitOut = false;
                Player.SendMessage("ToggleMovementAbility");
            }
        }
    }
}
