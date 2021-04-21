using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minnima : MonoBehaviour
{
    public GameObject Minimap;
    public KeyCode[] keyminimap;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        for (int i = 0; i < keyminimap.Length; i++)
        {
            if (Input.GetKeyDown(keyminimap[i]))
            {
                Minimap.SetActive(!Minimap.activeSelf);
                break;
            }
        }
    }
}