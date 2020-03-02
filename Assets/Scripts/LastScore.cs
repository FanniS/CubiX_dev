using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : Score
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    public Text lastScore;

    void Update()
    {
        if (scoreText.text.ToString() == "GAME OVER!")
        {
            lastScore.text = player.position.z.ToString("0"); //csak abban a pillanatban..!
        }
    }
}
