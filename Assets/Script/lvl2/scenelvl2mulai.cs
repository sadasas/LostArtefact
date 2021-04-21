using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scenelvl2mulai : MonoBehaviour
{
    public GameObject sceneawallvl2;
    public Camera main;
    private int a = 2;
    private int scene;
    public GameObject image;
    public GameObject percakapanmulailvl2;
    public Text pertama;
    public Text kedua;
    public Text ketiga;
    public Text keempat;
    public GameObject fps;
    public GameObject apus;

    public GameObject dm;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("sceneawallvl2", 1);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (a > scene)
        {
            pertama.gameObject.SetActive(false);

            kedua.gameObject.SetActive(false);
            ketiga.gameObject.SetActive(false);
            keempat.gameObject.SetActive(false);

            percakapanmulailvl2.SetActive(true);
            dm.SetActive(false);
            main.gameObject.SetActive(false);
            sceneawallvl2.SetActive(true);
            StartCoroutine(bingung());
            StartCoroutine(text());

            image.SetActive(false);
        }
    }

    private IEnumerator bingung()
    {
        yield return new WaitForSeconds(1f);
        LeanTween.rotate(sceneawallvl2, new Vector3(-19.2f, 292.92f, 0f), 1.5f);

        yield return new WaitForSeconds(2f);

        LeanTween.rotate(sceneawallvl2, new Vector3(-47.06f, 403.8f, 0f), 1f);

        yield return new WaitForSeconds(1.2f);

        LeanTween.rotate(sceneawallvl2, new Vector3(3.4f, 446f, 0f), 0.9f);
        yield return new WaitForSeconds(0.9f);
        LeanTween.rotate(sceneawallvl2, new Vector3(0f, 90f, 0f), 0.9f);
        yield return new WaitForSeconds(0.9f);

        yield return new WaitForSeconds(0.9f);

        LeanTween.move(sceneawallvl2, new Vector3(12f, 3.61f, -2f), 1.5f);

        yield return new WaitForSeconds(3);
        LeanTween.move(fps, new Vector3(12f, 3.61f, -2f), 1.5f);

        PlayerPrefs.SetInt("sceneawallvl2", 5);

        main.gameObject.SetActive(true);
        dm.SetActive(true);
        image.SetActive(true);

        sceneawallvl2.SetActive(false);

        Collider colider = apus.GetComponent<Collider>();
        colider.gameObject.SetActive(false);
    }

    private IEnumerator text()
    {
        pertama.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        pertama.gameObject.SetActive(false);

        kedua.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        kedua.gameObject.SetActive(false);

        ketiga.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        ketiga.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        keempat.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        keempat.gameObject.SetActive(false);
    }
}