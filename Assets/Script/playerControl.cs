using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float turningPower = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            rb.AddTorque(turningPower);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb.AddTorque(-turningPower);
        }
    }
}
