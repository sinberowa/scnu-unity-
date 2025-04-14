using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gamedirector : MonoBehaviour
{
    GameObject hpgauge;
    // Start is called before the first frame update
    void Start()
    {
        hpgauge = GameObject.Find("HP Gauge");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHP()
    {
        hpgauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
