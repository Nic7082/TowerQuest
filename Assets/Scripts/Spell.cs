using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public float speed;
    public int direction;
    public Rigidbody2D spellBody;
    private GameObject mage;
    private GameObject mageSideFriction;


    void Update()
    {
        // Move spell to appropiate direction at appropiate speed
        spellBody.velocity = (Vector2.right * speed * direction);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Destroy game object if spell has collided
        Destroy(gameObject);
    }
}
