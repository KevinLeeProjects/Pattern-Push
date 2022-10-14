using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarginOverTopCode : MonoBehaviour
{
    public static float marginsovertop;
    // Start is called before the first frame update
    void Start()
    {
        marginsovertopmethod(MarginRedCode.marginscore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void marginsovertopmethod(int score)
    {
        if (score > PlayerPrefs.GetFloat("margintop"))
        {
            marginsovertop = score;
            PlayerPrefs.SetFloat("margintop", marginsovertop);
            PlayerPrefs.Save();
        }
    }
}
