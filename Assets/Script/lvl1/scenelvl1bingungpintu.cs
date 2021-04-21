using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scenelvl1bingungpintu : MonoBehaviour
{
    public GameObject scenebingungpintu;
    public Camera main;
    private int a = 2;
    private int scene;
    public GameObject image;
    public GameObject FPS;
    public GameObject percakapanbingungpintu;
    public Text pertama;
    public Text kedua;
    public GameObject trigger;
    public Text ketiga;

    public Text keempat;

    public GameObject dm;
    public GameObject apus;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("scenepintu", 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (a > scene)
        {
            dm.SetActive(false);
            image.SetActive(false);
            main.gameObject.SetActive(false);
            scenebingungpintu.SetActive(true);
            StartCoroutine(bingungs());
            percakapanbingungpintu.SetActive(true);
            kedua.gameObject.SetActive(false);
            ketiga.gameObject.SetActive(false);
            keempat.gameObject.SetActive(false);
            PlayerPrefs.SetInt("scenepintu", 5);
            FPS.SetActive(false);
        }
    }

    private IEnumerator bingungs()
    {
        Vector3 naik = new Vector3(0, 5, 0);

        LeanTween.rotate(scenebingungpintu, new Vector3(-40.1f, 0f, 0f), 2f);

        yield return new WaitForSeconds(3f);
        pertama.gameObject.SetActive(false);
        kedua.gameObject.SetActive(true);

        LeanTween.rotate(scenebingungpintu, new Vector3(0f, 0f, 0f), 2f);
        yield return new WaitForSeconds(2);
        kedua.gameObject.SetActive(false);
        ketiga.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        ketiga.gameObject.SetActive(false);
        keempat.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        keempat.gameObject.SetActive(false);

        scenebingungpintu.SetActive(false);
        main.gameObject.SetActive(true);

        dm.SetActive(true);
        image.SetActive(true);
        trigger.SetActive(false);
        FPS.SetActive(true);
        Collider colider = apus.GetComponent<Collider>();
        colider.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}