using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{

    public float dropspeed = -0.03f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropspeed, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision enter");
    }
}
