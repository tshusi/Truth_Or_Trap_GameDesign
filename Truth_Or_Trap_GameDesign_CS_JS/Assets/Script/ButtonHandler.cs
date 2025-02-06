using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonHandler : MonoBehaviour

{
    public bool isPanelHidden = true;
   
    
    private void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    private void HideTextPanel (GameObject textPanel)
    { 
        textPanel.SetActive(false); 
    }

    private void ShowTextPanel (GameObject textPanel)
    { 
        textPanel.SetActive(true);
    }


    private void SwitchPanelVisibility(GameObject textPanel)

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