using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementExpanded : PlayerMovement
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position.y <= 1.05f)
            {
                rb.AddForce(Vector3.up * 1000);
            }
        }

        if (rb.position.y < 0.75f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
