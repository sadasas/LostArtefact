using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scenemenanglvl3 : MonoBehaviour
{
    public GameObject scenemenang;
    public Camera main;
    private int a = 2;
    private int scene;
    public GameObject percakapanmulai;
    public GameObject image;
    public Text pertama;
    public Text kedua;
    public Text ketiga;

    public Text keempat;
    public Text kelima;
    public Text keenam;
    public Text ketujuh;
    public Text kelapan;
    public Text kesemnbilan;
    public Text sepuluh;
    public Text sebelas;
    public Text duabelas;
    public Text tigabelas;
    public Text empatbelas;
    public Text limabelas;
    public Text enambelas;
    public Text tujuhbelas;
    public Text delapanbelas;
    public int sceneIndex;

    public GameObject dm;
    public GameObject apus;
    public GameObject win;

    public GameObject bapak;

    public LevelLoader loading;

    private void Start()
    {
        scene = PlayerPrefs.GetInt("scenemenanglvl3", 1);
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
            dm.SetActive(false);
            kedua.gameObject.SetActive(false);
            ketiga.gameObject.SetActive(false);
            keempat.gameObject.SetActive(false);
            kelima.gameObject.SetActive(false);
            keenam.gameObject.SetActive(false);
            ketujuh.gameObject.SetActive(false);
            kelapan.gameObject.SetActive(false);
            kesemnbilan.gameObject.SetActive(false);
            sepuluh.gameObject.SetActive(false);
            sebelas.gameObject.SetActive(false);
            duabelas.gameObject.SetActive(false);
            tigabelas.gameObject.SetActive(false);
            empatbelas.gameObject.SetActive(false);
            limabelas.gameObject.SetActive(false);
            enambelas.gameObject.SetActive(false);
            tujuhbelas.gameObject.SetActive(false);
            delapanbelas.gameObject.SetActive(false);

            percakapanmulai.SetActive(true);
            main.gameObject.SetActive(false);
            scenemenang.SetActive(true);
            StartCoroutine(bingung());
            StartCoroutine(kata());

            image.SetActive(false);
        }
    }

    private IEnumerator bingung()
    {
        LeanTween.move(scenemenang, new Vector3(3f, 7.06f, -85.95f), 1.5f);
        yield return new WaitForSeconds(1.5f);

        LeanTween.rotate(scenemenang, new Vector3(0f, 315.64f, 0f), 1f);

        yield return new WaitForSeconds(1.5f);
        LeanTween.rotate(scenemenang, new Vector3(25.9f, 421.7f, 0f), 1f);
        yield return new WaitForSeconds(1.4f);
        LeanTween.rotate(scenemenang, new Vector3(-52.4f, 356.9f, 0f), 1.5f);

        yield return new WaitForSeconds(2f);
        LeanTween.rotate(scenemenang, new Vector3(0f, 538.04f, 0f), 2f);

        yield return new WaitForSeconds(2f);
        bapak.SetActive(true);
        LeanTween.rotate(scenemenang, new Vector3(17.56f, 538.04f, 0f), 2f);
        yield return new WaitForSeconds(2f);
        LeanTween.rotate(scenemenang, new Vector3(20f, 538.04f, 0f), 2f);

        yield return new WaitForSeconds(48f);
        bapak.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        LeanTween.rotate(scenemenang, new Vector3(0f, 538.04f, 0f), 2f);
        LeanTween.move(scenemenang, new Vector3(3.16f, 7.06f, -87.34f), 2f);
        yield return new WaitForSeconds(2f);
        win.SetActive(true);
        yield return new WaitForSeconds(2f);
        win.SetActive(false);
        dm.SetActive(true);
        loading.LoadLevel(sceneIndex);
        PlayerPrefs.SetInt("endd", 1);
    }

    private IEnumerator kata()
    {
        pertama.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        kedua.gameObject.SetActive(true);
        pertama.gameObject.SetActive(false);
        yield return new WaitForSeconds(3.5f);
        kedua.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        ketiga.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        keempat.gameObject.SetActive(true);
        ketiga.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        kelima.gameObject.SetActive(true);
        keempat.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        keenam.gameObject.SetActive(true);
        kelima.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        ketujuh.gameObject.SetActive(true);
        keenam.gameObject.SetActive(false);
        yield return new WaitForSeconds(3.5f);
        kelapan.gameObject.SetActive(true);
        ketujuh.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        kesemnbilan.gameObject.SetActive(true);
        kelapan.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        sepuluh.gameObject.SetActive(true);
        kesemnbilan.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        sebelas.gameObject.SetActive(true);
        sepuluh.gameObject.SetActive(false);
        yield return new WaitForSeconds(3.5f);
        duabelas.gameObject.SetActive(true);
        sebelas.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        tigabelas.gameObject.SetActive(true);
        duabelas.gameObject.SetActive(false);
        yield return new WaitForSeconds(3.5f);
        empatbelas.gameObject.SetActive(true);
        tigabelas.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        limabelas.gameObject.SetActive(true);
        empatbelas.gameObject.SetActive(false);
        yield return new WaitForSeconds(6f);
        enambelas.gameObject.SetActive(true);
        limabelas.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        tujuhbelas.gameObject.SetActive(true);
        enambelas.gameObject.SetActive(false);
        yield return new WaitForSeconds(3.5f);
        delapanbelas.gameObject.SetActive(true);
        tujuhbelas.gameObject.SetActive(false);
        yield return new WaitForSeconds(3.5f);
        delapanbelas.gameObject.SetActive(false);
    }
}