using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gm : MonoBehaviour
{
    public PlayerPos gmm;

    private int c = 1;

    // Start is called before the first frame update
    private void Start()
    {
        int b = PlayerPrefs.GetInt("ji", 1);
        if (c == b)
        {
            gmm.RestartGame();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerPrefs.SetInt("ji", 2);
    }

    private void OnTriggerEnter(Collider other)
    {
    }
}