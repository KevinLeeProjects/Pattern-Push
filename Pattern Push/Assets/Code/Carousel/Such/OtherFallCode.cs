using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherFallCode : MonoBehaviour
{
    public GameObject triangle;
    public GameObject circle;
    public GameObject square;
    public GameObject bomb;

    public GameObject bardetect;

    public Transform guide;

    public float distance;

    public static int counter;

    public GameObject gamobjecttest;

    public string stri;

    RaycastHit2D hit;

    public int it;


    public static float carouseltrianglecounter;
    public static float carouselcirclecounter;
    public static float carouselsquarecounter;


    float g;

    float h;


    int yPosition;

    int xPosition;


    public static GameObject y;
    public static GameObject x;
    GameObject z;

    GameObject f;
    GameObject e;

    public float Timer;

    public float Timer1;

    public static int newcounter;

    // Start is called before the first frame update
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


            counter = 0;
        }


        Timer1 -= Time.deltaTime;
        if (Timer1 <= 0f)
        {

            h = Random.Range(1, 5);
            Timer1 = h;

            xPosition = Random.Range(0, Screen.width);
            yPosition = Random.Range((int)(Screen.height * .6), Screen.height);

            int fifty = Random.Range(0, 4);

            if (fifty == 0)
            {
                e = triangle;
                carouseltrianglecounter += 1;
                CarouselTriangleCode.tracker = "Triangle";
            }
            else if (fifty == 1)
            {
                e = square;
                carouselsquarecounter += 1;
                CarouselTriangleCode.tracker = "Square";
            }
            else if (fifty == 2)
            {
                e = circle;
                carouselcirclecounter += 1;
                CarouselTriangleCode.tracker = "Circle";
            }
            else if (fifty == 3)
            {
                e = bomb;
            }

            x = Instantiate(e, new Vector3(Screen.width, 1600, 0), Quaternion.identity) as GameObject;
            x.GetComponent<Rigidbody2D>().AddForce(new Vector3(-100, 100, 0), ForceMode2D.Impulse);
            x.transform.parent = GameObject.Find("Canvas").transform;

            newcounter = 2;

            Timer1 = h;
        }
    }

    public void OnClick()
    {
        x.SetActive(false);
    }
}
