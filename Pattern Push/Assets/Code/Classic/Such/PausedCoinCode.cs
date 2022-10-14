using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausedCoinCode : MonoBehaviour
{
    public Text cointext;
    public Text coinpausedtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinpausedtext.text = cointext.text;  
    }
}
