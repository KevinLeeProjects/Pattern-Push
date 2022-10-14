using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTestCode : MonoBehaviour
{

    public static int pos;

    public static int postrack;

    public int otherpos;

    public int pos1;
    // Start is called before the first frame update
    void Start()
    {
        pos = PositionCode.pos;
        pos1 = pos;
        getpos(pos1);
        print(pos1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int getpos(int po)
    {
        postrack = po;
        return po;
    }

    public int setbo(int a)

    {
        otherpos = a;
        return otherpos;
    }

}
