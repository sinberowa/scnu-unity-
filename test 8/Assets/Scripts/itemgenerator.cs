using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemgenerator : MonoBehaviour
{

    public GameObject applePrefab;
    public GameObject boombPrefab;
    float span = 1.0f;
    float delta = 0f;
    public int radio = 5;
    float speed = -0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetParmeter(float span, float speed, int radio)
    {
        this.span = span;
        this.speed = speed;
        this.radio = radio;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > span) 
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 11);
            if (dice <= radio)
            {
                item = Instantiate(applePrefab);
            }
            else
            {
                item = Instantiate(boombPrefab);
            }
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 4, z);
            item.GetComponent<dropitem>().dropspeed = this.speed;
        }
    }
}
