using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modes : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public static int IMStart;

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Levels()
    {
        SceneManager.LoadScene("LevelsMenu2");
    }

    public void Infinity()
    {
        SceneManager.LoadScene("InfinityMode");
        IMStart = Convert.ToInt32(Time.time);
    }
}
