using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateControl3 : MonoBehaviour
{
    private bool isPressed;
    public GameObject pintu;
    public AudioSource playaudio;
    public AudioSource playaudio2;

    private void OnTriggerEnter(Collider other)
    {
        isPressed = true;
        playaudio.Play();

        StartCoroutine(Objekerak());

        Vector3 naik = new Vector3(0, 5, 0);

        Debug.Log($"Disentuh {other.gameObject.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        isPressed = false;
        Vector3 turun = new Vector3(0, -5, 0);

        LeanTween.move(pintu, pintu.transform.position + turun, 0.5f);
    }

    private IEnumerator Objekerak()
    {
        Vector3 naik = new Vector3(0, 5, 0);
        playaudio2.Play();

        LeanTween.move(pintu, pintu.transform.position + naik, 1f);

        yield return new WaitForSeconds(1);
    }
}