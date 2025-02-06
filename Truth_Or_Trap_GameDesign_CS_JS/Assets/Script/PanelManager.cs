using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject panelToHide;

    private void Awake()
    {
        if (panelToHide != null)
        {
            panelToHide.SetActive(false);
        }
    }

}
