using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reload : MonoBehaviour
{
    private string player = "Player";
    public GameObject tutorial;

    public GameObject keempat;

    private int tutor;

    // Start is called before the first frame update
    private void Start()
    {
        tutor = PlayerPrefs.GetInt("reload", 1);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            keempat.SetActive(false);
            PlayerPrefs.SetInt("reload", 5);
            PlayerPrefs.SetInt("sceneawal", 5);
            PlayerPrefs.SetInt("reload", 5);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(player))
        {
            if (tutor < 2)
            {
                keempat.SetActive(true);
            }
        }
    }
}