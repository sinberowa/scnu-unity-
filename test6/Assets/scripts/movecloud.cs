using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecloud : MonoBehaviour
{
    public float movespeed;
    float range = 0.02f;
    public float maxwidth = 3f;

    float avgspeed = 0.05f;
    int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > maxwidth)
        {
            movespeed = Random.Range(avgspeed - range, avgspeed + range);
            direction = -1;
        }
        if(transform.position.x < -maxwidth)
        {
            movespeed = Random.Range(avgspeed - range, avgspeed + range);
            direction = 1;
        }
        
        transform.Translate(movespeed * direction, 0, 0);
    }
}
