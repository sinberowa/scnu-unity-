using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float movestep = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-movestep, 0, 0);
        }


        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        { 
            transform.Translate(movestep, 0, 0);
        }
    }
}
