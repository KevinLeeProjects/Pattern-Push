using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselTutorialFreeze : MonoBehaviour
{
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        x = PlayerPrefs.GetFloat("carouseltutorial");
        if (x == 0)
            Time.timeScale = 0f;
    }

}
