﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jalanbuntu2 : MonoBehaviour
{
    public GameObject ngomonglabirinn;
    public Text pertama;

    private int a = 2;
    private int scene;

    // Start is called before the first frame update
    private void Start()
    {
        scene = PlayerPrefs.GetInt("ngocehbuntu2", 1);
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
        yield return new WaitForSeconds(1);
        pertama.gameObject.SetActive(false);
        PlayerPrefs.SetInt("ngocehbuntu2", 5);
    }
}