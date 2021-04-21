using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introend : MonoBehaviour
{
    private int scene;
    private int end;

    private int a = 2;
    public GameObject text;
    public GameObject enddd;

    public GameObject introbutton;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("intros", 1);
        end = PlayerPrefs.GetInt("endd", 10);
    }

    // Update is called once per frame
    private void Update()
    {
        if (a > scene)
        {
            text.SetActive(true);
        }

        if (a > end)
        {
            enddd.SetActive(true);
        }

        if (a < scene && a < end)
        {
            introbutton.SetActive(true);
        }
    }

    public void mulai()
    {
        text.SetActive(false);
        introbutton.SetActive(false);
        introbutton.SetActive(true);
        PlayerPrefs.SetInt("intros", 5);
        PlayerPrefs.SetInt("endd", 10);

        enddd.SetActive(false);
    }
}