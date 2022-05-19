using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartCapture : MonoBehaviour
{
    public PokeprofData pokeprofData;
    private GameObject pokeprof;
    private GameObject pokeprofCardOutline;
    private GameObject pokeprofCard;

    private string pokeball;

    public TextMeshProUGUI quest;

    Inventory iD;

    public void Capture() {

        pokeprof = FindInActiveObjectByName(pokeprofData.pokeprofName);

        pokeprofCardOutline = FindInActiveObjectByName($"{pokeprofData.pokeprofName} Back Outline");
        pokeprofCard = FindInActiveObjectByName($"{pokeprofData.pokeprofName} Back");

        switch(pokeprofData.pokeprofName) {
            default:
            case "Ivan NOURDIN":            pokeball = "[M] Pokeball";
                                            break;
            case "Giovanni PECCATI":        pokeball = "[M] Special Pokeball";
                                            break;
            case "Anupam SENGUPTA":         pokeball = "[P] Pokeball";
                                            break;
            case "Alexandre TKATCHENKO":    pokeball = "[P] Special Pokeball";
                                            break;
            case "Frank SCHOLZEN":          pokeball = "[E] Pokeball";
                                            break;
            case "Stephan LEYER":           pokeball = "[E] Special Pokeball";
                                            break;                 
            case "Volker MÜLLER":
            case "Alfredo CAPOZUCCA":
            case "Martin THEOBALD":         pokeball = "[CS] Pokeball";
                                            break;
            case "Pascal BOUVRY":           pokeball = "[CS] Special Pokeball";
                                            break;
            case "Gilbert MASSARD":         
            case "Jean Luc BUEB":           pokeball = "[BM] Pokeball";
                                            break;
            case "Iris BEHRMANN":           pokeball = "[BM] Special Pokeball";
                                            break;
        }

        GameObject ID = GameObject.FindGameObjectWithTag("Inventory");
        iD = ID.GetComponent<Inventory>();

        List<ItemData> toRemove = new List<ItemData>();

        foreach(ItemData key in iD.itemDictionary.Keys) {
            if(key.displayName == pokeball) {
                pokeprofCard.SetActive(false);
                pokeprofCardOutline.SetActive(true);
                pokeprof.SetActive(true);
                toRemove.Add(key);
            }
        }
        foreach (ItemData key in toRemove)
        {
            iD.Remove(key);
        }

        quest.color = new Color32(38, 215, 0, 255);
    }

    GameObject FindInActiveObjectByName(string name)
{
    Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
    for (int i = 0; i < objs.Length; i++)
    {
        if (objs[i].hideFlags == HideFlags.None)
        {
            if (objs[i].name == name)
            {
                return objs[i].gameObject;
            }
        }
    }
    return null;
}
}
