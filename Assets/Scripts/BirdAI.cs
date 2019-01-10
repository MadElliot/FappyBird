using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAI : MonoBehaviour
{

    public float moveForce = 100;
    public float jumpForce = 600;

    Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FlySign")
        {
            rg.AddForce(new Vector2(0f, jumpForce));
            rg.velocity = Vector2.right * Time.deltaTime * moveForce;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            rg.AddForce(new Vector2(0f, jumpForce));
            rg.velocity = Vector2.right * Time.deltaTime * moveForce;
        }
        else
        {
            moveForce = -moveForce;
        }

    }
}
