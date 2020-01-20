using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adio : MonoBehaviour
{
    public AudioSource meow; //set in inspector  
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)  // other is a reference to the other trigger collider we have touched
    {
        if (other.gameObject.tag == "Player") //or you could do other.gameObject.name == "Player"
        {
            meow.Play(); //play the coin sound
            
        }
    }
}