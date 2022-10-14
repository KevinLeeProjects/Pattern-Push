using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ClassicDecagon : MonoBehaviour
{
    public static string st;

    public string str;

    public static int track;

    public GameObject pausetext;
    public GameObject background;
    public GameObject coinimage;
    public GameObject cointext;
    public GameObject topimage;
    public GameObject toptext;
    public GameObject score;
    public GameObject scoretext;
    public GameObject restart;
    public GameObject home;
    public GameObject setting;
    public GameObject left;
    public GameObject right;
    public GameObject classic;
    public GameObject resume;

    GameObject pausetext1;
    Vector3 pausetext2;

    GameObject background1;
    Vector3 background2;

    GameObject coinimage1;

    GameObject cointext1;

    GameObject topimage1;

    GameObject toptext1;

    GameObject score1;

    GameObject scoretext1;

    GameObject restart1;

    GameObject home1;

    GameObject setting1;

    GameObject left1;

    GameObject right1;

    GameObject classic1;

    GameObject resume1;


    void OnCollisionEnter2D(Collision2D collision)
    {
        st = collision.gameObject.name;
        str = collision.gameObject.tag;

        if (str == "ClassicPause")
        {
            Pause.testpause.TogglePause();

            track = 1;

        }
        else if(collision.gameObject.tag == "ClassicPauseBackground")
        {
            Pause.testpause.Unpause();
        }
        else if (collision.gameObject.name == "Resume")
        {
            Time.timeScale = 1;
        }
        else if (str == "ClassicRestart")
        {
            TimerShapeCode.coincounter = 0;
            TimerShapeCode.circlecounter1 = 0;
            TimerShapeCode.trianglecounter1 = 0;
            TimerShapeCode.squarecounter1 = 0;
            TimerShapeCode.circlecounter = 0;
            TimerShapeCode.squarecounter = 0;
            TimerShapeCode.trianglecounter = 0;
            TimerCodw.deletetime = 0;
            ScoreCode.scorecounter = 0;
            Time.timeScale = 1;
            SceneManager.LoadScene("Classic");
        }
        else if (str == "ClassicHome")
        {
            TimerShapeCode.coincounter = 0;
            TimerShapeCode.circlecounter1 = 0;
            TimerShapeCode.trianglecounter1 = 0;
            TimerShapeCode.squarecounter1 = 0;
            TimerShapeCode.circlecounter = 0;
            TimerShapeCode.squarecounter = 0;
            TimerShapeCode.trianglecounter = 0;
            TimerCodw.deletetime = 0;
            ScoreCode.scorecounter = 0;
            Time.timeScale = 1;
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Pause.testpause.Unpause();
        }

        if (TimerShapeCodeLegi.timershape.Equals("circle"))
        {
            if (str == "ClassicCircle")
            {
                TimerShapeCode.circlecounter1++;
                Debug.Log(TimerShapeCode.circlecounter1);
                collision.gameObject.SetActive(false);
                ScoreCode.scorecounter++;
                if (TimerShapeCode.circlecounter1 == TimerShapeCode.circlecounter)
                {
                    TimerShapeCode.coincounter = 0;
                    TimerShapeCode.circlecounter1 = 0;
                    TimerShapeCode.trianglecounter1 = 0;
                    TimerShapeCode.squarecounter1 = 0;
                    TimerShapeCode.circlecounter = 0;
                    TimerShapeCode.squarecounter = 0;
                    TimerShapeCode.trianglecounter = 0;

                    UpdatedTimerCounterCodeLMAOPlsWork.updatedtimercounter++;
                    UpdatedTimerCounterCodeLMAOPlsWork.timercode();
                    print(GameObject.Find(ClassicSpawnDecagon.classicdecname));
                    Destroy(GameObject.Find(ClassicSpawnDecagon.classicdecname));
                    SceneManager.LoadScene("Classic");
                    Destroy(GameObject.Find(ClassicSpawnDecagon.classicdecname));
                }
            }
            else if(str == "ClassicTriangle" || str == "ClassicSquare")
            {
                TimerShapeCode.coincounter = 0;
                TimerShapeCode.circlecounter1 = 0;
                TimerShapeCode.trianglecounter1 = 0;
                TimerShapeCode.squarecounter1 = 0;
                TimerShapeCode.circlecounter = 0;
                TimerShapeCode.squarecounter = 0;
                TimerShapeCode.trianglecounter = 0;
                TimerShapeCode.timercounter = 0;
                TimerShapeCode.timercounter1 = 0;
                TimerCodw.deletetime = 0;

                TopScoreCode.top(ScoreCode.scorecounter);
                ModeCode.mode = "Classic";
                SceneManager.LoadScene("Over");
            }
        }
        else if (TimerShapeCodeLegi.timershape.Equals("triangle"))
        {
            if (str == "ClassicTriangle")
            {
                TimerShapeCode.trianglecounter1++;
                Debug.Log(TimerShapeCode.trianglecounter1);
                collision.gameObject.SetActive(false);
                ScoreCode.scorecounter++;
                if (TimerShapeCode.trianglecounter1 == TimerShapeCode.trianglecounter)
                {
                    TimerShapeCode.coincounter = 0;
                    TimerShapeCode.circlecounter1 = 0;
                    TimerShapeCode.trianglecounter1 = 0;
                    TimerShapeCode.squarecounter1 = 0;
                    TimerShapeCode.circlecounter = 0;
                    TimerShapeCode.squarecounter = 0;
                    TimerShapeCode.trianglecounter = 0;
                    UpdatedTimerCounterCodeLMAOPlsWork.updatedtimercounter++;
                    UpdatedTimerCounterCodeLMAOPlsWork.timercode();
                    Destroy(GameObject.Find(ClassicSpawnDecagon.classicdecname));
                    SceneManager.LoadScene("Classic");
                    Destroy(GameObject.Find(ClassicSpawnDecagon.classicdecname));
                }
            }
            else if(str == "ClassicCircle" || str == "ClassicSquare")
            {
                TimerShapeCode.coincounter = 0;
                TimerShapeCode.circlecounter1 = 0;
                TimerShapeCode.trianglecounter1 = 0;
                TimerShapeCode.squarecounter1 = 0;
                TimerShapeCode.circlecounter = 0;
                TimerShapeCode.squarecounter = 0;
                TimerShapeCode.trianglecounter = 0;
                TimerShapeCode.timercounter = 0;
                TimerShapeCode.timercounter1 = 0;
                TimerCodw.deletetime = 0;
                TopScoreCode.top(ScoreCode.scorecounter);
                ModeCode.mode = "Classic";
                SceneManager.LoadScene("Over");
            }
        }
        else if (TimerShapeCodeLegi.timershape.Equals("square"))
        {
            if (str == "ClassicSquare")
            {
                TimerShapeCode.squarecounter1++;
                Debug.Log(TimerShapeCode.squarecounter1);
                collision.gameObject.SetActive(false);
                ScoreCode.scorecounter++;
                if (TimerShapeCode.squarecounter1 == TimerShapeCode.squarecounter)
                {
                    TimerShapeCode.coincounter = 0;
                    TimerShapeCode.circlecounter1 = 0;
                    TimerShapeCode.trianglecounter1 = 0;
                    TimerShapeCode.squarecounter1 = 0;
                    TimerShapeCode.circlecounter = 0;
                    TimerShapeCode.squarecounter = 0;
                    TimerShapeCode.trianglecounter = 0;
                    UpdatedTimerCounterCodeLMAOPlsWork.updatedtimercounter++;
                    UpdatedTimerCounterCodeLMAOPlsWork.timercode();
                    Destroy(GameObject.Find(ClassicSpawnDecagon.classicdecname));
                    SceneManager.LoadScene("Classic");
                    Destroy(GameObject.Find(ClassicSpawnDecagon.classicdecname));
                }
            }
            else if(str == "ClassicTriangle" || str == "ClassicCircle")
            {
                TimerShapeCode.coincounter = 0;
                TimerShapeCode.circlecounter1 = 0;
                TimerShapeCode.trianglecounter1 = 0;
                TimerShapeCode.squarecounter1 = 0;
                TimerShapeCode.circlecounter = 0;
                TimerShapeCode.squarecounter = 0;
                TimerShapeCode.trianglecounter = 0;
                TimerShapeCode.timercounter = 0;
                TimerShapeCode.timercounter1 = 0;
                TimerCodw.deletetime = 0;
                TopScoreCode.top(ScoreCode.scorecounter);
                ModeCode.mode = "Classic";
                SceneManager.LoadScene("Over");
            }
        }
        
    }
}
