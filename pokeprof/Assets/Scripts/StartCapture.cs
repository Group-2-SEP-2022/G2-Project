using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCapture : MonoBehaviour
{
    public GameObject pokeprof;
    public GameObject game;

    public void OnTriggerEnter2D(Collider2D other){
     
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            pokeprof.SetActive(true);
            game.SetActive(false);
        }
    }
}
