using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselTimerPosCode : MonoBehaviour
{
    public GameObject txt;
    public GameObject shape;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.transform.position = new Vector3(shape.transform.position.x, shape.transform.position.y+15, 1);
    }
}
