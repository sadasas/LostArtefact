using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    public GameObject Minimap;
    public KeyCode[] keyminimap;

    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    // Start is called before the first frame update

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

    public void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}