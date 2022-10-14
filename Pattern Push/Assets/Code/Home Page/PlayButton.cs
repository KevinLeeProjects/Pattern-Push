using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject classic;
    public GameObject carousel;
    public GameObject margins;

    public static int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        if (classic.activeInHierarchy)
        {
            SceneManager.LoadScene("Classic");
            x = 1;
        }
        else if(carousel.activeInHierarchy)
        {
            SceneManager.LoadScene("Carousel");
            x = 2;
        }
        else if(margins.activeInHierarchy)
        {
            SceneManager.LoadScene("Margins");
            x = 0;
        }
    }
}
