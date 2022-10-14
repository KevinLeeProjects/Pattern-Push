using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarouselOverTop : MonoBehaviour
{
    public Text top;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        top.text = PlayerPrefs.GetFloat("carouseltop").ToString();
    }
}
