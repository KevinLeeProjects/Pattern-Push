using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClassicCoinCode : MonoBehaviour
{
    public static float coin1;
    public static float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter++;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 2)
        {
            coin1 = PlayerPrefs.GetFloat("coin1") + 1;
            PlayerPrefs.SetFloat("coin1", coin1);
            PlayerPrefs.Save();
            counter = 0;
        }
    }
}
