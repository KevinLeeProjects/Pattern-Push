using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTriggerCode : MonoBehaviour
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
        if(collision.gameObject.tag == "HomeCircle" || collision.gameObject.tag == "HomeSquare" || collision.gameObject.tag == "HomeTriangle")
        {

        }
        else
        {
            print(collision.gameObject.name);

            if (classic.activeInHierarchy)
            {
                classic.SetActive(false);
                margins.SetActive(true);
                carousel.SetActive(false);

            }
            else if (carousel.activeInHierarchy)
            {
                carousel.SetActive(false);
                classic.SetActive(true);
                margins.SetActive(false);
            }
            else if (margins.activeInHierarchy)
            {
                carousel.SetActive(true);
                margins.SetActive(false);
                classic.SetActive(false);
            }
            collision.gameObject.SetActive(false);
        }
    }
}
