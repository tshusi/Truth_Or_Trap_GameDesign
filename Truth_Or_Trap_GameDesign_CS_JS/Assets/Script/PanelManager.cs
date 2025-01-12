using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject panelToHide;

    void Awake()
    {
        if (panelToHide != null)
        {
            panelToHide.SetActive(false);
        }
    }

}
