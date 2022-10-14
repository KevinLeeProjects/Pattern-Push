using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarginsSwipeCode : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 direction;

    GameObject go;

    GameObject y;

    public GameObject f;

    string message;


    // Start is called before the first frame update
    void Start()
    {
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
                    // Record initial touch position.

                    startPos = touch.position;
                    message = "Begun ";
                    int yyy = Random.Range(200, 300);
                    y = Instantiate(f, new Vector3(touch.position.x, touch.position.y, 0), Quaternion.identity) as GameObject;

                    y.transform.parent = GameObject.Find("Canvas").transform;

                    go = GameObject.Find(y.name);

                    break;

                //Determine if the touch is a moving touch
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    direction = touch.position - startPos;
                    message = "Moving ";
                    Destroy(go);
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    message = "Ending ";
                    Destroy(go);
                    break;
            }
        }
  
    }
}
