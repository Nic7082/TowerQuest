using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D platform;
    private GameObject knight;
    private GameObject mage;
    private bool isKnight = false;
    private bool isMage = false;
    
    void Start()
    {
        knight = GameObject.Find("Knight");

        mage = GameObject.Find("Mage");


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(platform.velocity);
        // if (isKnight)
        // {

        // }
        // if (isMage)
        // {

        // }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other == knight.GetComponent<Collider2D>())
        {
            isKnight = true;
        } 
        else if (other == knight.GetComponent<Collider2D>())
        {
            isMage = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other == knight.GetComponent<Collider2D>())
        {
            isKnight = true;
        } 
        else if (other == knight.GetComponent<Collider2D>())
        {
            isMage = true;
        }
    }
}
