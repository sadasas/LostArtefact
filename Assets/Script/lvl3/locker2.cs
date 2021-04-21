using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class locker2 : MonoBehaviour
{
    [SerializeField] private string nama;
    [SerializeField] private TextMeshProUGUI indicator;

    public GameObject text;
    public GameObject dm;
    public Slider slider;
    public GameObject LoadingScene;
    public int sceneIndex;
    public AudioSource playaudio;
    public GameMaster gm;
    public GameObject kanan;
    public GameObject kiri;

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
            PlayerPrefs.DeleteKey("sceneawallvl2");
            PlayerPrefs.DeleteKey("ngocehlab");
            PlayerPrefs.DeleteKey("ngocehpenyimpanan");
            PlayerPrefs.DeleteKey("melihatibu");
            PlayerPrefs.SetInt("levelAt", 4);

            playaudio.Play();
            dm.SetActive(false);
            StartCoroutine(Cutscene());
            StartCoroutine(sceneacid());
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
        LeanTween.rotate(kanan, new Vector3(0f, -90f, 0f), 1f);
        LeanTween.rotate(kiri, new Vector3(0f, -90f, 0f), 1f);

        yield return new WaitForSeconds(0);
    }

    private IEnumerator Cutscene()
    {
        yield return new WaitForSeconds(2f);
        text.SetActive(true);

        yield return new WaitForSeconds(2f);

        text.SetActive(false);
        dm.SetActive(true);

        LoadingScene.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        yield return new WaitForSeconds(4f);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 2f);

            slider.value = progress;

            yield return null;
        }
    }
}