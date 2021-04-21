using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateControl2 : MonoBehaviour
{
    public GameObject mainkamera;
    public int KAMERA;
    private bool isPressed;
    public GameObject pintu;

    public GameObject camera1;

    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    public AudioSource playaudio;
    public AudioSource playaudio2;

    private void OnTriggerEnter(Collider other)
    {
        playaudio.Play();

        isPressed = true;

        StartCoroutine(Objekerak());

        Debug.Log($"Disentuh {other.gameObject.name}");

        if (KAMERA == 1)
        {
            mainkamera.SetActive(false);
            camera1.SetActive(true);
        }
        if (KAMERA == 2)
        {
            mainkamera.SetActive(false);
            camera2.SetActive(true);
        }
        if (KAMERA == 3)
        {
            mainkamera.SetActive(false);
            camera3.SetActive(true);
        }
        if (KAMERA == 4)
        {
            mainkamera.SetActive(false);
            camera4.SetActive(true);
        }
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

        LeanTween.move(pintu, pintu.transform.position + naik, 1.5f);
        yield return new WaitForSeconds(4);
        mainkamera.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
    }
}