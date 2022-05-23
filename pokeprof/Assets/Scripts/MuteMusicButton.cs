using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteMusicButton : MonoBehaviour
{
    public MusicData musicData;

    public bool isMusicOff;

    public void Mute()
    {
        musicData.isOff = isMusicOff;
    }
}
