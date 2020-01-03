using UnityEngine;

public class Teleport : MonoBehaviour
{
    [DraggablePoint] public Vector3 TeleportTo;

    public Blackout blackout;

    private Collider2D _player;

    private bool _whaitIn, _whaitOut = false;

    // Update is called once per frame
    void Update()
    {
        TeleportPlayer();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            blackout.ForceFadeIn();
            _player = collider;
            _player.SendMessage("ToggleMovementAbility");
            _whaitIn = true;
        }
    }

    public void TeleportPlayer()
    {
        if (_whaitIn && !blackout.IsFadeIn())
        {
            _player.transform.position = TeleportTo;
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
