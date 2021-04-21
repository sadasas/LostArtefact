using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WIN : MonoBehaviour
{
    //public int nextscene;
    public GameObject text;

    public GameMaster gm;

    public Slider slider;
    public GameObject LoadingScene;
    public int sceneIndex;

    // Start is called before the first frame update
    private void Start()
    {
        // nextscene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerPrefs.DeleteKey("sceneawal");

            PlayerPrefs.DeleteKey("scenepintu");

            PlayerPrefs.DeleteKey("reload");
            PlayerPrefs.SetInt("levelAt", 3);

            StartCoroutine(Cutscene());
        }
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