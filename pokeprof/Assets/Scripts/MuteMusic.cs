using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteMusic : MonoBehaviour
{
    public GameObject music;
    public MusicData musicData;

    void Start()
    {
        if (musicData.isOff)
        {
            music.SetActive(false);
        }
    }
}
