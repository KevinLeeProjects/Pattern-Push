using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLeftCode : MonoBehaviour
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

    public void leftClick()
    {
        if(classic.activeInHierarchy)
        {
            classic.SetActive(false);
            carousel.SetActive(false);
            margins.SetActive(true);
        }
        else if (carousel.activeInHierarchy)
        {
            classic.SetActive(true);
            carousel.SetActive(false);
            margins.SetActive(false);
        }
        else if (margins.activeInHierarchy)
        {
            classic.SetActive(false);
            carousel.SetActive(true);
            margins.SetActive(false);
        }
    }

}
