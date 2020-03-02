using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 250f;

    /*// Start is called before the first frame update
    void Start()
    {
    }*/

    // Update is called once per frame
    void FixedUpdate() //ha fizikát változtatunk benne jobb ha fixedupdate mint update
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

        if (rb.position.y < 0.75f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            /*if ((BackgroundMusic1.BGMusic != null) && (!(BackgroundMusic.BGMusic.gameObject.GetComponent<AudioSource>().isPlaying)))
            {
                if (BackgroundMusic1.BGMusic.gameObject.GetComponent<AudioSource>().isPlaying)
                {
                    BackgroundMusic1.BGMusic.gameObject.GetComponent<AudioSource>().Stop();
                    BackgroundMusic.BGMusic.gameObject.GetComponent<AudioSource>().Play();
                }
            }*/
            SceneManager.LoadScene("Menu");
        }
    }
}
