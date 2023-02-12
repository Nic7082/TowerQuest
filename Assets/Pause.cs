using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public static bool GamePaused= false;
    public GameObject pauseScreenUI;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            } else
            {
                Paused();
            }
        }
    }
    public void Resume ()
    {
        pauseScreenUI.SetActive(false);
        Time.timeScale=1f;
        GamePaused=false;
    }
    void Paused ()
    {
        pauseScreenUI.SetActive(true);
        Time.timeScale=0f;
        GamePaused=true;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
