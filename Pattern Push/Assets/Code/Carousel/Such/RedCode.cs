using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedCode : MonoBehaviour
{

    public Image redbottom;
    public Image redtop;
    public Image redleft;
    public Image redright;

    public static Vector3 vec;

    public static int x;

    public static int y;

    private YieldInstruction fadeInstruction = new YieldInstruction();

    float fadeTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        redbottom.enabled = false;
        redtop.enabled = false;
        redleft.enabled = false;
        redright.enabled = false;
        vec = new Vector3(0, 0, 0);
        y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (y == 1)
        {
            if (vec.y > (Screen.height / 2))
            {
                StartCoroutine(FadeIn(redtop));
                StartCoroutine(FadeOut(redtop));
                
                y = 0;
            }
            if (vec.x < (Screen.width / 2))
            {
                StartCoroutine(FadeIn(redleft));
                StartCoroutine(FadeOut(redleft));
                
                y = 0;
            }
            if(vec.x >= (Screen.width/2))
            {
                StartCoroutine(FadeIn(redright));
                StartCoroutine(FadeOut(redright));
                
                y = 0;
            }
            if(vec.y <= (Screen.height/2))
            {
                StartCoroutine(FadeIn(redbottom));
                StartCoroutine(FadeOut(redbottom));
                
                y = 0;
            }
        }
    }

    IEnumerator FadeOut(Image image)
    {
        float elapsedTime = 0.0f;
        Color c = image.color;
        while (elapsedTime < fadeTime)
        {
            yield return fadeInstruction;
            elapsedTime += Time.deltaTime;
            c.a = 1.0f - Mathf.Clamp01(elapsedTime / fadeTime);
            image.color = c;
        }
    }

    IEnumerator FadeIn(Image image)
    {

        image.enabled = true;
        float elapsedTime = 0.0f;
        Color c = image.color;
        while (elapsedTime < fadeTime)
        {
            yield return fadeInstruction;
            elapsedTime += Time.deltaTime;
            c.a = Mathf.Clamp01(elapsedTime / fadeTime);
            image.color = c;
        }
    }
}
