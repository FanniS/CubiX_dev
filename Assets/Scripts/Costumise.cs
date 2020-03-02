using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class Costumise : MonoBehaviour
{
    string userName = Login.currentUsername;
    public Text txt;
    public InputField input;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = userName;
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    public void Back()
    {
        StreamReader r = new StreamReader("login.csv");
        int county = 0;

        while (!r.EndOfStream)
        {
            string[] csvSor = r.ReadLine().Split(';');
            if (csvSor[0].Trim() == txt.text)
            {
                r.Close();
                lineChanger(txt.text + ";" + input.text.Trim('#'), "login.csv", county);
                string colorStr = input.text.Trim('#');
                string clr = colorStr.Substring(0, 2);
                byte rc = byte.Parse(clr, System.Globalization.NumberStyles.HexNumber);
                clr = colorStr.Substring(2, 2);
                byte g = byte.Parse(clr, System.Globalization.NumberStyles.HexNumber);
                clr = colorStr.Substring(4, 2);
                byte b = byte.Parse(clr, System.Globalization.NumberStyles.HexNumber);
                Color32 color = new Color32(rc, g, b, 255);
                Renderer rend = player.GetComponent<Renderer>();
                rend.sharedMaterial.color = color;
                Debug.Log("Beállítotam a színt!");
                //player.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", color);
                break;
            }
            else
            {
                county++;
            }
        }
        r.Close();

        SceneManager.LoadScene("Menu");
    }

    static void lineChanger(string newText, string fileName, int line_to_edit)
    {
        string[] arrLine = File.ReadAllLines(fileName);
        arrLine[line_to_edit] = newText;
        File.WriteAllLines(fileName, arrLine);
    }
}
