using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    public GameObject currentLevel;
    public GameObject nextLevel;

    //when the player enter the trigger then enable the level he wants to enter and disable the level where he was
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            currentLevel.gameObject.SetActive(false);
            nextLevel.gameObject.SetActive(true);
        }
    }
}
