using UnityEngine;

public class GraveStone : MonoBehaviour
{
    public Transform player;
    public Transform destination;

    public void OnPointerClick()
    {
        if (Pumpkin.pumpkinsActivated < 3)
        {
            return;
        }

        if (player == null || destination == null)
        {
            return;
        }

        player.position = destination.position;
    }
}
