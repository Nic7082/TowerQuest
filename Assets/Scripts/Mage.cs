using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player
{
    public KeyCode spellButton;
    public GameObject spellObject;
     private int currentDirection = 1; 

    // Update is called once per frame
    void Update()
    {
        playerMovement();

        if (playerBody.velocity.x < 0)
        {
            currentDirection = -1;
        } 
        else if (playerBody.velocity.x > 0)
        {
            currentDirection = 1;
        }


        if (Input.GetKeyDown(spellButton))
        {
            GameObject newSpell = Instantiate(spellObject, transform.position, transform.rotation);
            newSpell.GetComponent<Spell>().direction = currentDirection; 
        }
    }

    
}
