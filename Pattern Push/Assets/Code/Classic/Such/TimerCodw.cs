using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCodw : MonoBehaviour
{

    public float timeLeft;
    public static float deletetime;
    public float deletetimecheck;
    public float timecheck;
	//public static float timecounter;
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 6 - deletetime;
        deletetime += (float).25;
    }

    // Update is called once per frame
    void Update()
    {
        deletetimecheck = deletetime;
        timecheck = Time.deltaTime;
        
        timeLeft -= Time.deltaTime;
        int seconds = (int)timeLeft % 60;
        timer.text = seconds.ToString();
        if(timeLeft < 1)
        {
            TimerShapeCode.circlecounter1 = 0;
            TimerShapeCode.trianglecounter1 = 0;
            TimerShapeCode.squarecounter1 = 0;
            TimerShapeCode.circlecounter = 0;
            TimerShapeCode.squarecounter = 0;
            TimerShapeCode.trianglecounter = 0;
            TimerShapeCode.timercounter = 0;
            TimerShapeCode.timercounter1 = 0;
            deletetime = 0;
            //CoinCode.coin += (TimerShapeCode.coincounter / 2);
            //PlayerPrefs.SetFloat("coin", CoinCode.coin) ;
            //PlayerPrefs.Save();
            TopScoreCode.top(ScoreCode.scorecounter);
            ModeCode.mode = "Classic";
            SceneManager.LoadScene("Over");
        }
    }
}
