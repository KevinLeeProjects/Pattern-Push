using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarginsActualSwipCode : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 direction;

    float touchtimestart, touchtimefinish, timeinterval;


    [SerializeField]
    float throwforceinx = 50f;

    [SerializeField]
    float throwforceiny = 50f;

    [SerializeField]
    float throwforceinz = 50f;

    Rigidbody2D rb;

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
                    touchtimestart = Time.time;

                    break;

                //Determine if the touch is a moving touch
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    touchtimefinish = Time.time;
                    direction = touch.position - startPos;
                    timeinterval = touchtimefinish - touchtimestart;
                    rb = GameObject.Find(MarginDecagonTriggered.str).GetComponent<Rigidbody2D>();
                    rb.AddForce(direction / timeinterval * throwforceiny); 
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    
                    break;
            }
        }
    }
}
