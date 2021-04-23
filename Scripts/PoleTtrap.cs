using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoleTtrap : MonoBehaviour
{
    public float torque;
    public Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
     if(rb.angularVelocity.x>-0.6f)   
            rb.AddTorque(new Vector3(-1, 0, 0) * torque * 0.5f);
         
    }
}
