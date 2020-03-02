using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IMEndGame : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/



    public void Restart()
    {
        SceneManager.LoadScene("InfinityMode");
        Modes.IMStart = Convert.ToInt32(Time.time);
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }


}
