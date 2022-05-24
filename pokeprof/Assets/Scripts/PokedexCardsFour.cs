using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokedexCardsFour : MonoBehaviour
{
    public GameObject cardEmpty1;
    public GameObject cardColor1;

    public GameObject cardEmpty2;
    public GameObject cardColor2;

    public GameObject cardEmpty3;
    public GameObject cardColor3;

    public GameObject cardEmpty4;
    public GameObject cardColor4;

    public GameObject trigger;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            cardEmpty1.gameObject.SetActive(false);
            cardColor1.gameObject.SetActive(true);

            cardEmpty2.gameObject.SetActive(false);
            cardColor2.gameObject.SetActive(true);

            cardEmpty3.gameObject.SetActive(false);
            cardColor3.gameObject.SetActive(true);

            cardEmpty4.gameObject.SetActive(false);
            cardColor4.gameObject.SetActive(true);

            Destroy(trigger);
        }
    }
}
