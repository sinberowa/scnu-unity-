using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerpos = player.transform.position;
        if (0 < playerpos.y && playerpos.y < 42.5f)
        {
            transform.position = new Vector3(
            transform.position.x, playerpos.y, transform.position.z);
        }
        else if (playerpos.y > 42.5f)
        {
            transform.position = new Vector3(
            transform.position.x, 42.5f, transform.position.z);
        }
        else 
        {
            transform.position = new Vector3(
            transform.position.x, 0, transform.position.z);
        }
    }
}
