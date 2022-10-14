using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarouselToHome : MonoBehaviour
{

    public void button()
    {
        FallCode.carouselcirclecounter = 0;
        FallCode.carouseltrianglecounter = 0;
        FallCode.carouselsquarecounter = 0;
        CarouselScoreCode.scorecounter = 0;
        HeartCode.life = 3;
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
