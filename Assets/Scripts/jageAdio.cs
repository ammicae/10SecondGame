

using UnityEngine;
using System.Collections;


public class jageAdio : MonoBehaviour
{
    public AudioClip meow;    
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = meow;
    }

    void OnCollisionEnter()  
    {
        GetComponent<AudioSource>().Play();
    }
   
}

