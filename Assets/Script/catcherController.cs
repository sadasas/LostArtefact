using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catcherController : MonoBehaviour
{
    private string selectableTag = "Selectable";
    public AudioSource jatuh;
    public int a;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other) // other ini pasti objek yang nabrak (ke triggier)
    {
        if (other.gameObject.CompareTag(selectableTag)) // jika ini box
        {
            other.gameObject.GetComponent<BoxSlot>().isOnCatcher = true;

            LeanTween.move(other.gameObject, this.transform.position, 0.5f);

            if (a == 1)
            {
                jatuh.Play();
            }
        }
    }
}