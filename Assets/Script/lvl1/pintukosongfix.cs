using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pintukosongfix : MonoBehaviour
{
    public GameObject pintukosongbacot;
    public GameObject pertama;
    public GameObject kedua;
    public GameObject pintuuu;

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
        pintukosongbacot.SetActive(true);
        StartCoroutine(bacot());
        kedua.SetActive(false);
    }

    private IEnumerator bacot()
    {
        yield return new WaitForSeconds(1f);
        pertama.SetActive(false);
        kedua.SetActive(true);
        yield return new WaitForSeconds(1f);
        kedua.SetActive(false);
        pintuuu.SetActive(false);
    }
}