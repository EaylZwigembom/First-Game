using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    
    void FixedUpdate()
    {
        if (Input.GetKey("w")){
        rb.AddForce(0,0, speed * Time.deltaTime, ForceMode.VelocityChange);
    
    }

            if (Input.GetKey("s")){
        rb.AddForce(0,0, -speed * Time.deltaTime, ForceMode.VelocityChange);
    
    }
}
}