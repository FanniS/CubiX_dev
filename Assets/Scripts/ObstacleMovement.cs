using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    public float speed;
    float WPRadius = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPRadius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
