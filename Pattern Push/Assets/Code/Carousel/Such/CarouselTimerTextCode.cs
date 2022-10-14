using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarouselTimerTextCode : MonoBehaviour
{
    public Text txt;

    public float time;

    public int sec;
    void Start()
    {
    }

    void Update()
    {
        sec = CarouselTimerCode.sec + 1;
        txt.text = sec.ToString();
    }
}
