using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public GameObject dm;

    // Start is called before the first frame update
    private void Start()
    {
        dm.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void exit()
    {
        dm.SetActive(true);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}