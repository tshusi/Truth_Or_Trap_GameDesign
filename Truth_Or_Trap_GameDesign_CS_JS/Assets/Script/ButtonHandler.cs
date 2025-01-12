using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonHandler : MonoBehaviour

{
    public bool isPanelHidden = true;
   
    
    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void HideTextPanel (GameObject textPanel)
    { 
        textPanel.SetActive(false); 
    }

    public void ShowTextPanel (GameObject textPanel)
    { 
        textPanel.SetActive(true);
    }


    public void SwitchPanelVisibility(GameObject textPanel)

    {
        if (isPanelHidden)
        {
            textPanel.SetActive(true);
            isPanelHidden = false;
        }
        else
        {
            textPanel.SetActive(false);
            isPanelHidden = true;
        }
    }

}