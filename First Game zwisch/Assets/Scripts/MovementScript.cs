using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    
    private void FixedUpdate()
    {
        if (Input.GetKey("w")){
        rb.AddForce(0,0, speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    
    }

            if (Input.GetKey("s")){
        rb.AddForce(0,0, -speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    
    }
}
}
