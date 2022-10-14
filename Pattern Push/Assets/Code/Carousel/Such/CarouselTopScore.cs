using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselTopScore : MonoBehaviour
{

    public static float carouseltop;
    // Start is called before the first frame update
    void Start()
    {
        carouseltopmethod(CarouselScoreCode.scorecounter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void carouseltopmethod(int score)
    {
        if (score > PlayerPrefs.GetFloat("carouseltop"))
        {
            carouseltop = score;
            PlayerPrefs.SetFloat("carouseltop", carouseltop);
            PlayerPrefs.Save();
        }
    }
}
