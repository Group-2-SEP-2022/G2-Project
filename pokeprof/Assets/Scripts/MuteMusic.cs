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
        //return the list of all inactive game objects
        musicListInactive = FindInActiveObjectsByTag("Music");
         //return the list of all active game objects
        musicList = GameObject.FindGameObjectsWithTag("Music");
        
        //check if the music should be off
        if (musicData.isOff)
        {   
            //if off then mute the music
            foreach (GameObject musicInactive in musicListInactive)
            {
                musicInactive.GetComponent<AudioSource>().mute = true;
            }

            foreach (GameObject music in musicList)
            {
                music.GetComponent<AudioSource>().mute = true;
            }
        } else {
            //if on then unmute the music
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

    //find all inactive game object according to their tag
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
