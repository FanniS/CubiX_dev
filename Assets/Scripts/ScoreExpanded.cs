using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreExpanded : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    public Transform player;
    public Text scoreText;
    public PlayerMovementExpanded movement;

    void Update()
    {
        if (player.position.y < 0.75f || movement.enabled == false)
        {
            scoreText.fontSize = 50;
            scoreText.text = "GAME OVER!";
        }
        else
        {
            scoreText.text = player.position.z.ToString("0");
        }

    }
}
