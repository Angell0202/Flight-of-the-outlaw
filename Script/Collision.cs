using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private GameObject player; // Reference to the player GameObject
    private GameObject charmodel; // Reference to the character model with the Animator

    void Start()
    {
       
        player = GameObject.FindGameObjectWithTag("Player");
        charmodel = GameObject.FindGameObjectWithTag("CharacterModel");
    }

    void OnTriggerEnter(Collider other)
    {
       
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        
        if (player != null)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
        }

       
        if (charmodel != null)
        {
            charmodel.GetComponent<Animator>().Play("stumble");
        }
    }
}
