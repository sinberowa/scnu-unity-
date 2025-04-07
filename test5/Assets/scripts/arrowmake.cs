using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowmake : MonoBehaviour
{
    public GameObject arrowprefab;
    float span = 1f;
    float delta = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            GameObject go = Instantiate(arrowprefab);
            int px = Random.Range(-8, 9);
            go.transform.position = new Vector3(px, 7, 0);

            delta = 0f;
        }

    }
}
