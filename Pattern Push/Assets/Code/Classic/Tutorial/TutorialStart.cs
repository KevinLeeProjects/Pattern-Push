using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStart : MonoBehaviour
{
    public float classictutorialgetcode;

    public GameObject tutorial;
    public GameObject classic;
    public GameObject score;
    public GameObject done;
    public GameObject timer;
    public GameObject circle;
    public GameObject triangle;
    public GameObject square;
    public GameObject word;
    public GameObject background;
    public GameObject donehitbox;
    // Start is called before the first frame update
    void Start()
    {
       classictutorialgetcode  = PlayerPrefs.GetFloat("classictutorial");
        if(classictutorialgetcode == 1f)
        {
            background.SetActive(false);
            tutorial.SetActive(false);
            classic.SetActive(false);
            score.SetActive(false);
            done.SetActive(false);
            timer.SetActive(false);
            circle.SetActive(false);
            triangle.SetActive(false);
            square.SetActive(false);
            word.SetActive(false);
            donehitbox.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
