using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    public static Pause testpause;
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
    public GameObject ad;
    public GameObject store;
    public GameObject volume;
    public GameObject leaderboard;

    public static string classictapname;

    GameObject y;

    void Start()
    {
        testpause = this;

    }

    public void test()
    {

    }


    public void TogglePause()
    {

        Time.timeScale = 0.000000000001f;
        classic.GetComponent<Image>().enabled = true;
        pausetext.SetActive(true);
        background.SetActive(true);
        coinimage.SetActive(true);
        cointext.SetActive(true);
        topimage.SetActive(true);
        toptext.SetActive(true);
        score.SetActive(true);
        scoretext.SetActive(true);
        restart.SetActive(true);
        home.SetActive(true);
        setting.SetActive(true);

        classic.SetActive(true);

        ad.SetActive(true);
        store.SetActive(true);
        volume.SetActive(true);
        leaderboard.SetActive(true);


        

        int x = (int)(home.transform.position.y + ad.transform.position.y);

        y = Instantiate(classic, new Vector3(Screen.width / 2, (home.transform.position.y + ad.transform.position.y) / 2, 0), Quaternion.identity) as GameObject;
        y.transform.localScale = new Vector3(Screen.width * .0018f, Screen.height * .001f, 1);
        y.transform.parent = GameObject.Find("Canvas").transform;

        classic.GetComponent<Image>().enabled = false;
        classictapname = y.name;

    }

    public void Unpause()
    {
        Time.timeScale = 1;
        pausetext.SetActive(false);
        background.SetActive(false);
        coinimage.SetActive(false);
        cointext.SetActive(false);
        topimage.SetActive(false);
        toptext.SetActive(false);
        score.SetActive(false);
        scoretext.SetActive(false);
        restart.SetActive(false);
        home.SetActive(false);
        setting.SetActive(false);
        left.SetActive(false);
        right.SetActive(false);
        classic.SetActive(false);
        ad.SetActive(false);
        store.SetActive(false);
        volume.SetActive(false);
        leaderboard.SetActive(false);

        Destroy(GameObject.Find(classictapname));

        ClassicDecagon.track = 0;

    }
}
