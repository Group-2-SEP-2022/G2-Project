using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MusicData")]
public class MusicData : ScriptableObject
{
    public bool isOff;

    private void OnEnable()
     {
         isOff = false;
     }
}
