using TMPro;
using UnityEngine;

public class PumpkinOff : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private Light pumpkinLight;
    [SerializeField] private GameObject lastPumpkin;
    [SerializeField] private TMP_Text dialogSecondary;

    private bool activated = true;

    public void OnPointerClick()
    {
        if (!activated)
        {
            return;
        }

        if (pumpkinLight == null)
        {
            return;
        }

        activated = false;

        pumpkinLight.gameObject.SetActive(false);
        pumpkinLight.enabled = false;

        if (lastPumpkin != null)
        {
            lastPumpkin.SetActive(false);

            if (dialogSecondary != null)
            {
                dialogSecondary.text = "¡Finalmente... Has apagado todas las calabazas! El Halloween ha terminado. ¿Quieres Reiniciar? Toca la Calabaza sobre la tumba";
            }
        }
    }
}
