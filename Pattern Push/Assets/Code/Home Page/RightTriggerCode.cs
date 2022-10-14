using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTriggerCode : MonoBehaviour
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HomeCircle" || collision.gameObject.tag == "HomeSquare" || collision.gameObject.tag == "HomeTriangle")
        {

        }

        else
        {
            if (classic.activeInHierarchy)
            {
                classic.SetActive(false);
                carousel.SetActive(true);
                margins.SetActive(false);
                LeftCode.tracker = 0;
            }
            else if (carousel.activeInHierarchy)
            {
                classic.SetActive(false);
                carousel.SetActive(false);
                margins.SetActive(true);
                LeftCode.tracker = 1;
            }
            else if (margins.activeInHierarchy)
            {
                margins.SetActive(false);
                classic.SetActive(true);
                carousel.SetActive(false);
                LeftCode.tracker = 2;
            }
            collision.gameObject.SetActive(false);
        }
    }
}