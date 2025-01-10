using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject panelToHide; // Panel, das beim Laden der Szene deaktiviert werden soll

    void Awake()
    {
        // Option 1: Panel direkt beim Start deaktivieren
        if (panelToHide != null)
        {
            panelToHide.SetActive(false);
        }
    }

}
