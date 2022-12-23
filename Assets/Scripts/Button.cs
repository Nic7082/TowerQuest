using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
     
    public Transform objectMoving;
    private Vector3 originalPosition;
    public Vector3 displacement;
    private Vector3 endingPosition;
    public int timeForMovement;
    private bool isClicked = false;

    void Start()
    {
        originalPosition = objectMoving.position;
        endingPosition = originalPosition + displacement;
    }

    void Update()
    {
        if (isClicked && Vector3.Distance(endingPosition, objectMoving.position) > 0.01)
        {
            objectMoving.Translate(displacement/(60 * timeForMovement));
        }
        else if(!isClicked && Vector3.Distance(originalPosition, objectMoving.position) > 0.01)
        {
            objectMoving.Translate(-displacement/(60 * timeForMovement));
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isClicked = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isClicked = false;
    }
}
