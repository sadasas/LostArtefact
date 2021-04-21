using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private List<string> keyItem = new List<string>();

    [SerializeField] private TextMeshProUGUI IndicatorText;

    private string listNamaItem;

    private void Start()
    {
        keyItem.AddRange(GameMaster.instance.lastItem);
    }

    public void getKey(string namaItem)
    {
        keyItem.Add(namaItem);
        listNamaItem = "";

        foreach (var itemName in keyItem)
        {
            listNamaItem += $"{itemName} \n";
        }

        IndicatorText.text = "Inventory :\n" + listNamaItem;
        GameMaster.instance.saveItem(keyItem); //save item ke list
    }

    public bool isPlayerHasKey(string namaItem)
    {
        Debug.Log($"keychecker {namaItem}");
        foreach (var item in keyItem)
        {
            if (item == namaItem)
            {
                return true;
            }
        }
        return false;
    }
}