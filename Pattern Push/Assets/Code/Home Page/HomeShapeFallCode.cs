using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeShapeFallCode : MonoBehaviour
{
    public float Timer;

    public GameObject back;

    public GameObject classic;
    public GameObject carousel;
    public GameObject margin;


    float startTimer = 1;
    float endTimer = 1;

    GameObject y;

    public static int marginumtrack;

    float g, h;

    int yPosition;


    int xPosition;

    public GameObject triangle;
    public GameObject circle;
    public GameObject square;

    GameObject f;
    GameObject e;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            g = Random.Range(startTimer, endTimer);
            Timer = g;
            xPosition = (int)Random.Range((float)(Screen.width * .1), (float)(Screen.width * .9));
            yPosition = Random.Range((int)(Screen.height * .6), Screen.height);
            int d = Random.Range(0, 3);


            if (d == 0)
            {
                f = triangle;
                CarouselTriangleCode.tracker = "Triangle";


            }
            else if (d == 1)
            {
                f = square;
                CarouselTriangleCode.tracker = "Square";

            }
            else if (d == 2)
            {
                f = circle;
                CarouselTriangleCode.tracker = "Circle";

            }

            int yyy = Random.Range(200, 300);

            int xxx = Random.Range(0, 45);


            y = Instantiate(f, new Vector3(xPosition, Screen.height, 0), transform.rotation * Quaternion.Euler(0f, 0f, xxx)) as GameObject;

            y.layer = 0;
            y.transform.parent = GameObject.Find("Canvas").transform;

            y.name = f + " " + marginumtrack;

            print(y.layer);

            y.transform.SetAsFirstSibling();
            back.transform.SetAsFirstSibling();

            y.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -200, 0);

            marginumtrack++;


            Timer = g;

            startTimer--;
            endTimer--;
            if (startTimer < 1)
            {
                startTimer = 0;
            }
            if (endTimer < 1)
            {
                endTimer = 1;
            }
        }
    }
}
