using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarouselFade : MonoBehaviour
{
    Image rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Image>();
        //Color c = rend.material.color;
        //c.a = 0f;
        //rend.material.color = c;

        StartCoroutine("FadeIn");
        StartCoroutine(FadeIn());
        //StartCoroutine("FadeOut");
        //StartCoroutine(FadeOut());

        //while (true)
        //{
        //    StartCoroutine("FadeIn");
        //    StartCoroutine("FadeOut");
        //}
    }

    // Update is called once per frame

    IEnumerator FadeIn()
    {
        print("Fade");
        while (true)
        {
            for (float f = 1f; f >= -0.05f; f -= 0.05f)
            {
                Color c = rend.material.color;
                c.a = f;
                rend.material.color = c;
                yield return new WaitForSecondsRealtime(0.075f);
            }
            for (float f = 0.05f; f <= 1; f += 0.05f)
            {
                Color c = rend.material.color;
                c.a = f;
                rend.material.color = c;
                yield return new WaitForSecondsRealtime(0.075f);
            }

        }
    }

    IEnumerator FadeOut()
    {
        print("FadeOut");
        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading()
    {
        StartCoroutine("FadeIn");
    }

    public void stopFading()
    {
        StartCoroutine("FadeOut");
    }
}

