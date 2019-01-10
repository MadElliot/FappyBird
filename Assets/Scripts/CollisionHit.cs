using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHit : MonoBehaviour {

     GameObject gm;
    void Start()
    {
        gm = GameObject.Find("GM");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.GetComponent<UIControl>().GameOver();
            GM.isActive = false;
        }
    }
}
