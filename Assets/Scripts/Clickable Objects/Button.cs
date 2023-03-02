using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : ClickableObject
{
    private int isClicked = 0;

    void FixedUpdate()
    {
        runClick(isClicked > 0); // run parent function
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isClicked += 1; // if player enters hitbox 
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isClicked -= 1; // if player leaves hitbox
    }
}
