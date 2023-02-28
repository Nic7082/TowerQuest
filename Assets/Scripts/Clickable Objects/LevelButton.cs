using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    public bool isClicked = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        isClicked = true; // if player enters hitbox 
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isClicked = false; // if player leaves hitbox
    }
}
