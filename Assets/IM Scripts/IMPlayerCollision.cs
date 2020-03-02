using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMPlayerCollision : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/


    void OnCollisionEnter(UnityEngine.Collision collisionInfo) //hiba lehet --> odaírni a UnityEngine-t
    {
        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<IMGameManager>().IMEndgame();
        }
    }
}
