using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LockerControl2 : MonoBehaviour
{
    [SerializeField] private string nama;
    [SerializeField] private TextMeshProUGUI indicator;
    public LevelLoader loading;
    public GameObject acid;
    public GameObject text;

    public Slider slider;
    public GameObject LoadingScene;
    public int sceneIndex;

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
            StartCoroutine(sceneacid());
            StartCoroutine(Cutscene());
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
        LeanTween.scaleX(this.gameObject, 0, 1f);

        yield return new WaitForSeconds(0);
    }

    private IEnumerator Cutscene()
    {
        text.SetActive(true);

        yield return new WaitForSeconds(3f);
        text.SetActive(false);

        LoadingScene.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 2f);

            slider.value = progress;

            yield return null;
        }
    }
}