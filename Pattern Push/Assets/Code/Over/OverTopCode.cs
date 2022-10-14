using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverTopCode : MonoBehaviour
{
    public Text top;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ModeCode.mode == "Classic")
            top.text = PlayerPrefs.GetFloat("top").ToString();
        else if(ModeCode.mode == "Carousel")
            top.text = PlayerPrefs.GetFloat("carouseltop").ToString();
        else if(ModeCode.mode == "Margins")
            top.text = PlayerPrefs.GetFloat("margintop").ToString();
    }
}
