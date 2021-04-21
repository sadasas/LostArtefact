using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scenelvl1mulai : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject sceneawal;
    public Camera main;
    private int a = 2;
    private int scene;
    public GameObject percakapanmulai;
    public GameObject image;
    public Text pertama;
    public Text kedua;
    public Text ketiga;
    public GameObject dm;

    public Text keempat;

    public GameObject apus;

    // Start is called before the first frame update
    public void Start()
    {
        scene = PlayerPrefs.GetInt("sceneawal", 1);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (a > scene)
        {
            kedua.gameObject.SetActive(false);
            ketiga.gameObject.SetActive(false);
            keempat.gameObject.SetActive(false);

            percakapanmulai.SetActive(true);

            main.gameObject.SetActive(false);
            sceneawal.SetActive(true);
            StartCoroutine(bingung());
            StartCoroutine(text());
            image.SetActive(false);
            dm.SetActive(false);
        }
    }

    private IEnumerator bingung()
    {
        yield return new WaitForSeconds(1f);

        LeanTween.rotate(sceneawal, new Vector3(0f, -142.11f, 0f), 1f);

        yield return new WaitForSeconds(1.5f);

        LeanTween.rotate(sceneawal, new Vector3(-42.4f, -109.41f, 0f), 1.5f);

        yield return new WaitForSeconds(1.6f);
        LeanTween.rotate(sceneawal, new Vector3(0f, -85.23f, 0f), 1f);
        yield return new WaitForSeconds(1.2f);
        LeanTween.rotate(sceneawal, new Vector3(-15f, 55.3f, 0f), 2f);
        yield return new WaitForSeconds(2.3f);
        LeanTween.rotate(sceneawal, new Vector3(0f, -85.23f, 0f), 2f);
        yield return new WaitForSeconds(2f);
        PlayerPrefs.SetInt("sceneawal", 5);

        main.gameObject.SetActive(true);

        image.SetActive(true);

        sceneawal.SetActive(false);
        tutorial.SetActive(true);
        Collider colider = apus.GetComponent<Collider>();
        colider.gameObject.SetActive(false);
        dm.SetActive(true);
    }

    private IEnumerator text()
    {
        yield return new WaitForSeconds(3f);
        pertama.gameObject.SetActive(false);
        kedua.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);
        kedua.gameObject.SetActive(false);
        ketiga.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);
        ketiga.gameObject.SetActive(false);
        keempat.gameObject.SetActive(true);

        yield return new WaitForSeconds(1f);

        keempat.gameObject.SetActive(false);
    }
}