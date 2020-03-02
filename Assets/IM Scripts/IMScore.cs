using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IMScore : MonoBehaviour
{
    public Text scoreText;
    public Text scoreText2;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        scoreText2.gameObject.SetActive(true);
        scoreText.text = (IMGameManager.IMEnd - Modes.IMStart).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z >= 0)
        {
            scoreText2.gameObject.SetActive(true);
            scoreText2.text = Time.timeSinceLevelLoad.ToString("0");
        }
        else
        {
            scoreText2.gameObject.SetActive(false);
        }
    }


}
