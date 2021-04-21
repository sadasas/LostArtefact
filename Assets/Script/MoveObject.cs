using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject item;
    public GameObject tempParent;
    public Transform guide;
    public bool isLifted;
    public bool isPintuStillMoving;

    // Start is called before the first frame update
    private void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseDown()
    {
        if (!isPintuStillMoving)
        {
            liftObject();
        }
    }

    private void OnMouseUp()
    {
        if (item.transform.position == guide.transform.position)
        {
            releaseObject();
        }
    }

    private void liftObject()
    {
        isLifted = true;

        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform.parent;
    }

    private void releaseObject()
    {
        isLifted = false;

        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        item.transform.position = guide.transform.position;
    }
}