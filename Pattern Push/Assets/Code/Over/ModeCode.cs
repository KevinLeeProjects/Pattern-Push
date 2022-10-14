using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeCode : MonoBehaviour
{

    public GameObject carousel;
    public GameObject classic;
    public GameObject margins;

    public static string mode;

    public static string absmode;
    // Start is called before the first frame update
    void Start()
    {
        if(mode == "Classic")
        {
            absmode = "Classic";
            classic.SetActive(true);
            carousel.SetActive(false);
            margins.SetActive(false);
        }
        else if(mode == "Carousel")
        {
            absmode = "Carousel";
            classic.SetActive(false);
            carousel.SetActive(true);
            margins.SetActive(false);
        }
        else if(mode == "Margins")
        {
            absmode = "Margins";
            classic.SetActive(false);
            carousel.SetActive(false);
            margins.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void thisissorepetitive()
    {
        if(classic.activeInHierarchy)
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
        else if(carousel.activeInHierarchy)
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
        else if(margins.activeInHierarchy)
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
