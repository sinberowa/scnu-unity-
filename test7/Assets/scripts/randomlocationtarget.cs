using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class randomlocationtarget : MonoBehaviour
{

    //Transform CapsuleS;

    // Start is called before the first frame update
    void Start()
    {
        //CapsuleS = GameObject.Find("Capsule").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(CapsuleS);
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);    
        
        Destroy(collision.gameObject);
    }
}
