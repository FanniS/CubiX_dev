using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMObstacleMovement : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    public Rigidbody rb;
    public float forwardForce = 1000f;
    public Transform obstacle;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);

    }
}
