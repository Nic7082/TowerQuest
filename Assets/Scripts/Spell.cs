using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public float speed;
    public int direction;
    private Collider2D mage;
    private Collider2D mageSideFriction;


    void Start()
    {
        // Find mage collider and mage side friction collider
        mage = GameObject.Find("Mage").GetComponent<Collider2D>();
        mageSideFriction = GameObject.Find("Mage Side Friction").GetComponent<Collider2D>();
    }
    void Update()
    {
        // Move spell to appropiate direcation at appropiate speed
        transform.Translate(Vector3.right * speed * direction);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Destroy game object is spell has collided with any other object except `Mage`
        if (!(other == mage || other == mageSideFriction))
        {
            Debug.Log(other);
            Destroy(gameObject);
        }

    }
}
