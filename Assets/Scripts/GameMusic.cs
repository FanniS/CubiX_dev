using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioSource>().Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static GameMusic beat = null;

    public static GameMusic Gbeat
    {
        get { return beat; }
    }

    void Awake()
    {
        if (beat != null && beat != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            beat = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }


}
