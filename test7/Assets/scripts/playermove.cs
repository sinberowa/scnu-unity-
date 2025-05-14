using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float movespeed = 5f;

    public float rotationspeed = 25f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");

        float zinput = Input.GetAxis("Vertical");

        float move = zinput * movespeed * Time.deltaTime;

        float rotate = xinput * rotationspeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, rotate, 0);

    }
}
