using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCapture : MonoBehaviour
{
    public PokeprofData pokeprofData;
    public GameObject pokeprof;
    
    public void Capture() {
        pokeprof = FindInActiveObjectByName("Volker MÜLLER");
        pokeprof.SetActive(true);
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
