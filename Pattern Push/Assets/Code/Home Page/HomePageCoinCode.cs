using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePageCoinCode : MonoBehaviour
{
    public Text coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coin.text = PlayerPrefs.GetFloat("coin1").ToString();
    }
}
