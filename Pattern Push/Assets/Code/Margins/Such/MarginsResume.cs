using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarginsResume : MonoBehaviour
{
    public static Pause testpause;
    public GameObject pausetext;
    public GameObject background;
    public GameObject restart;
    public GameObject home;
    public GameObject setting;
    public GameObject left;
    public GameObject right;
    public GameObject classic;
    public GameObject resume;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resumebutton()
    {
        pausetext.SetActive(false);
        background.SetActive(false);
        restart.SetActive(false);
        home.SetActive(false);
        setting.SetActive(false);
        left.SetActive(false);
        right.SetActive(false);
        classic.SetActive(false);
        resume.SetActive(false);
        //MarginRedCode.marginscore = 0;
        Time.timeScale = 1;
        //SceneManager.LoadScene("Margins");
    }
}
