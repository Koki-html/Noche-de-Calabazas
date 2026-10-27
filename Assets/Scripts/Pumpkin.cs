using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    // Contador global para todas las calabazas
    public static int pumpkinsActivated = 0;

    [Header("Configuración")]
    public Light PumpkinLight;

    private bool activated = false;

    public void OnPointerClick()
    {
        // Evita activar la misma calabaza dos veces
        if (activated)
            return;

        // Verifica que la luz esté asignada
        if (PumpkinLight == null)
        {
            return;
        }

        activated = true;

        // Enciende la luz
        PumpkinLight.gameObject.SetActive(true);
        PumpkinLight.enabled = true;

        // Cuenta la activación
        pumpkinsActivated++;
    }
}