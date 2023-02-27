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

     private Vector2 jumpOffset = new Vector2(-0.1520548f, 1.81458f);
     
      private Vector2 jumpSize = new Vector2(0.8787022f, 1.697918f);

    // Update is called once per frame
    void Update()
    {
        
        
        // Call movement method from `Player` 
        playerMovement(jumpOffset, jumpSize);

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
            //find spell object spawn position so not destroyed on contact with mage
            Vector3 newSpellPosition = transform.position 
                                    + (new Vector3(transform.localScale.x / 2, 0, 0) + new Vector3(spellObject.transform.localScale.x, 0, 0))
                                    * currentDirection;
            // Create new Spell Object
            GameObject newSpell = Instantiate(spellObject, newSpellPosition, transform.rotation);
            // Set `direction` of Spell to `currentDirection`
            newSpell.GetComponent<Spell>().direction = currentDirection; 
        }
    }

    
}
