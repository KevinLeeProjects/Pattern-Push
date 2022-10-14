using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopScoreCode : MonoBehaviour
{
    public static float topscore;
    // Start is called before the first frame update
    void Start()
    {
        TopScoreCode.top(ScoreCode.scorecounter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void top(int score)
    {
        if (score > PlayerPrefs.GetFloat("top")) 
        {
            topscore = score;
            PlayerPrefs.SetFloat("top", topscore);
            PlayerPrefs.Save();
        }
    }
}