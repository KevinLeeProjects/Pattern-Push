using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCodeOver : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ModeCode.mode == "Classic")
            score.text = ScoreCode.scorecounter.ToString();
        else if(ModeCode.mode == "Carousel")
            score.text = CarouselScoreCode.scorecounter.ToString();
        else if(ModeCode.mode == "Margins")
           score.text =  MarginRedCode.marginscore.ToString();
    }
}
