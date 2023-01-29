using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MovingPlatformScript : MonoBehaviour
{
    //Data Fields
    public GameObject platformPathStart;
    public GameObject platformPathEnd;
    public int speed;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private Rigidbody2D body;
    private Vector3 timeScale;
   
    
    //Methods
    void Start()
    {
        startPosition = platformPathStart.transform.position;
        endPosition = platformPathEnd.transform.position;
        body = gameObject.GetComponent<Rigidbody2D>();
        timeScale = ((startPosition - endPosition) / 60) * speed;
        transform.position = startPosition;
    }
    
    void Update()
    {

        if (Vector3.Distance(endPosition, transform.position) < .1) 
        {
            body.velocity = timeScale; 
        }
        else if(Vector3.Distance(startPosition, transform.position) < .01) 
        {
            body.velocity = -timeScale;
        } 
    } 
}
