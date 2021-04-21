using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ngomongpenyimpanan : MonoBehaviour
{
    public GameObject ngomonglabirinn;
    public Text pertama;
    public Text kedua;

    private int a = 2;
    private int scene;
    public GameObject apus;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("ngocehpenyimpanan", 1);
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
            kedua.gameObject.SetActive(false);
        }
    }

    private IEnumerator ngocehl()
    {
        yield return new WaitForSeconds(1);
        pertama.gameObject.SetActive(false);

        kedua.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        kedua.gameObject.SetActive(false);
        Collider colider = apus.GetComponent<Collider>();
        colider.gameObject.SetActive(false);

        PlayerPrefs.SetInt("ngocehpenyimpanan", 5);
    }
}