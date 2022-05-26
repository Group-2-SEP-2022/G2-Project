using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteMusicButton : MonoBehaviour
{
    public MusicData musicData;

    public bool isMusicOff;
    
    //set the scriptable object bool property
    public void Mute()
    {
        musicData.isOff = isMusicOff;
    }

    //when the game start set to false
    void OnEnable()
    {
        musicData.isOff = false;
    }
}