using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    public GameObject LoadingScene;
    public Slider slider;
    public GameObject LoadingScenelvl2;
    public GameObject LoadingScenelvl3;
    public Slider sliderlvl2;
    public Slider sliderlvl3;

    public GameObject LoadingScenePauseMenu;
    public Slider SliderLoadingScenePauseMenu;

    private void Start()
    {
    }

    private void Update()
    {
    }

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    public void LoadLevel2(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronouslylvl2(sceneIndex));
    }

    public void LoadLevel3(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronouslylvl3(sceneIndex));
    }

    public void LoadMainMenu(int sceneIndex)
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
        PlayerPrefs.DeleteKey("ngocehruangapa");
        PlayerPrefs.DeleteKey("ngocehbuntu2");
        PlayerPrefs.DeleteKey("ngocehkubus2");
        PlayerPrefs.DeleteKey("ngocehsepert");

        PlayerPrefs.DeleteKey("simpandlu");
        PlayerPrefs.DeleteKey("ngocehmirip");

        PlayerPrefs.DeleteKey("ngocehkotak");

        StartCoroutine(LoadAsynchronously2(sceneIndex));
    }

    private IEnumerator LoadAsynchronously(int sceneIndex)
    {
        LoadingScene.SetActive(true);
        yield return new WaitForSeconds(10f);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 2f);

            slider.value = progress;

            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator LoadAsynchronouslylvl2(int sceneIndex)
    {
        LoadingScenelvl2.SetActive(true);
        yield return new WaitForSeconds(9f);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 2f);

            sliderlvl2.value = progress;

            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator LoadAsynchronouslylvl3(int sceneIndex)
    {
        LoadingScenelvl3.SetActive(true);
        yield return new WaitForSeconds(9f);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 2f);

            sliderlvl3.value = progress;

            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator LoadAsynchronously2(int sceneIndex)
    {
        LoadingScenePauseMenu.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 2f);
            SliderLoadingScenePauseMenu.value = progress;
            Debug.Log("progress");
            yield return new WaitForSeconds(1f);
            ;
        }
    }
}