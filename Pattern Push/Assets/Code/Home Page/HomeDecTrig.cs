using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeDecTrig : MonoBehaviour
{

    public GameObject classic;
    public GameObject carousel;
    public GameObject margins;
    public static string homedectr;

    

    GameObject go;

    public static int counter;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(GameObject.Find(SwipeAnimation.homedecname));
        homedectr = collision.gameObject.name;

        if (collision.gameObject.tag == "HomeCircle" || collision.gameObject.tag == "HomeSquare" || collision.gameObject.tag == "HomeTriangle")
        {
            DumbassCounterShit.counter = 1;

            Destroy(GameObject.Find(SwipeAnimation.homedecname));
            Destroy(GameObject.Find(SwipeAnimation.homedecname));
            Destroy(GameObject.Find(SwipeAnimation.homedecname));
            counter++;
            Destroy(collision.gameObject);
            Destroy(GameObject.Find(SwipeAnimation.homedecname));
            Destroy(GameObject.Find(SwipeAnimation.homedecname));
            Destroy(GameObject.Find(SwipeAnimation.homedecname));

        }
        else if (collision.gameObject.tag == "HomeLeft" || collision.gameObject.tag == "HomeRight")
        {

            Destroy(GameObject.Find(SwipeAnimation.homedecname));
            DumbassCounterShit.counter = 1;
            counter++;
            Destroy(GameObject.Find(SwipeAnimation.homedecname));

        }
        else if (collision.gameObject.tag == "HomeBackground")//if(DumbassCounterShit.counter == 1)//if (DumbassCounterShit.counter == 0)
        {

            DumbassCounterShit.mode = "";
            counter++;
            DumbassCounterShit.counter = 0;
        }
        else
        {

        }
        if(counter == 1)
        {
 
        }
        else
        {

        }

    }
    IEnumerator Example()
    {
        Time.timeScale = 0;
        print(Time.time);
        Destroy(GameObject.Find(SwipeAnimation.homedecname));
        DumbassCounterShit.othercounter = 0;
        Destroy(GameObject.Find(SwipeAnimation.homedecname));
        yield return new WaitForSeconds(10);
        Destroy(GameObject.Find(SwipeAnimation.homedecname));
        DumbassCounterShit.othercounter = 1;
        Destroy(GameObject.Find(SwipeAnimation.homedecname));
        Time.timeScale = 1;
        print(Time.time);
    }
}
