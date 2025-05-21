using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maketarget : MonoBehaviour
{

    public  GameObject targetprefab;

    Transform[] destinations;
    float minDistance = 10;
    Transform Capsule;
    // Start is called before the first frame update
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>();
        Debug.Log("Num of children : " + destinations.Length);
        Capsule = ge
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void generatetarget()
    {
        int index;

        Vector3 position;

        do
        {



            index = Random.Range(1, destinations.Length);

            position = destinations[index].position;

        } while (Vector3.Distance(position, Capsule.position) < minDistance);
        

        GameObject target = Instantiate(targetprefab, destinations[index].position, Quaternion.identity);

        target.transform.SetParent(destinations[index]);

    }
}
