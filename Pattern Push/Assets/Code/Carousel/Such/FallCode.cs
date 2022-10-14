using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCode : MonoBehaviour
{
    public GameObject triangle;
    public GameObject circle;
    public GameObject square;
    public GameObject bomb;

    public GameObject turndial;
    public GameObject turndial2;
    public GameObject stick;
    public GameObject stick2;
    public GameObject back;

    

    public GameObject triangletest;


    public GameObject bardetect;

    public Transform guide;

    public static int numtracker;

    public float distance;

    public static int counter;

    public GameObject gamobjecttest;

    public string stri;

    RaycastHit2D hit;

    int roundcounter;
    int roundcounter1;

    public int it;

    public int pos;

    float timeLeft = 10;

    public static ArrayList arr = new ArrayList();

    float startTimer = 3;
    float endTimer = 4;
    float startTimer2 = 3;
    float endTimer2 = 4;

    public static int carouseltrianglecounter;
    public static int carouselcirclecounter;
    public static int carouselsquarecounter;


    float g;

    float h;


    int yPosition;

    int xPosition;


    GameObject y;
    GameObject x;
    GameObject z;

    GameObject f;
    GameObject e;

    public float Timer;

    public float Timer1;

    public int newcounter;


    void Start()
    {


    }

    public IEnumerator DoInstantiate()
    {

        yield return new WaitForSeconds(1f);

    }


    // Update is called once per frame
    void Update()
    {
        if (counter == 1)
        {

            ButtonTestCode btc = GetComponent<ButtonTestCode>();

            counter = 0;
        }


        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            g = Random.Range(startTimer, endTimer);
            Timer = g;
            xPosition = Random.Range(0, Screen.width);
            yPosition = Random.Range((int)(Screen.height * .6), Screen.height);
            int d = Random.Range(0, 4);

            var hy = Screen.width * 0.001f;



            if (d == 0)
            {
                f = triangle;
                carouseltrianglecounter+=1;
                CarouselTriangleCode.tracker = "Triangle";
                
                
            }
            else if(d == 1)
            {
                f = square;
                carouselsquarecounter+=1;
                CarouselTriangleCode.tracker = "Square";

            }
            else if(d == 2)
            {
                f = circle;
                carouselcirclecounter+=1;
                CarouselTriangleCode.tracker = "Circle";

            }
            else if(d == 3)
            {
                f = bomb;
                
            }

            int yyy = Random.Range(100,150);

            var yuy = Random.Range(Screen.height * 0.6f, Screen.height * 0.8f);

            y = Instantiate(f, new Vector3(0, yuy, 0), Quaternion.identity) as GameObject;
            y.transform.localScale = new Vector3(hy, hy, 1);

            y.GetComponent<Rigidbody2D>().AddForce (new Vector3(100, 100,0) * yyy);

            y.transform.parent = GameObject.Find("Canvas").transform;
            y.name = f + " " +numtracker;


            y.transform.SetAsFirstSibling();
            turndial.transform.SetAsFirstSibling();
            turndial2.transform.SetAsFirstSibling();
            stick.transform.SetAsFirstSibling();
            stick2.transform.SetAsFirstSibling();
            back.transform.SetAsFirstSibling();

            numtracker++;
            pos = PositionCode.pos;

            PositionCode.pos++;

            arr.Add(y);

            newcounter = 1;


            Timer = g;
            roundcounter++;

            if (roundcounter > 5)
            {
                startTimer--;
                endTimer--;
                if (startTimer < 0)
                {
                    startTimer = 0.75f;
                }
                if (endTimer < 1)
                {
                    endTimer = 1;
                }
                roundcounter = 0;

            }
        }
        Timer1 -= Time.deltaTime;
        if (Timer1 <= 0f)
        {

            h = Random.Range(startTimer2, endTimer2);
            Timer1 = h;

            xPosition = Random.Range(0, Screen.width);
            yPosition = Random.Range((int)(Screen.height * .6), Screen.height);

            int fifty = Random.Range(0, 4);

            if (fifty == 0)
            {
                e = triangle;
                carouseltrianglecounter+=1;
                CarouselTriangleCode.tracker = "Triangle";
            }
            else if (fifty == 1)
            {
                e = square;
                carouselsquarecounter+=1;
                CarouselTriangleCode.tracker = "Square";
            }
            else if (fifty == 2)
            {
                e = circle;
                carouselcirclecounter+=1;
                CarouselTriangleCode.tracker = "Circle";
            }
            else if(fifty == 3)
            {
                e = bomb;
            }

            int xxx= Random.Range(100,150);

            var gh = Screen.width * 0.001f;

            var yuy = Random.Range(Screen.height * 0.6f, Screen.height * 0.8f);

            x = Instantiate(e, new Vector3(Screen.width, yuy, 0), Quaternion.identity) as GameObject;
            x.transform.localScale = new Vector3(gh, gh, 1);
            x.GetComponent<Rigidbody2D>().AddForce(new Vector3(-100, 100, 0) * xxx);
            x.transform.parent = GameObject.Find("Canvas").transform;
            x.name = e + " " + numtracker;


            x.transform.SetAsFirstSibling();
            turndial.transform.SetAsFirstSibling();
            turndial2.transform.SetAsFirstSibling();
            stick.transform.SetAsFirstSibling();
            stick2.transform.SetAsFirstSibling();
            back.transform.SetAsFirstSibling();

            numtracker++;

            pos = PositionCode.pos;

            PositionCode.pos++;

            arr.Add(x);



            newcounter = 2;

            Timer1 = h;

            roundcounter1++;

            if (roundcounter1 > 5)
            {
                startTimer2--;
                endTimer2--;
                if (startTimer2 < 0)
                {
                    startTimer2 = 0.75f;
                }
                if (endTimer2 < 1)
                {
                    endTimer2 = 1;
                }
                roundcounter1 = 0;
            }
        }

    }

    public void OnClick()
    {
        counter = 1;
    }

    public GameObject dest(GameObject gam)
    {
        return (gam);
    }



}
