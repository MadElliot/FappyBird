using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float force = 100f;
    Rigidbody2D birdRigidbody;
    void Start()
    {
        birdRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fly();           
        }
    }
    void Fly()
    {
        if (GM.isActive)
        {
            birdRigidbody.AddForce(Vector2.up * force);
        }
    }
    public void Touch()
    {
        Fly();
    }
}
