using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecagonTriggerCode : MonoBehaviour
{
    public static string st;

    public string str;

    void Start()
    {

    }


    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        st = collision.gameObject.name;
        str = collision.gameObject.tag;

        if (str == "ClassicPause")
        {

            CarouselPause.testpause1.TogglePause();

        }
        else if (collision.gameObject.tag == "CarouselPauseBackground")
        {

            CarouselPause.testpause1.Unpause();
        }
        else if (collision.gameObject.name == "Resume")
        {
            Time.timeScale = 1;
        }
        else if (str == "ClassicRestart")
        {

            CarouselScoreCode.scorecounter = 0;
            HeartCode.life = 3;
            Time.timeScale = 1;
            SceneManager.LoadScene("Carousel");
        }
        else if (str == "ClassicHome")
        {

            CarouselScoreCode.scorecounter = 0;
            HeartCode.life = 3;
            Time.timeScale = 1;
            SceneManager.LoadScene("SampleScene");
        }
        Destroy(collision.gameObject);
        if (collision.gameObject.tag == "CarouselBomb")
        {

            Destroy(collision.gameObject);
            if (HeartCode.life > 0)
            {
                HeartCode.life--;
                RedCode.vec = collision.gameObject.transform.position;
                RedCode.y = 1;

            }
            else if (HeartCode.life == 0)
            {
                FallCode.carouselcirclecounter = 0;
                FallCode.carouseltrianglecounter = 0;
                FallCode.carouselsquarecounter = 0;

                HeartCode.life = 3;

                SceneManager.LoadScene("CarouselOver");

            }
        }
        else if (collision.gameObject.tag == "CarouselCircle")
        {

            if (CarouselTimerCode.timertest == "Circle")
            {

                FallCode.carouselcirclecounter--;
                CarouselScoreCode.scorecounter++;
                CarouselPausedScoreAndSuchCode.counter++;
            }
            else
            {
                if (HeartCode.life > 0)
                {
                    RedCode.vec = collision.gameObject.transform.position;
                    RedCode.y = 1;
                    HeartCode.life--;

                }

                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;

                    HeartCode.life = 3;
                    SceneManager.LoadScene("CarouselOver");

                }

            }
        }

        else if (collision.gameObject.tag == "CarouselTriangle")
        {

            if (CarouselTimerCode.timertest == "Triangle")
            {
                FallCode.carouseltrianglecounter--;

                CarouselScoreCode.scorecounter++;
                CarouselPausedScoreAndSuchCode.counter++;
            }
            else
            {
                if (HeartCode.life > 0)
                {
                    RedCode.vec = collision.gameObject.transform.position;
                    RedCode.y = 1;
                    HeartCode.life--;

                }
                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;
                    HeartCode.life = 3;
                    SceneManager.LoadScene("CarouselOver");

                }
            }
        }
        else if (collision.gameObject.tag == "CarouselSquare")
        {
            if (CarouselTimerCode.timertest == "Square")
            {
                FallCode.carouselsquarecounter--;
                CarouselScoreCode.scorecounter++;
                CarouselPausedScoreAndSuchCode.counter++;
            }
            else
            {
                if (HeartCode.life > 0)
                {
                    RedCode.vec = collision.gameObject.transform.position;
                    RedCode.y = 1;
                    HeartCode.life--;

                }
                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;
                    HeartCode.life = 3;
                    SceneManager.LoadScene("CarouselOver");
                }
            }
        }

    }   
}
