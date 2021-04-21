using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneawallvl3 : MonoBehaviour
{
    public GameObject sceneawallevel3;
    public Camera main;
    private int a = 2;
    private int scene;
    public GameObject image;
    public GameObject percakapanmulailvl3;
    public Text pertama;
    public Text kedua;
    public Text ketiga;
    public Text keempat;
    public Text kelima;
    public Text enam;
    public Text tujuh;
    public Text lapan;
    public Text sembilan;
    public Text sepuluh;

    public GameObject fps;
    public GameObject apus;
    public GameObject minimap;
    public GameObject rawimage;

    public GameObject maps;
    public GameObject mapasli;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("sceneawallvl3", 1);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (a > scene)
        {
            fps.SetActive(false);
            pertama.gameObject.SetActive(false);

            kedua.gameObject.SetActive(false);
            ketiga.gameObject.SetActive(false);
            keempat.gameObject.SetActive(false);
            kelima.gameObject.SetActive(false);
            enam.gameObject.SetActive(false);
            tujuh.gameObject.SetActive(false);
            lapan.gameObject.SetActive(false);
            sembilan.gameObject.SetActive(false);
            sepuluh.gameObject.SetActive(false);

            percakapanmulailvl3.SetActive(true);

            main.gameObject.SetActive(false);
            sceneawallevel3.SetActive(true);
            StartCoroutine(bingung());
            StartCoroutine(text());
        }
    }

    private IEnumerator bingung()
    {
        LeanTween.rotate(sceneawallevel3, new Vector3(-19.8f, 203.93f, 0f), 1.5f);

        yield return new WaitForSeconds(2f);

        LeanTween.rotate(sceneawallevel3, new Vector3(-7.3f, 150.6f, 0f), 1f);

        yield return new WaitForSeconds(1.2f);

        LeanTween.rotate(sceneawallevel3, new Vector3(0f, 180f, 0f), 1f);
        yield return new WaitForSeconds(1f);

        LeanTween.move(sceneawallevel3, new Vector3(2.19f, 3.801f, -1.43f), 4f);

        yield return new WaitForSeconds(6f);
        minimap.SetActive(true);
        yield return new WaitForSeconds(2f);
        rawimage.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        rawimage.SetActive(true);
        yield return new WaitForSeconds(1f);
        rawimage.SetActive(false);
        yield return new WaitForSeconds(3f);
        minimap.SetActive(false);
        yield return new WaitForSeconds(1f);
        LeanTween.rotate(sceneawallevel3, new Vector3(-14.8f, 141.09f, 0f), 1f);
        yield return new WaitForSeconds(1f);
        LeanTween.rotate(sceneawallevel3, new Vector3(-14.8f, 194.9f, 0f), 1.5f);
        yield return new WaitForSeconds(1.5f);
        LeanTween.rotate(sceneawallevel3, new Vector3(-14.8f, 333.6f, 0f), 1.5f);
        yield return new WaitForSeconds(1.5f);
        LeanTween.rotate(sceneawallevel3, new Vector3(0f, 360f, 0f), 1f);
        yield return new WaitForSeconds(6f);
        LeanTween.move(sceneawallevel3, new Vector3(3.03f, 3.61f, 7.21f), 3f);
        LeanTween.rotate(sceneawallevel3, new Vector3(64.4f, 360f, 0f), 3f);
        yield return new WaitForSeconds(4f);
        maps.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mapasli.SetActive(true);
        yield return new WaitForSeconds(2f);
        mapasli.SetActive(false);
        yield return new WaitForSeconds(1f);
        LeanTween.rotate(sceneawallevel3, new Vector3(0f, 180f, 0f), 1f);
        yield return new WaitForSeconds(1f);

        PlayerPrefs.SetInt("sceneawallvl3", 5);
    }

    private IEnumerator text()
    {
        yield return new WaitForSeconds(1);
        pertama.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        pertama.gameObject.SetActive(false);

        kedua.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        kedua.gameObject.SetActive(false);

        ketiga.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        ketiga.gameObject.SetActive(false);

        keempat.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        keempat.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        kelima.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        kelima.gameObject.SetActive(false);
        enam.gameObject.SetActive(true);
        yield return new WaitForSeconds(9f);
        enam.gameObject.SetActive(false);
        tujuh.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        tujuh.gameObject.SetActive(false);
        lapan.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        lapan.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        sembilan.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        sembilan.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        sepuluh.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        sepuluh.gameObject.SetActive(false);
        main.gameObject.SetActive(true);

        sceneawallevel3.SetActive(false);
        fps.SetActive(true);
        apus.SetActive(false);
    }
}