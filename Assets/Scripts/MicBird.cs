using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicBird : MonoBehaviour
{

    Rigidbody2D birdRigidbody;
    public float force = 100;
    void Start()
    {
        birdRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MicroInput.volume >= 0.15f)
        {
            Fly();
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    birdRigidbody.AddForce(Vector2.up * force);
        //}
    }

    void Fly()
    {
        if (GM.isActive)
        {
            birdRigidbody.AddForce(Vector2.up * force * MicroInput.volume);
        }
    }
}
