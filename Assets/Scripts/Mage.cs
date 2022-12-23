using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player
{
    // Button Used to fire spell
    public KeyCode spellButton;
    // `GameObject` to be used as spell object
    public GameObject spellObject;
    // Direction `Mage` is facing (1: Right, -1: Left)
     private int currentDirection = 1; 

    // Update is called once per frame
    void Update()
    {
        // Call movement method from `Player` 
        playerMovement();

        // if previous velocity was left set direction to -1
        if (playerBody.velocity.x < 0)
        {
            currentDirection = -1;
        } 
        // if previous velocity was right set dirction to 1
        else if (playerBody.velocity.x > 0)
        {
            currentDirection = 1;
        }

        // check for input for `spellButton`
        if (Input.GetKeyDown(spellButton))
        {
            // Create new Spell Object
            GameObject newSpell = Instantiate(spellObject, transform.position, transform.rotation);
            // Set `direction` of Spell to `currentDirection`
            newSpell.GetComponent<Spell>().direction = currentDirection; 
        }
    }

    
}
