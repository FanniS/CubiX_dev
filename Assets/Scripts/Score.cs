using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //a score és a text közötti referenciához

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    /* void Start()
     {

     }*/

    public Transform player;
    public Text scoreText;
    public PlayerMovement movement;


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        if (player.position.y < 0.75f || movement.enabled == false)
        {
            scoreText.fontSize = 50;
            scoreText.text = "GAME OVER!";
        }
        //megvizsgálni hogy az endgame lefutott e már
        else
        {
            scoreText.text = player.position.z.ToString("0");
        }

    }
}
