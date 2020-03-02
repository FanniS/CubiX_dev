using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player").transform; //player assign --> ha UnassignedException dobódik, kód nélküli megoldása, Unity -> Inspector Main Camera -> Transformhoz hozzárendelni a Playert
    }

    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position); //követi a koordinátákat consolon --> hasznos lehet dokumnetáláshoz
        transform.position = player.position + offset;
    }
}
