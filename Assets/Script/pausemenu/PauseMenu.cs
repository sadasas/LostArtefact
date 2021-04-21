using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
    public KeyCode[] pausemenukey;
    public LevelLoader loading;
    public PlayerPos checkpoint;

    private float fixedDeltaTime;

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void ShowMouse()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void HideMouse()

    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.DeleteAll();
        }

        for (int i = 0; i < pausemenukey.Length; i++)
        {
            if (Input.GetKeyDown(pausemenukey[i]))
            {
                PlayerPrefs.SetInt("tutor", 0);
                pausemenu.SetActive(!pausemenu.activeSelf);

                if (pausemenu.activeSelf)
                {
                    Time.timeScale = 0;
                    ShowMouse();
                }
                else
                {
                    Time.timeScale = 1;

                    HideMouse();
                }
                break;
            }
        }
    }

    public void MainMenu(int sceneIndex)
    {
        loading.LoadMainMenu(sceneIndex);
    }

    public void Checkpoint()
    {
        checkpoint.RestartGame();
    }
}