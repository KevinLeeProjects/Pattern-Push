using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselTutorialDone : MonoBehaviour
{
    public static float carouseltutorial = 0f;

    public GameObject done;
    public GameObject tutorial;
    public GameObject background;
    public GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    public GameObject bomb;
    public GameObject square1;
    public GameObject square2;
    public GameObject triangle1;
    public GameObject triangle2;
    public GameObject line;
    public GameObject carousel;
    public GameObject words;
    public GameObject carouselword;
    public GameObject timer;
    public GameObject donehitbox;


    public void plsstop()
    {
        carouseltutorial = 1f;
        done.SetActive(false);
        tutorial.SetActive(false);
        background.SetActive(false);
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);
        bomb.SetActive(false);
        square1.SetActive(false);
        square2.SetActive(false);
        triangle1.SetActive(false);
        triangle2.SetActive(false);
        line.SetActive(false);
        carousel.SetActive(false);
        words.SetActive(false);
        carouselword.SetActive(false);
        donehitbox.SetActive(false);
        timer.SetActive(false);
        PlayerPrefs.SetFloat("carouseltutorial", carouseltutorial);
        PlayerPrefs.Save();
        Time.timeScale = 1f;
    }
}
