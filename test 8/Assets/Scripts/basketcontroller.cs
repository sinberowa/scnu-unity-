using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class basketcontroller : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip boombSE;
    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) 
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }

       

        if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x != 1) 
        {
            transform.position = new Vector3(transform.position.x + 1, 0, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x != -1)
        {
            transform.position = new Vector3(transform.position.x - 1, 0, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && this.transform.position.z != 1)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z + 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && this.transform.position.z != -1)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z - 1);
        }




    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "apple")
        {
            this.aud.PlayOneShot(this.appleSE);
        }
        else
        {
            this.aud.PlayOneShot(this.boombSE);
        }

        Destroy(other.gameObject);
    }
}
