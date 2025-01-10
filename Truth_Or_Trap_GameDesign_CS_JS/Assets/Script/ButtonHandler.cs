using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonHandler : MonoBehaviour
{
    // Change scene on Button click
    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    //Hide Panel
    public void HideTextPanel (GameObject textPanel)
    { 
        textPanel.SetActive(false); 
    }

    //Show Panel
    public void ShowTextPanel(GameObject textPanel)
    {
        textPanel.SetActive(true);
    }


    //Hide one panel and show another
    public void SwitchPanels(GameObject panelToHide, GameObject panelToShow)
    {
        panelToHide.SetActive(false);
        panelToHide.SetActive(true);
    }
}