using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                {
                    Pause();
                }
            }
        }

       
    }
    
    
    private void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }


    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
    }


    private void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
