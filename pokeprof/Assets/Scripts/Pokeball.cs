using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pokeball : MonoBehaviour, ICollectible
{
    public static event HandlePokeballCollected OnPokeballCollected;
    public delegate void HandlePokeballCollected(ItemData itemData);
    public ItemData pokeballData;

    public void Collect() {
        Destroy(gameObject);
        OnPokeballCollected?.Invoke(pokeballData);
    }
}
