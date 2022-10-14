using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausedScoreCode : MonoBehaviour
{
    public Text actualscore;
    public Text pausedscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pausedscore.text = actualscore.text;
    }
}
