using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausedTopCode : MonoBehaviour
{
    public Text topscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        topscore.text = PlayerPrefs.GetFloat("top").ToString();
    }
}
