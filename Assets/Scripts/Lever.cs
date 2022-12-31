using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : ClickableObject
{
    private bool isClicked = false;
    private int cooldown = 0; // used to prevent multiple collision happening in successive frames

    void Update()
    {
        if (cooldown != 15)
        {
            cooldown += 1; // increment cooldown
        }
        runClick(isClicked); // run parent function

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (cooldown == 15) // make sure collision not happening in same frame
        {
            isClicked = !isClicked; // switch value of lever

            // rotate lever
            if (!isClicked)
            {
                
                transform.localPosition = new Vector3(-.1f, .2f, 0);
                transform.localRotation = Quaternion.Euler(0, 0, -45);
            }
            else 
            {
                transform.localPosition = new Vector3(.1f, .2f, 0);
                transform.localRotation = Quaternion.Euler(0, 0, 45);
            }

            // set cooldown to zero
            cooldown = 0;
        }
    }
}
