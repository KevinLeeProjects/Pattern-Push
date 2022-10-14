using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerShapeCodeLegi : MonoBehaviour
{
    public GameObject circle;
    public GameObject triangle;
    public GameObject square;

    public static string timershape;

    public static int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        int a = Random.Range(0, 3);
        if (a == 0)
        {
            circle.SetActive(true);
            triangle.SetActive(false);
            square.SetActive(false);
            timershape = "circle";
        }
        else if (a == 1)
        {
            square.SetActive(true);
            triangle.SetActive(false);
            circle.SetActive(false);
            timershape = "square";
        }
        else if (a == 2)
        {
            triangle.SetActive(true);
            square.SetActive(false);
            circle.SetActive(false);
            timershape = "triangle";
        }
    }


    public void game()
    {
        if (x == 0)
        {
            
            x = 1;
        }
    }
}
