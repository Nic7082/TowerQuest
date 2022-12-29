using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
     
    public Transform objectMoving;
    public Rigidbody2D objectMovingBody;
    private Vector3 originalPosition;
    public Vector3 displacement;
    private Vector3 endingPosition;
    private int isClicked = 0;

    void Start()
    {
        originalPosition = objectMoving.position;
        endingPosition = originalPosition + displacement;
    }

    void Update()
    {
        if (isClicked > 0 && Vector3.Distance(endingPosition, objectMoving.position) > .01)
        {
            objectMovingBody.velocity = displacement;
        }
        else if(isClicked == 0 && Vector3.Distance(originalPosition, objectMoving.position) > .01)
        {
            objectMovingBody.velocity = -displacement;
        } 
        else 
        {
            objectMovingBody.velocity = new Vector2(0,0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isClicked += 1;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isClicked -= 1;
    }
}
