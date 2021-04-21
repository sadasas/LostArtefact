using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster instance;
    public Vector3 lastCheckPointPos;
    public PlayerInventory inventory;
    public List<Vector3> boxLastpos = new List<Vector3>();
    public List<bool> isCheckpointUsed = new List<bool>();
    public List<string> lastItem = new List<string>();
    public List<bool> keyPickedUp = new List<bool>();

    //public BoxSlot[] boxDoneArray;

    private void Start()
    {
    }

    public void checkKeyitem(List<keyController> _keyItem)
    {
        keyPickedUp.Clear();
        foreach (var key in _keyItem)
        {
            keyPickedUp.Add(key.isPickedUp);
        }
    }

    public void checkCheckpoint(List<Checkpoint> _checkpoint)
    {
        isCheckpointUsed.Clear();
        foreach (var checkpoint in _checkpoint)
        {
            isCheckpointUsed.Add(checkpoint.isUsed);
        }
    }

    public void registerPos(List<BoxSlot> _box)
    {
        boxLastpos.Clear();
        foreach (var box in _box)
        {
            if (box.isOnCatcher == true)
            {
                boxLastpos.Add(box.transform.position);
            }
            else
            {
                boxLastpos.Add(Vector3.zero);
            }
        }
    }

    public void saveItem(List<string> _item)
    {
        lastItem.Clear();
        lastItem.AddRange(_item);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void Update()
    {
        if (inventory == null)
        {
            inventory = GameObject.Find("DetectionManager").GetComponent<PlayerInventory>();
        }
    }
}