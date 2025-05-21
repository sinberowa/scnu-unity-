using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropitem : MonoBehaviour
{

    public float dropspeed = -0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, this.dropspeed, 0);
        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
