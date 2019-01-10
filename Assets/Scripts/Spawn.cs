using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject colum;

    public float coldTime = 2f;
    float rate = 0f;
    void Update()
    {
        if (Time.time >= rate && GM.isActive)
        {
            rate = Time.time + coldTime;
            Vector3 spawnP = transform.position;
            spawnP.y = Random.Range(-3f, 3f);
            Instantiate(colum, spawnP, transform.rotation);            
        }
    }
}
