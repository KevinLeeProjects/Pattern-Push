using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CarouselTriangleCode : MonoBehaviour
{

    public static string tracker = "";

    void Start()
    {
    }

    void Update()
    {
        
    }

    public void OnClick()
    {
        
        GameObject go = GameObject.Find(EventSystem.current.currentSelectedGameObject.name);


        Destroy(go);

        if(go.tag == "CarouselBomb")
        {
            if (HeartCode.life > 0)
            {
                HeartCode.life--;
                RedCode.vec = go.transform.position;
                RedCode.y = 1;

            }
            else if (HeartCode.life == 0)
            {
                FallCode.carouselcirclecounter = 0;
                FallCode.carouseltrianglecounter = 0;
                FallCode.carouselsquarecounter = 0;
                HeartCode.life = 3;
                ModeCode.mode = "Carousel";
                SceneManager.LoadScene("Over");

            }
        }
        else if(go.tag == "CarouselCircle")
        {
            if (CarouselTimerCode.timertest == "Circle")
            {

                FallCode.carouselcirclecounter--;
                CarouselScoreCode.scorecounter++;
            }
            else
            {
                if(HeartCode.life > 0)
                {
                    RedCode.vec = go.transform.position;
                    RedCode.y = 1;
                    HeartCode.life--;
                    
                }

                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;
                    HeartCode.life = 3;
                    ModeCode.mode = "Carousel";
                    SceneManager.LoadScene("Over");
                    
                }
                
            }
        }
        else if(go.tag == "CarouselTriangle")
        {
            if (CarouselTimerCode.timertest == "Triangle")
            {
                FallCode.carouseltrianglecounter--;
                CarouselScoreCode.scorecounter++;
            }
            else
            {
                if (HeartCode.life > 0)
                {
                    RedCode.vec = go.transform.position;
                    RedCode.y = 1;
                    HeartCode.life--;
                    
                }
                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;
                    HeartCode.life = 3;
                    ModeCode.mode = "Carousel";
                    SceneManager.LoadScene("Over");

                }
            }
        }
        else if(go.tag == "CarouselSquare")
        {
            if (CarouselTimerCode.timertest == "Square")
            {
                FallCode.carouselsquarecounter--;
                CarouselScoreCode.scorecounter++;
            }
            else
            {
                if (HeartCode.life > 0)
                {
                    RedCode.vec = go.transform.position;
                    RedCode.y = 1;
                    HeartCode.life--;
                    
                }
                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;
                    HeartCode.life = 3;
                    ModeCode.mode = "Carousel";
                    SceneManager.LoadScene("Over");
                }
            }
        }
        
    }
}
