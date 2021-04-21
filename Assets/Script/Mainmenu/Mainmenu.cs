using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject kamera;
    public GameObject option;
    public GameObject mainmenu;
    public GameObject levelmenu;
    public GameObject credit;

    public void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("reset data , tutorial, level");
        }
    }

    public void Playlevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Ubahkamera()
    {
        LeanTween.rotate(kamera, new Vector3(88.901f, -215.708f, -35.492f), 1.1f);
        LeanTween.move(kamera, new Vector3(0f, 4.8f, 1.63f), 1.1f);
    }

    public void Balikkamera()
    {
        LeanTween.rotate(kamera, new Vector3(23.81f, -203.709f, 2.043f), 1.1f);
        LeanTween.move(kamera, new Vector3(-0.89f, 4.11f, 6.02f), 1.1f);
    }

    private IEnumerator Bukaoption()
    {
        yield return new WaitForSeconds(1.2f);
        option.SetActive(!option.activeSelf);
    }

    public void BukaOption()
    {
        StartCoroutine(Bukaoption());
    }

    public void TutupOption()
    {
        option.SetActive(false);
    }

    private IEnumerator Bukacredit()
    {
        yield return new WaitForSeconds(1.2f);
        credit.SetActive(!option.activeSelf);
    }

    public void BukaCredit()
    {
        StartCoroutine(Bukacredit());
    }

    public void Tutupcredit()
    {
        credit.SetActive(false);
    }

    public void TutupMainMenu()
    {
        mainmenu.SetActive(false);
    }

    private IEnumerator Bukamainmenu()
    {
        yield return new WaitForSeconds(1.2f);
        mainmenu.SetActive(true);
    }

    public void BukaMainMenu()
    {
        StartCoroutine(Bukamainmenu());
    }

    private IEnumerator Bukalevelmenu()
    {
        yield return new WaitForSeconds(1.2f);
        levelmenu.SetActive(true);
    }

    public void BukaLevelMenu()
    {
        StartCoroutine(Bukalevelmenu());
    }

    public void deletelevel()
    {
        PlayerPrefs.DeleteAll();
    }

    public void exit()
    {
        Application.Quit();
    }
}