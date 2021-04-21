using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyController : MonoBehaviour
{
    private GameMaster gm;

    public bool isPickedUp;

    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    private void Update()
    {
        HiddenObject();
    }

    private void HiddenObject()
    {
        if (isPickedUp == true)
        {
            gameObject.SetActive(false);
        }
    }
}