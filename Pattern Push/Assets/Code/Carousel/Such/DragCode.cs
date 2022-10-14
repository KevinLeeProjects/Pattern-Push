using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DragCode : MonoBehaviour
{

    public Vector2 startPos;
    public Vector2 direction;

    GameObject go;
        
    GameObject y;

    public GameObject f;

    string message;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
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
