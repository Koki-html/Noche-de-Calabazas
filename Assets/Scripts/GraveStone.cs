using UnityEngine;

public class GraveStone : MonoBehaviour
{
    public Transform player;
    public Transform destination;
    public ScreenFadeVR screenFadeVR;
    

    public void OnPointerClick()
    {
        if (Pumpkin.pumpkinsActivated < 3)
        {
            return;
        }

        if (player == null || destination == null || screenFadeVR == null)
        {
            return;
        }

        StartCoroutine(MoverConTransicion());
    }

    private System.Collections.IEnumerator MoverConTransicion()
    {
        yield return screenFadeVR.CerrarYEsperar();
        player.position = destination.position;
        yield return screenFadeVR.AbrirYEsperar();
    }
}
