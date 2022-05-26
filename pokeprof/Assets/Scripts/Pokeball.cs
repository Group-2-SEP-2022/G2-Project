using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pokeball : MonoBehaviour, ICollectible
{
    public static event HandlePokeballCollected OnPokeballCollected;
    public delegate void HandlePokeballCollected(ItemData itemData);
    public ItemData pokeballData;

    //remove the gameobject from the hierarchy
    public void Collect()
    {
        Destroy(gameObject);
        OnPokeballCollected?.Invoke(pokeballData);
    }

    //check if the player collide with the pokeball to play the pickup sound
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            PickupSound.PlaySound();
        }
    }
}
