using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    public bool isUsed;
    public int a;
    private int b;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        b = PlayerPrefs.GetInt("kotakapalagi", 1);
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isUsed == false)
        {
            isUsed = true;
            Debug.Log($"Checkpoint{gameObject.name}");
            gm.lastCheckPointPos = transform.position;
        }
    }
}