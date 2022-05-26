using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCaptureButton : MonoBehaviour
{
    public GameObject pokedexButton;
    public GameObject captureButton;
    public GameObject pokeprof;

    public Sprite pokeball;

    public PokeprofData pokeprofData;
    
    //show the correct pokeball according to the pokeprof when the player enter the trigger
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            pokedexButton.SetActive(false);
            captureButton.SetActive(true);

            pokeprofData.pokeprofName = pokeprof.name;

            captureButton.GetComponent<Image>().sprite = pokeball;
        }
    }

    //show the pokedex icon when the player leaves the pokeprof trigger
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            pokedexButton.SetActive(true);
            captureButton.SetActive(false);
        }
    }
}
