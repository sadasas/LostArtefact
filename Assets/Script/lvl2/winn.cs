using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winn : MonoBehaviour
{
    public GameObject win;
    public GameObject epilog;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Bukalevelmenu());
    }

    private IEnumerator Bukalevelmenu()
    {
        win.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        win.SetActive(false);
        epilog.SetActive(true);
    }
}