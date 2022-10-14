using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightPos : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject lefthit;
    public GameObject righthit;
    public GameObject mode;
    public GameObject taphit;
    public GameObject tap;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var x = mode.transform.position.x / 2;
        left.transform.position = new Vector3(x, left.transform.position.y, 1);
        lefthit.transform.position = new Vector3(left.transform.position.x, left.transform.position.y, 1);

        var xx = mode.transform.position.x + x;
        right.transform.position = new Vector3(xx, right.transform.position.y, 1);
        righthit.transform.position = new Vector3(right.transform.position.x, right.transform.position.y, 1);

        taphit.transform.position = new Vector3(tap.transform.position.x, tap.transform.position.y, 1);
    }
}
