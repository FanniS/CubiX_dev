using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGameManager : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
    public bool gameHasEnded;
    public GameObject iMEndGameUI;
    public static int IMEnd;

    public void IMEndgame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            IMGameOver();
        }
    }

    public void IMGameOver()
    {
        iMEndGameUI.SetActive(true);
        IMEnd = Convert.ToInt32(Time.time);
    }
}
