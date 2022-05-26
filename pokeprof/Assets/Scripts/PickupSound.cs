using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSound : MonoBehaviour
{
    public static AudioClip pickupSound;

    static AudioSource audioSrc;

    //load the pickup sound and find the audio source
    void Start()
    {
        pickupSound = Resources.Load<AudioClip>("pickup");

        audioSrc = GetComponent<AudioSource>();
    }

    //play the pickup sound
    public static void PlaySound()
    {
        audioSrc.PlayOneShot(pickupSound);
    }
}
