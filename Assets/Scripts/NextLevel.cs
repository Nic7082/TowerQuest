using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public string nextLevelName;
    

    // Update is called once per frame
    void Update()
    {
        if (button1.GetComponent<LevelButton>().isClicked && button2.GetComponent<LevelButton>().isClicked)
        {
            Debug.Log(button1.GetComponent<LevelButton>().isClicked);
            Debug.Log(button2.GetComponent<LevelButton>().isClicked);
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
