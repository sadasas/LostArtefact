using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelControl : MonoBehaviour
{
    public Transform groundCheck;
    public Transform groundCheck2;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private bool isGrounded;
    private bool isBerdiri;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        isBerdiri = Physics.CheckSphere(groundCheck2.position, groundDistance, groundMask);

        if (isGrounded)
        {
            Debug.Log("berdiri");
        }
        else if (isBerdiri)
        {
            Debug.Log("headstand");
        }
        else
        {
            Debug.Log("tidur");
        }
    }
}