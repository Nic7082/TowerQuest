using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Player
{
    
    // Update is called once per frame
    void FixedUpdate()
    {
        playerMovement(new Vector2(-0.04717964f, 2.028722f), new Vector2(1.31453f, 1.691967f));
    }
}
