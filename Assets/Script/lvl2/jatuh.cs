using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jatuh : MonoBehaviour
{
    public AudioSource playaudio;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        playaudio.Play();
    }
}