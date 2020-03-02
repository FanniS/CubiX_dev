using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public GameObject player;

    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log(player.GetComponent<Renderer>().sharedMaterial.color);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("LevelsMenu");
    }

    public void Costumise()
    {
        SceneManager.LoadScene("Costumise");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
