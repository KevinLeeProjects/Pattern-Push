using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartCode : MonoBehaviour
{

    public GameObject heart3;
    public GameObject heart2;
    public GameObject heart1;

    public static int life;
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 3)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
        else if(life == 2)
        {
            heart3.SetActive(false);
        }
        else if(life == 1)
        {
            heart2.SetActive(false);
        }
        else if(life == 0)
        {
            heart1.SetActive(false);
            FallCode.carouselcirclecounter = 0;
            FallCode.carouseltrianglecounter = 0;
            FallCode.carouselsquarecounter = 0;
            HeartCode.life = 3;
            ModeCode.mode = "Carousel";
            SceneManager.LoadScene("Over");
        }
    }
}
