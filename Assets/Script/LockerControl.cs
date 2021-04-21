using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LockerControl : MonoBehaviour
{
    [SerializeField] private string nama;
    [SerializeField] private TextMeshProUGUI indicator;

    public GameObject text;
    public int pilih;
    public GameObject dm;
    public Slider slider;
    public GameObject LoadingScene;
    public int sceneIndex;
    public GameObject img;
    public AudioSource playaudio;
    public GameMaster gm;
    public GameObject kanan;
    public GameObject kiri;
    public GameObject rantai;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void Buka()
    {
        if (GameMaster.instance.inventory.isPlayerHasKey(nama))
        {
            if (pilih == 1)
            {
                PlayerPrefs.DeleteKey("scenemenanglvl3");
                PlayerPrefs.DeleteKey("sceneawallvl3");
                PlayerPrefs.DeleteKey("sceneawallvl2");
                PlayerPrefs.DeleteKey("ngocehlab");
                PlayerPrefs.DeleteKey("ngocehpenyimpanan");
                PlayerPrefs.DeleteKey("melihatibu");
                PlayerPrefs.DeleteKey("sceneawal");

                PlayerPrefs.DeleteKey("scenepintu");

                PlayerPrefs.DeleteKey("ngocehlab3");
                PlayerPrefs.DeleteKey("ngocehtangga");
                PlayerPrefs.DeleteKey("ngocehlab2");
                PlayerPrefs.DeleteKey("ngocehruangttt");
                PlayerPrefs.DeleteKey("ngocehlll");
                PlayerPrefs.SetInt("levelAt", 4);

                playaudio.Play();
                img.SetActive(false);
                dm.SetActive(false);
                StartCoroutine(Cutscene());
                StartCoroutine(sceneacid());
            }
            else if (pilih == 2)
            {
                StartCoroutine(sceneacid2());
            }
        }
        else
        {
            indicator.text = $"Memerlukan {nama}";
            StartCoroutine(hideIndicatorText());
        }
    }

    private IEnumerator hideIndicatorText()
    {
        yield return new WaitForSeconds(1);
        indicator.text = "";
    }

    private IEnumerator sceneacid()
    {
        LeanTween.alpha(rantai, 0f, 0.5f);
        LeanTween.rotate(kanan, new Vector3(0f, -90f, 0f), 1f).setDelay(0.5f);
        LeanTween.rotate(kiri, new Vector3(0f, -90f, 0f), 1f).setDelay(0.5f);

        yield return new WaitForSeconds(0);
    }

    private IEnumerator sceneacid2()
    {
        LeanTween.scaleX(this.gameObject, 0, 1f);
        yield return new WaitForSeconds(0);
    }

    private IEnumerator rata()
    {
        yield return new WaitForSeconds(4.0f);
        rantai.SetActive(false);
    }

    private IEnumerator Cutscene()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(3f);
        text.SetActive(false);

        LoadingScene.SetActive(true);
        yield return new WaitForSeconds(8f);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 2f);

            slider.value = progress;

            yield return null;
        }
    }
}