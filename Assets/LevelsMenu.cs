using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelsMenu : MonoBehaviour
{
    public void LevelOne ()
    {
        SceneManager.LoadScene(1);
    }
    public void LevelTwo ()
    {
        SceneManager.LoadScene(2);
    }
    public void LevelThree ()
    {
        SceneManager.LoadScene(3);
    }
}
