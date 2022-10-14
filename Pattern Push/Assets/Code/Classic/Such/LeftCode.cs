using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCode : MonoBehaviour
{
    public GameObject classic;
    public GameObject carousel;
    public GameObject margins;

    Vector3 classic1;
    Vector3 carousel1;
    Vector3 margin1;

    public static int tracker;

 
    // Start is called before the first frame update
    void Start()
    {
        carousel.SetActive(false);
        margins.SetActive(false);
    }


    public void OnClick()
    {
        if(classic.activeInHierarchy)
        {
          
            tracker = 0;

            classic.SetActive(false);
            margins.SetActive(true);
            carousel.SetActive(false);

        }
        else if(carousel.activeInHierarchy)
        {
           
            carousel.SetActive(false);
            classic.SetActive(true);
            margins.SetActive(false);
            tracker = 1;

        }
        else if(margins.activeInHierarchy)
        {
          
            carousel.SetActive(true);
            margins.SetActive(false);
            classic.SetActive(false);
            tracker = 2;
        }
        
    }

    IEnumerator classicmethod()
    {
        yield return new WaitForSeconds(1);
        print(classic.transform.position.x);
        margins.SetActive(false);
        classic.SetActive(false);
        margins.SetActive(true);
        carousel.SetActive(false);
        classic.transform.position = new Vector3(classic1.x, classic1.y, classic1.z);
        margins.transform.position = new Vector3(margin1.x, margin1.y, margin1.z);
        

    }

    IEnumerator carouselmethod()
    {
        yield return new WaitForSeconds(1);
        carousel.SetActive(false);
        classic.SetActive(true);
        margins.SetActive(false);
        carousel.transform.position = new Vector3(carousel1.x, carousel1.y, carousel1.z);
    }

    IEnumerator marginmethod()
    {
        yield return new WaitForSeconds(1);
        carousel.SetActive(true);
        margins.SetActive(false);
        classic.SetActive(false);
        margins.transform.position = new Vector3(margin1.x, margin1.y, margin1.z);
    }
}
