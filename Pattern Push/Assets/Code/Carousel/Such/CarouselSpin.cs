using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselSpin : MonoBehaviour
{

    public GameObject carousel1;
    public GameObject carousel2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        carousel1.transform.Rotate(Vector3.forward * -1);
        carousel2.transform.Rotate(Vector3.forward * 1);
    }
}
