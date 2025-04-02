using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class arrowdrop : MonoBehaviour
{
    public float drop = 0.2f;

    public float r1 = 0.4f;
    public float r2 = 0.9f;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        player = GameObject.Find("player");


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -drop, 0);
        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;

        Vector2 dir = p1 - p2;

        float distance = dir.magnitude;

        if (distance < r1 + r2)
        {
            Destroy(gameObject);
        }
        
    }
}
