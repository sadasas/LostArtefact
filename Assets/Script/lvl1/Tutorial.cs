using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    private int a = 1;
    public GameObject[] tutoriallist;
    private bool tutorbro = false;
    private int tutorbroindex;
    public GameObject tutorial;
    public float waitTime = 2f;
    private int wasd;

    public void Start()
    {
        int tutor = PlayerPrefs.GetInt("tutorr", 3);

        if (a < tutor)
        {
            tutorbro = true;
        }
    }

    public void skip()
    {
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            PlayerPrefs.DeleteKey("tutorr");
        }

        if (tutorbro == true)
        {
            for (int c = 0; c < tutoriallist.Length; c++)
            {
                if (c == tutorbroindex)
                {
                    tutoriallist[c].SetActive(true);
                }
                else
                {
                    tutoriallist[c].SetActive(false);
                }
            }

            if (tutorbroindex == 0)
            {
                for (int d = 0; d < 5; d++)
                {
                    if (d == wasd)
                    {
                        if (wasd > 3)
                        {
                            tutorbroindex++;
                        }
                    }
                }

                if (Input.GetKeyDown(KeyCode.W))
                {
                    wasd++;
                    Debug.Log("w");
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    wasd++;
                    Debug.Log("a");
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    wasd++;
                    Debug.Log("d");
                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    wasd++;
                    Debug.Log("s");
                }
            }
            else if (tutorbroindex == 1)
            {
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    tutorbroindex++;
                    Debug.Log("sadsadDAFAD");
                }
            }
            else if (tutorbroindex == 2)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    tutorbroindex++;
                    Debug.Log("DAcdacFAD");
                    PlayerPrefs.SetInt("tutorr", 0);
                }
            }
        }
    }
}