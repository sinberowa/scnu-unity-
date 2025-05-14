using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightfactory : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab, transform.position, transform.rotation);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bamsongi.GetComponent<nightshoot>().Shoot(worldDir.normalized * 2000);
        }
    }
}
