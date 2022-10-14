using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void herewegoagain()
    {
        if(ModeCode.absmode == "Classic")
        {
            TimerShapeCode.circlecounter1 = 0;
            TimerShapeCode.trianglecounter1 = 0;
            TimerShapeCode.squarecounter1 = 0;
            TimerShapeCode.circlecounter = 0;
            TimerShapeCode.squarecounter = 0;
            TimerShapeCode.trianglecounter = 0;
            TimerShapeCode.timercounter = 0;
            TimerShapeCode.timercounter1 = 0;
            TimerCodw.deletetime = 0;
            ScoreCode.scorecounter = 0;
            SceneManager.LoadScene("Classic");
        }
        else if(ModeCode.absmode == "Carousel")
        {
            FallCode.carouselcirclecounter = 0;
            FallCode.carouseltrianglecounter = 0;
            FallCode.carouselsquarecounter = 0;
            HeartCode.life = 3;
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
            SceneManager.LoadScene("Carousel");
        }
        else if(ModeCode.absmode == "Margins")
        {
            MarginRedCode.marginscore = 0;
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
            SceneManager.LoadScene("Margins");
        }
    }
}
