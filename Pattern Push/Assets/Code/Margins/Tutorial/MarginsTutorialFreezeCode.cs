using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarginsTutorialFreezeCode : MonoBehaviour
{
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        x = PlayerPrefs.GetFloat("marginstutorial");
        if (x == 0)
            Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
