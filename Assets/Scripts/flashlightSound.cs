using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Flashlight))]
public class flashlightSound : MonoBehaviour
{
    private Flashlight flashlight;

    private AudioSource sound;

    private void Start()
    {
        sound = GetComponentInChildren<AudioSource>();
        flashlight = gameObject.GetComponent<Flashlight>();
        flashlight.FlashlightTurn += turn;
    }

    private void turn()
    {
        if (sound != null)
        {
            sound.Play();
        }
    }
}
