using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSel : MonoBehaviour
{
    public Image Lock1;
    public Image Lock2;

    public Image imgopen;
    public Image imgopen2;

    //public Image img;
    public Sprite locked;

    public Sprite opem;
    public Sprite opem2;

    public Button[] lvlButton;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 1;
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i < lvlButton.Length; i++)
        {
            if (i + 2 > levelAt)
            {
                lvlButton[i].interactable = false;

                Lock1.gameObject.GetComponent<Image>().sprite = locked;
                imgopen.gameObject.GetComponent<Image>().enabled = false;
                imgopen2.gameObject.GetComponent<Image>().enabled = false;
                Lock2.gameObject.GetComponent<Image>().sprite = locked;
            }
            if (lvlButton[1].interactable == true)
            {
                imgopen.gameObject.GetComponent<Image>().enabled = true;
                imgopen.gameObject.GetComponent<Image>().sprite = opem;
            }
            if (lvlButton[2].interactable == true)
            {
                imgopen2.gameObject.GetComponent<Image>().enabled = true;
                imgopen2.gameObject.GetComponent<Image>().sprite = opem2;
            }
        }
    }

    public void savvse()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}