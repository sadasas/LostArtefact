using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    [SerializeField] private DetectionManager dm;

    public Transform startPos;

    // Start is called before the first frame update
    private void Start()
    {
        gm = GameMaster.instance;

        Debug.Log($"{gm.lastCheckPointPos}");
        this.transform.position = startPos.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
            PlayerPrefs.SetInt("sceneawal", 5);
            PlayerPrefs.SetInt("reload", 5);
        }
    }

    public void RestartGame()
    {
        gm.checkCheckpoint(dm.CPList);
        gm.registerPos(dm.boxList);
        gm.checkKeyitem(dm.keyList);
        this.transform.position = gm.lastCheckPointPos;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}