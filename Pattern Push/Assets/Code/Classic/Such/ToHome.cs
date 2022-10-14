using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clicked()
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
        ClassicDecagon.track = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
