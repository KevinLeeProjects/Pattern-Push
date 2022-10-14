using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderCode : MonoBehaviour
{
    public GameObject back;
    //public GameObject settings;
    public GameObject volume;
    public GameObject credits;
    public GameObject store;
    public GameObject hitbox;

    // Start is called before the first frame update
    void Start()
    {
        back.transform.position = new Vector3(Screen.width * 0.1f, Screen.height * 0.9f, 1);
        back.transform.parent = GameObject.Find("Canvas").transform;

        volume.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.75f, 1);
        volume.transform.parent = GameObject.Find("Canvas").transform;

        credits.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 1);
        credits.transform.parent = GameObject.Find("Canvas").transform;

        store.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.25f, 1);
        store.transform.parent = GameObject.Find("Canvas").transform;

        hitbox.transform.position = new Vector3(back.transform.position.x, back.transform.position.y, 1);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
