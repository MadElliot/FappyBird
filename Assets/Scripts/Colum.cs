using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum : MonoBehaviour
{

    public float speed = 100f;
    AudioSource crossAudio;
    UIControl uic;
    void Start()
    {
        uic = GameObject.Find("GM").GetComponent<UIControl>();
        Destroy(gameObject, 10f);
        crossAudio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (GM.isActive)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            uic.SetScore();
            crossAudio.Play();
        }
    }
}
