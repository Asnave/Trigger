using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public AudioSource soundToPlay;

    void OnTriggerEnter(Collider other)
    {
        soundToPlay.Play();
    }
}
