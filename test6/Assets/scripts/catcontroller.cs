using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class catcontroller : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float jumpforce = 680f;
    public float walkforce = 30f;
    public float maxwalkspeed = 2f;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        { 
            rigid2D.AddForce(transform.up *  jumpforce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(rigid2D.velocity.x);

        if(speedx < maxwalkspeed)
        {
            rigid2D.AddForce(transform.right * key * walkforce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        animator.speed = speedx / 2f;

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("game");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("°ñ");
        SceneManager.LoadScene("gameclear");
    }
}
