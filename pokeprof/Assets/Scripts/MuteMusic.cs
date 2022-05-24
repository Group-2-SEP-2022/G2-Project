using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteMusic : MonoBehaviour
{
    public GameObject[] musicListInactive;
    public GameObject[] musicList;
    public MusicData musicData;

    void Start()
    {
        musicListInactive = FindInActiveObjectsByTag("Music");
        musicList = GameObject.FindGameObjectsWithTag("Music");

        if (musicData.isOff)
        {
            foreach (GameObject musicInactive in musicListInactive)
            {
                musicInactive.GetComponent<AudioSource>().mute = true;
            }

            foreach (GameObject music in musicList)
            {
                music.GetComponent<AudioSource>().mute = true;
            }
        } else {
            foreach (GameObject musicInactive in musicListInactive)
            {
                musicInactive.GetComponent<AudioSource>().mute = false;
            }

            foreach (GameObject music in musicList)
            {
                music.GetComponent<AudioSource>().mute = false;
            }
        }
    }

    GameObject[] FindInActiveObjectsByTag(string tag)
    {
        List<GameObject> validTransforms = new List<GameObject>();
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].gameObject.CompareTag(tag))
                {
                    validTransforms.Add(objs[i].gameObject);
                }
            }
        }
        return validTransforms.ToArray();
    }
}
