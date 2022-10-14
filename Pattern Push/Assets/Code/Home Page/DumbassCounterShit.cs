using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbassCounterShit : MonoBehaviour
{
    public GameObject classic;
    public GameObject carousel;
    public GameObject margins;

    public static string mode;

    public static int counter;

    public static int othercounter=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (classic.activeInHierarchy)
        {
            mode = "Classic";
        }
        else if (carousel.activeInHierarchy)
        {
            mode = "Carousel";
        }
        else if (margins.activeInHierarchy)
        {
            mode = "Margins";
        }

    }
}
 