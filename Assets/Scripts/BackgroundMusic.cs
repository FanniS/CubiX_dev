using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!(BGMusic.gameObject.GetComponent<AudioSource>().isPlaying))
        {
            if ((GameMusic.Gbeat != null) && (GameMusic.Gbeat.gameObject.GetComponent<AudioSource>().isPlaying))
            {
                GameMusic.Gbeat.gameObject.GetComponent<AudioSource>().Stop();
            }
            BGMusic.gameObject.GetComponent<AudioSource>().Play();
        }

    }

    public static BackgroundMusic music = null;

    public static BackgroundMusic BGMusic
    {
        get { return music; }
    }

    void Awake()
    {
        if (music != null && music != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            music = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
