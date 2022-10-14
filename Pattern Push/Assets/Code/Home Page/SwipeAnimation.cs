using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwipeAnimation : MonoBehaviour
{
    [SerializeField]
    float throwforceinx = 500f;

    [SerializeField]
    float throwforceiny = 50f;

    float touchtimestart, touchtimefinish, timeinterval;

    public Vector2 startPos;
    public Vector2 direction;


    public static string homedecname;

    public static int counter;

    float starttimer;

    public GameObject g;

    GameObject y;

    public GameObject f;

    GameObject go;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find(homedecname));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                        DumbassCounterShit.counter = 0;
                        Destroy(go);
                        Destroy(GameObject.Find(homedecname));
                        y = Instantiate(f, new Vector3(touch.position.x, touch.position.y, 0), Quaternion.identity) as GameObject;
                        counter++;
                        y.transform.parent = GameObject.Find("Canvas").transform;
                        startPos = touch.position;
                        touchtimestart = Time.time;

                        go = GameObject.Find(y.name);

                        homedecname = y.name;

                        DumbassCounterShit.othercounter = 0;



                     break;
                    

                //Determine if the touch is a moving touch
                case TouchPhase.Moved:

                    Destroy(GameObject.Find(homedecname));
                    Destroy(go);
                    break;

                case TouchPhase.Ended:
                    Destroy(go);

                    Destroy(GameObject.Find(homedecname));

                    if (HomeDecTrig.counter == 1)
                    {

                    }
                    else
                    {
                        HomeDecTrig.counter = 0;
                    }
                    break;
            }
        }
    }
}
