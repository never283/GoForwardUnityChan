using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEplay : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

 


    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        


        AudioClip clip = gameObject.GetComponent<AudioSource>().clip;


        if (collision.gameObject.tag == "Load")
        {

            gameObject.GetComponent<AudioSource>().PlayOneShot(clip);

        }

        if (collision.gameObject.tag == "Cube")
        {

            gameObject.GetComponent<AudioSource>().PlayOneShot(clip);

        }



    }


}

