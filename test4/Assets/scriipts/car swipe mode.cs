using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carswipemode : MonoBehaviour
{
    public float stopspeed = 0.01f;
    public float startspeed = 0f;
    public float decreasespeed = 0.99f;
    float speed = 0;
    Vector2 startPos;
    AudioSource audio;

    bool gameended = false;
    bool carstarted = false;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(gameended)return;

        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipelength = endPos.x - startPos.x;

            speed = swipelength / 1400.0f;

            audio.Play();
            carstarted = true;
        }

        

        transform.Translate(this.speed, 0, 0);
        this.speed *= decreasespeed;

        if (carstarted && speed < stopspeed)
        {
            speed = 0f;
            gameended = true;
        }
    }
}
