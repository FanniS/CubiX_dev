using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System;

public class Login : MonoBehaviour
{
    public InputField input;
    public GameObject player;
    public static string currentUsername;
    public Text error;

    // Start is called before the first frame update
    void Start()
    {
        /* at stratup of the game i need to check if the user file is present if its present i open, otherwise i create it*/
        /* when you press the buton submit you should check every entry of the file: the first value of every line is the username, search for the username entered, if its existing load, oterwise create*/
        /* every single line of the file is a different user; every user is composed of the following values: 
         user name; 
         color(RGB);
         level (TODO) 
         highscore (TODO)*/


        if (File.Exists("login.csv"))
        {
            StreamReader login = new StreamReader("login.csv");
            login.Close();
            Debug.Log("A fájl létezik és beolvasta");
        }
        else
        {
            StreamWriter newLogin = new StreamWriter("login.csv");
            newLogin.Close();
            Debug.Log("A fájl nem létezik és létrehozta");

        }
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    public void Submit()
    {
        if (input.text.Length != 0)
        {
            StreamReader file = new StreamReader("login.csv");
            bool found = false;
            if (new FileInfo("login.csv").Length != 0)
            {
                Debug.Log("a fájl nem üres");
                while (!file.EndOfStream)
                {
                    Debug.Log("whileban vagyok");

                    string[] csvSor = file.ReadLine().Split(';');
                    if (csvSor[0].Trim() == input.text)
                    {
                        Debug.Log("RGB if ben vagyok");
                        string colorStr = csvSor[1].ToString();
                        string clr = colorStr.Substring(0, 2);
                        byte r = byte.Parse(clr, System.Globalization.NumberStyles.HexNumber);
                        clr = colorStr.Substring(2, 2);
                        byte g = byte.Parse(clr, System.Globalization.NumberStyles.HexNumber);
                        clr = colorStr.Substring(4, 2);
                        byte b = byte.Parse(clr, System.Globalization.NumberStyles.HexNumber);
                        Color32 color = new Color32(r, g, b, 255);
                        player.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", color);
                        found = true;
                        Debug.Log("Beállítottam a színt" + color);
                    }

                }
            }
            file.Close();
            if (!found)
            {
                StreamWriter sw = new StreamWriter("login.csv", true);
                sw.WriteLine(input.text + ";00D1C3");
                Color32 color = new Color32(0, 209, 195, 255);
                player.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", color);
                sw.Close();
            }
            currentUsername = input.text;
            SceneManager.LoadScene(1);
        }
        else
        {
            error.text = "Warning! The user name can not be empty!";

        }
    }
}
