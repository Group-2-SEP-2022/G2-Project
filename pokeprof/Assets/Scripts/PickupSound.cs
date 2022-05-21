using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSound : MonoBehaviour
{   
    public static AudioClip pickupSound;

    static AudioSource audioSrc;

    void Start() {
        pickupSound = Resources.Load<AudioClip>("pickup");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound () {
        audioSrc.PlayOneShot(pickupSound);
    }
}