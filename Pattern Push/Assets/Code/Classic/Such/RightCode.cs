using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCode : MonoBehaviour
{

    public static int x;
    public GameObject classic;

    public GameObject carousel;

    public GameObject margins;
    // Start is called before the first frame update
    void Start()
    {
       // carousel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if(classic.activeInHierarchy)
        {
            classic.SetActive(false);
            carousel.SetActive(true);
            margins.SetActive(false);
            LeftCode.tracker = 0;
        }
        else if(carousel.activeInHierarchy)
        {
            classic.SetActive(false);
            carousel.SetActive(false);
            margins.SetActive(true);
            LeftCode.tracker = 1;
        }
        else if(margins.activeInHierarchy)
        {
            margins.SetActive(false);
            classic.SetActive(true);
            carousel.SetActive(false);
            LeftCode.tracker = 2;
        }
        //if(x == 0)
        //{
        //    classic.SetActive(false);
        //    carousel.SetActive(true);
        //    margins.SetActive(false);
        //    x = 1;
        //}
        //else if(x == 1)
        //{
        //    carousel.SetActive(false);
        //    margins.SetActive(true);
        //    classic.SetActive(false);
        //    x = 2;
        //}
        //else if(x == 2)
        //{
        //    carousel.SetActive(false);
        //    margins.SetActive(false);
        //    classic.SetActive(true);
        //    x = 0;
        //}
    }
}
