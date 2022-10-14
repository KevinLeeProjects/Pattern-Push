using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarouselTimerCode : MonoBehaviour
{
    public GameObject triangle;
    public GameObject square;
    public GameObject circle;

    public static float yy;

    public float time;

    public static int sec;

    int y = 0;

    public static string timertest;
    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(3, 11);
        triangle.SetActive(false);
        square.SetActive(false);
        circle.SetActive(false);
        int x = Random.Range(0, 301);
        if(x < 100)
        {
            triangle.SetActive(true);
            square.SetActive(false);
            circle.SetActive(false);
            timertest = "Triangle";
        }
        else if(x < 200)
        {
            square.SetActive(true);
            triangle.SetActive(false);
            circle.SetActive(false);
            timertest = "Square";
        }
        else if(x < 300)
        {
            circle.SetActive(true);
            triangle.SetActive(false);
            square.SetActive(false);
            timertest = "Circle";
        }
    }

    void Update()
    {
        time -= Time.deltaTime;
        sec = ((int)(time % 60));
        if (time <= 0f)
        {
            int x = randInt(0,3);
            if (x == 0 && timertest == "Triangle")
            {
                x = randInt(1, 3);
            }
            else if (x == 1 && timertest == "Square")
            {
                x = randInt(0, 2);
                if(x == 0)
                {
                    x = 0;
                }
                else if(x == 1)
                {
                    x = 2;
                }
            }
            else if (x == 2 && timertest == "Circle")
            {
                x = randInt(0, 2);
            }

            if (x == 0 && timertest != "Triangle")
            {
                triangle.SetActive(true);
                square.SetActive(false);
                circle.SetActive(false);
                timertest = "Triangle";
            }
            else if (x == 1 && timertest != "Square")
            {
                square.SetActive(true);
                triangle.SetActive(false);
                circle.SetActive(false);
                timertest = "Square";
            }
            else if (x == 2 && timertest != "Circle")
            {
                circle.SetActive(true);
                triangle.SetActive(false);
                square.SetActive(false);
                timertest = "Circle";
            }
            time = randInt(3, 11);
        }
        
    }

    public int randInt(int x, int y)
    {
        return Random.Range(x, y);
    }
}
