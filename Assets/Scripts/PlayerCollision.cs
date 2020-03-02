using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
    public PlayerMovement movement;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo) //hiba lehet --> odaírni a UnityEngine-t
    {
        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            //Debug.Log("We hit an obstacle");
            movement.enabled = false; //NullReferenceException! Hozzárendelni a PlayerMovement scriptet a PlayerCollision movement változójához!
            FindObjectOfType<GameManager>().Endgame();
        }


    }
}
