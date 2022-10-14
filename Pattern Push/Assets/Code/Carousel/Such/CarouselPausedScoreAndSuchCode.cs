using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarouselPausedScoreAndSuchCode : MonoBehaviour
{
    public Text score;
    public Text coin;
    public Text top;

    public static int counter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = CarouselScoreCode.scorecounter.ToString();
        top.text = PlayerPrefs.GetFloat("carouseltop").ToString();
        coin.text = PlayerPrefs.GetFloat("coin1").ToString();
        if (counter == 5)
        {
            NewClassicCoinCode.coin1 = PlayerPrefs.GetFloat("coin1") + 1;
            PlayerPrefs.SetFloat("coin1", NewClassicCoinCode.coin1);
            PlayerPrefs.Save();
            counter = 0;
        }

    }
}
