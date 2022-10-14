using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarginsTutorialDone : MonoBehaviour
{
    public static float marginstutorial = 0f;

    public GameObject done;
    public GameObject background;
    public GameObject tutorial;
    public GameObject red;
    public GameObject blue;
    public GameObject yellow;
    public GameObject word;
    public GameObject donehitbox;
    public GameObject margins;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void frick()
    {
        marginstutorial = 1f;
        done.SetActive(false);
        background.SetActive(false);
        tutorial.SetActive(false);
        red.SetActive(false);
        blue.SetActive(false);
        yellow.SetActive(false);
        word.SetActive(false);
        donehitbox.SetActive(false);
        margins.SetActive(false);
        score.SetActive(false);
        PlayerPrefs.SetFloat("marginstutorial", marginstutorial);
        PlayerPrefs.Save();
        Time.timeScale = 1f;
    }
}
