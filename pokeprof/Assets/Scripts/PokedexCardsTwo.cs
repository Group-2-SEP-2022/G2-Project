using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokedexCardsTwo : MonoBehaviour
{
    public GameObject cardEmpty1;
    public GameObject cardColor1;

    public GameObject cardEmpty2;
    public GameObject cardColor2;

    public GameObject trigger;

    //show the card color in the pokedex for department with 2 cards
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            cardEmpty1.gameObject.SetActive(false);
            cardColor1.gameObject.SetActive(true);

            cardEmpty2.gameObject.SetActive(false);
            cardColor2.gameObject.SetActive(true);

            Destroy(trigger);
        }
    }
}
