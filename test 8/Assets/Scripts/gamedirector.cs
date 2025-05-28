using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamedirector : MonoBehaviour
{

    GameObject timerText;
    GameObject pointText;
    float time = 60.0f;
    int point = 0;

    public void GetApple()
    {
        point += 100;
    }

    public void GetBomb()
    {
        point /= 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("timedesu");
        this.pointText = GameObject.Find("point");
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        pointText.GetComponent<TextMeshProUGUI>().text = point.ToString() + " point";
    }
}
