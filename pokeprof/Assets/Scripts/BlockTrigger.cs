using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrigger : MonoBehaviour
{
    public Collider2D block;

    public bool isBlocked = false;

    //enable the collider to prevent the player from going outside the map from the escalator and from going up from the down escalator same for the up escalator
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            block.gameObject.SetActive(isBlocked);
        }
    }
}
