using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ngomongloker : MonoBehaviour
{
    public GameObject ngomonglokerr;
    public Text pertama;
    public Text kedua;
    private int a = 2;
    private int scene;
    public GameObject trigger;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("ngocehloker", 1);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (a > scene)
        {
            StartCoroutine(ngoceh());
            ngomonglokerr.SetActive(true);
            kedua.gameObject.SetActive(false);
        }
    }

    private IEnumerator ngoceh()
    {
        pertama.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        pertama.gameObject.SetActive(false);
        kedua.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);
        kedua.gameObject.SetActive(false);
        PlayerPrefs.SetInt("ngocehloker", 5);
        trigger.SetActive(false);
    }
}