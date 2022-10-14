using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverButtonCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pushed()
    {
        TimerShapeCode.coincounter = 0;
        TimerShapeCode.circlecounter1 = 0;
        TimerShapeCode.trianglecounter1 = 0;
        TimerShapeCode.squarecounter1 = 0;
        TimerShapeCode.circlecounter = 0;
        TimerShapeCode.squarecounter = 0;
        TimerShapeCode.trianglecounter = 0;
        ScoreCode.scorecounter = 0;
        CarouselScoreCode.scorecounter = 0;
        MarginRedCode.marginscore = 0;
        ClassicDecagon.track = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
