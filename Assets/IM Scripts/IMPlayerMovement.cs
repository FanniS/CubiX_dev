using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMPlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 120f;

    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0.75f)
        {
            FindObjectOfType<IMGameManager>().IMEndgame();
        }
    }
}
