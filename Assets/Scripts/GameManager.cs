using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        //Debug.Log("LEVEL COMPLETED!");
        completeLevelUI.SetActive(true);
    }

    public void Endgame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            //Restart itt lehet
            Invoke("Restart", restartDelay);
        }

    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //megoldani hogy megtartsa a scoret!
    }
}
