using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarginRedCode : MonoBehaviour
{
    public static int marginscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag != "MarginCircle")
        {
            ModeCode.mode = "Margins";
            SceneManager.LoadScene("Over");
        }
        else
        {
            marginscore++;
        }
    }
}
