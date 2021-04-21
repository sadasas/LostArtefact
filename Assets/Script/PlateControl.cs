using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateControl : MonoBehaviour
{
    private bool isPressed;
    public GameObject pintu;
    public GameObject scenepintu;
    public Camera main;
    public GameObject image;
    public GameObject pintukosong;

    public GameObject dm;
    public AudioSource playaudio;
    public AudioSource playaudio2;
    public GameObject ohbeginicaramembukanya;

    private void OnTriggerEnter(Collider other)
    {
        playaudio.Play();

        dm.SetActive(false);
        isPressed = true;
        main.gameObject.SetActive(false);
        scenepintu.SetActive(true);
        StartCoroutine(Objekerak());
        image.SetActive(false);
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

        LeanTween.move(scenepintu, new Vector3(-40.7299995f, 2.77999997f, -12.6300001f), 2f);
        yield return new WaitForSeconds(0.1f);
        LeanTween.move(scenepintu, new Vector3(-36.8199997f, 5.57000017f, -9.14000034f), 2f);
        LeanTween.rotate(scenepintu, new Vector3(4.37000513f, 356.73999f, 0f), 2f);
        yield return new WaitForSeconds(2);
        playaudio2.Play();

        LeanTween.move(pintu, pintu.transform.position + naik, 3f);
        yield return new WaitForSeconds(4);

        main.gameObject.SetActive(true);

        pintukosong.SetActive(true);
        dm.SetActive(true);
        scenepintu.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        ohbeginicaramembukanya.SetActive(true);
        yield return new WaitForSeconds(2f);
        ohbeginicaramembukanya.SetActive(false);
    }
}