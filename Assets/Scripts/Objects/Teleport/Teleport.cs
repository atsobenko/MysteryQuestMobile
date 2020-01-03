using Effects;
using UnityEngine;

namespace Objects.Teleport
{
    public class Teleport : MonoBehaviour
    {
        [DraggablePoint] public Vector3 teleportTo;

        public Blackout blackout;

        private Collider2D _player;

        private bool _whaitIn, _whaitOut;

        // Update is called once per frame
        void Update()
        {
            TeleportPlayer();
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (!collider.CompareTag("Player"))
            {
                return;
            }
            blackout.ForceFadeIn();
            _player = collider;
            _player.SendMessage("ToggleMovementAbility");
            _whaitIn = true;
        }

        private void TeleportPlayer()
        {
            if (_whaitIn && !blackout.IsFadeIn())
            {
                _player.transform.position = teleportTo;
                blackout.ForceFadeOut();
                _whaitIn = false;
                _whaitOut = true;
            }
            else if (_whaitOut && !blackout.IsFadeOut())
            {
                _whaitOut = false;
                _player.SendMessage("ToggleMovementAbility");
            }
        }
    }
}
