using UnityEngine;
using UnityEngine.SceneManagement;


// Change scene on Button click

public class ButtonHandler : MonoBehaviour
{
    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void HideTextPanel (GameObject textPanel)
    { 
        textPanel.SetActive(false); 
    }

}