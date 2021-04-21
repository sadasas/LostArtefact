using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ibumati : MonoBehaviour
{
    private int a = 1;
    private int tutor;
    public Camera main;
    public GameObject fps;
    public GameObject sceneibu;
    public GameObject sceneibuobject;

    public GameObject image;
    public GameObject percakapan;
    public Text pertama;
    public Text kedua;
    public Text ketiga;
    public Text keempat;
    public Text kelima;

    public Text keenam;
    public Text ketujuh;
    public Text kelapan;

    public GameObject apus;

    // Start is called before the first frame update
    private void Start()
    {
        tutor = PlayerPrefs.GetInt("melihatibu", 2);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (a < tutor)
        {
            image.SetActive(false);
            main.gameObject.SetActive(false);
            sceneibu.SetActive(true);
            sceneibuobject.SetActive(true);
            ketiga.gameObject.SetActive(false);
            kedua.gameObject.SetActive(false);
            keempat.gameObject.SetActive(false);
            kelima.gameObject.SetActive(false);
            keenam.gameObject.SetActive(false);
            ketujuh.gameObject.SetActive(false);
            kelapan.gameObject.SetActive(false);

            StartCoroutine(Scene());
            StartCoroutine(kata());
        }
    }

    private void OnTriggerExit(Collider other)
    {
    }

    private IEnumerator Scene()
    {
        yield return new WaitForSeconds(3f);
        LeanTween.move(sceneibu, new Vector3(56.29f, -4.2f, -14.7f), 4f);

        yield return new WaitForSeconds(7f);

        LeanTween.move(sceneibu, new Vector3(55.16f, -4.7f, -14.98f), 1.5f);
        LeanTween.rotate(sceneibu, new Vector3(49.3f, 149.4f, 0f), 1.5f);

        yield return new WaitForSeconds(9f);
        LeanTween.move(fps, new Vector3(55.16f, -4.7f, -14.98f), 0f);
        image.SetActive(true);
        sceneibu.SetActive(false);
        sceneibuobject.SetActive(false);
        main.gameObject.SetActive(true);
        Collider colider = apus.GetComponent<Collider>();
        colider.gameObject.SetActive(false);
    }

    private IEnumerator kata()
    {
        percakapan.SetActive(true);
        pertama.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);

        pertama.gameObject.SetActive(false);
        kedua.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);

        kedua.gameObject.SetActive(false);

        ketiga.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        LeanTween.rotate(sceneibu, new Vector3(43.9f, 228.7f, 0f), 1f);

        ketiga.gameObject.SetActive(false);
        keempat.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);
        keempat.gameObject.SetActive(false);
        kelima.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        kelima.gameObject.SetActive(false);
        keenam.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);
        ketujuh.gameObject.SetActive(true);
        keenam.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        ketujuh.gameObject.SetActive(false);
        kelapan.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        kelapan.gameObject.SetActive(false);
    }
}