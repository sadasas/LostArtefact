using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ngomongpintukeluar : MonoBehaviour
{
    public GameObject ngomonglabirinn;
    public Text pertama;
    public Text kedua;

    public Text ketiga;

    private int a = 2;
    private int scene;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("ngocehlll", 1);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (a > scene)
        {
            StartCoroutine(ngocehl());
            ngomonglabirinn.SetActive(true);
        }
    }

    private IEnumerator ngocehl()
    {
        pertama.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);
        pertama.gameObject.SetActive(false);
        kedua.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        kedua.gameObject.SetActive(false);
        ketiga.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        ketiga.gameObject.SetActive(false);

        PlayerPrefs.SetInt("ngocehlll", 5);
    }
}