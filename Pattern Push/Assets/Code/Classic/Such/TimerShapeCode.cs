using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerShapeCode : MonoBehaviour
{
    public GameObject circle;
    public GameObject triangle;
    public GameObject square;

    public Text cointext;

    //public GameObject shapes;

    public static int circlecounter;
    public static int trianglecounter;
    public static int squarecounter;

    public static int trianglecounter1;
    public static int circlecounter1;
    public static int squarecounter1;

    public static float timercounter1;

    public static float coincounter;

    public static float timercounter;

    //static int score;

    //public Text score;

    public static int z = 0;

    string shape;
    // Start is called before the first frame update
    void Start()
    {
        game();
    }
    

    // Update is called once per frame
    void Update()
    {
        cointext.text = PlayerPrefs.GetFloat("coin1").ToString();
    }

    public void game()
    {
        if (z == 0)
        {
            int a = Random.Range(0, 3);
            if (a == 0)
            {
                circle.SetActive(true);
                triangle.SetActive(false);
                square.SetActive(false);
                shape = "circle";
                circlecounter++;

            }
            else if (a == 1)
            {
                square.SetActive(true);
                triangle.SetActive(false);
                circle.SetActive(false);
                shape = "square";
                squarecounter++;

            }
            else if (a == 2)
            {
                triangle.SetActive(true);
                square.SetActive(false);
                circle.SetActive(false);
                shape = "triangle";
                trianglecounter++;

            }
        }
    }

    public void Pushed()
    {
        Debug.Log(shape);
        if(TimerShapeCodeLegi.timershape.Equals("circle"))
        {
            if (shape.Equals("circle"))
            {
                circlecounter1++;
                Debug.Log(circlecounter1);
                circle.SetActive(false);
                ScoreCode.scorecounter++;
                if (circlecounter1 == circlecounter)
                {
                    coincounter = 0;
                    circlecounter1 = 0;
                    trianglecounter1 = 0;
                    squarecounter1 = 0;
                    circlecounter = 0;
                    squarecounter = 0;
                    trianglecounter = 0;
                    
                    UpdatedTimerCounterCodeLMAOPlsWork.updatedtimercounter++;
                    UpdatedTimerCounterCodeLMAOPlsWork.timercode();
                    SceneManager.LoadScene("Classic");
                }
            }
            else
            {
                coincounter = 0;
                circlecounter1 = 0;
                trianglecounter1 = 0;
                squarecounter1 = 0;
                circlecounter = 0;
                squarecounter = 0;
                trianglecounter = 0;
                timercounter = 0;
                timercounter1 = 0;
                TimerCodw.deletetime = 0;
                
                TopScoreCode.top(ScoreCode.scorecounter);
                SceneManager.LoadScene("Over");
            }
        }
        else if(TimerShapeCodeLegi.timershape.Equals("triangle"))
        {
            if(shape.Equals("triangle"))
            {
                trianglecounter1++;
                Debug.Log(trianglecounter1);
                triangle.SetActive(false);
                ScoreCode.scorecounter++;
                if (trianglecounter1 == trianglecounter)
                {
                    coincounter = 0;
                    circlecounter1 = 0;
                    trianglecounter1 = 0;
                    squarecounter1 = 0;
                    circlecounter = 0;
                    squarecounter = 0;
                    trianglecounter = 0;
                    UpdatedTimerCounterCodeLMAOPlsWork.updatedtimercounter++;
                    UpdatedTimerCounterCodeLMAOPlsWork.timercode();
                    SceneManager.LoadScene("Classic");
                }
            }
            else
            {
                coincounter = 0;
                circlecounter1 = 0;
                trianglecounter1 = 0;
                squarecounter1 = 0;
                circlecounter = 0;
                squarecounter = 0;
                trianglecounter = 0;
                timercounter = 0;
                timercounter1 = 0;
                TimerCodw.deletetime = 0;
                TopScoreCode.top(ScoreCode.scorecounter);
                SceneManager.LoadScene("Over");
            }
        }
        else if(TimerShapeCodeLegi.timershape.Equals("square"))
        {
            if(shape.Equals("square"))
            {
                squarecounter1++;
                Debug.Log(squarecounter1);
                square.SetActive(false);
                ScoreCode.scorecounter++;
                if (squarecounter1 == squarecounter)
                {
                    coincounter = 0;
                    circlecounter1 = 0;
                    trianglecounter1 = 0;
                    squarecounter1 = 0;
                    circlecounter = 0;
                    squarecounter = 0;
                    trianglecounter = 0;
                    UpdatedTimerCounterCodeLMAOPlsWork.updatedtimercounter++;
                    UpdatedTimerCounterCodeLMAOPlsWork.timercode();
                    SceneManager.LoadScene("Classic");
                }
            }
            else
            {
                coincounter = 0;
                circlecounter1 = 0;
                trianglecounter1 = 0;
                squarecounter1 = 0;
                circlecounter = 0;
                squarecounter = 0;
                trianglecounter = 0;
                timercounter = 0;
                timercounter1 = 0;
                TimerCodw.deletetime = 0;
                TopScoreCode.top(ScoreCode.scorecounter);
                SceneManager.LoadScene("Over");
            }
        }
    }
}
