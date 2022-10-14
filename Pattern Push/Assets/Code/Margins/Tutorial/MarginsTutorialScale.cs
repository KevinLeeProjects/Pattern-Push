using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarginsTutorialScale : MonoBehaviour
{
    public GameObject blue;
    public GameObject red;
    public GameObject yellow;
    // Start is called before the first frame update
    void Start()
    {
        float x = blue.transform.localScale.y;
        print(x);
        float y = Screen.height * 0.000575f;
        print(y);
        float z = 0;
        if(Screen.height == 1792)
        {
            blue.transform.localScale = new Vector3(1.3f, Screen.height * 0.0008f, 1);
            z = 200f;
            blue.transform.position = new Vector3(blue.transform.position.x, blue.transform.position.y + 250f, 1);
            red.transform.position = new Vector3(red.transform.position.x, red.transform.position.y + z, 1);
            yellow.transform.localScale = new Vector3(1.3f, Screen.height * 0.0008f, 1);
            yellow.transform.position = new Vector3(yellow.transform.position.x, yellow.transform.position.y + 250f, 1);

        }
        if(y > x)
        {
            blue.transform.localScale = new Vector3(1.3f, Screen.height * 0.000575f, 1);
            z = 200f;
            blue.transform.position = new Vector3(blue.transform.position.x, blue.transform.position.y + 250f, 1);
            red.transform.position = new Vector3(red.transform.position.x, red.transform.position.y + z, 1);
        }

        float xx = yellow.transform.localScale.y;
        float yy = Screen.height * 0.000575f;
        float zz = 0;
        if(yy > xx)
        {
            yellow.transform.localScale = new Vector3(1.3f, Screen.height * 0.000575f, 1);
            zz = 200f;
            yellow.transform.position = new Vector3(yellow.transform.position.x, yellow.transform.position.y + 250f, 1);
        }



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
