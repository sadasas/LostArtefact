using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mengapabanyakbox : MonoBehaviour
{
    public GameObject text;
    private int scene;
    private int a = 2;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("scenebanyakbox", 1);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (a > scene)
            StartCoroutine(bingung());
    }

    private IEnumerator bingung()

    {
        text.SetActive(true);

        yield return new WaitForSeconds(2f);
        text.SetActive(false);
        PlayerPrefs.SetInt("scenebanyakbox", 5);
    }
}