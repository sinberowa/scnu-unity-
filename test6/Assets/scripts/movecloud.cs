using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecloud : MonoBehaviour
{
    public float movespeed = 0.05f;
    public float maxwidth = 10f;

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
            transform.Translate(movespeed * direction, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -maxwidth)
        {
            transform.Translate(movespeed * -direction,transform.position.y, transform.position.z);
        }
    }
}
