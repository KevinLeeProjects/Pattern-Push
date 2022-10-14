using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapButtonCode : MonoBehaviour
{
    public GameObject classic;
    public GameObject carousel;
    public GameObject margins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tapCode()
    {
        if (classic.activeInHierarchy)
            SceneManager.LoadScene("Classic");
        else if (carousel.activeInHierarchy)
            SceneManager.LoadScene("Carousel");
        else if (margins.activeInHierarchy)
            SceneManager.LoadScene("Margins");
    }
}
