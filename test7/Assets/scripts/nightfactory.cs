using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightfactory : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    float power = 0f;
    float startval = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startval = Input.mousePosition.y;
        }



        if (Input.GetMouseButtonUp(0))
        {
            power = Input. mousePosition.y - startval;
            GameObject bamsongi = Instantiate(bamsongiPrefab, transform.position, transform.rotation);

            //bamsongi.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z + 2);


            bamsongi.transform.position = transform.position + transform.forward;


            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 worldDir = ray.direction;
            //bamsongi.GetComponent<nightshoot>().Shoot(worldDir.normalized * 2000);
            bamsongi.GetComponent<nightshoot>().Shoot((transform.forward + transform.up * 0.5f).normalized * power * 4);
        }
    }
}
