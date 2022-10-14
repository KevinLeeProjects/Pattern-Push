using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnTriggerCounterCode : MonoBehaviour
{

    public Image rend;

    private YieldInstruction fadeInstruction = new YieldInstruction();

    float fadeTime = 1f;



    // Start is called before the first frame update
    void Start()
    {
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(collision.gameObject);
        if (("Carousel" + CarouselTimerCode.timertest) == collision.gameObject.tag)
        {
            

            if(collision.gameObject.tag == "CarouselTriangle")
            {
                FallCode.carouseltrianglecounter -= 1;
                StartCoroutine(FadeIn(rend));
                StartCoroutine(FadeOut(rend));
                if (HeartCode.life > 0)
                {
                    HeartCode.life--;

                }

                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;
                    HeartCode.life = 3;
                    SceneManager.LoadScene("CarouselOver");

                }

            }
            else if(collision.gameObject.tag == "CarouselSquare")
            {
                FallCode.carouselsquarecounter -= 1;
                StartCoroutine(FadeIn(rend));
                StartCoroutine(FadeOut(rend));
                if (HeartCode.life > 0)
                {
                    HeartCode.life--;

                }

                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;
                    HeartCode.life = 3;
                    SceneManager.LoadScene("CarouselCarouselOver");

                }
            }
            else if(collision.gameObject.tag == "CarouselCircle")
            {
                FallCode.carouselcirclecounter -= 1;
                StartCoroutine(FadeIn(rend));
                StartCoroutine(FadeOut(rend));
                if (HeartCode.life > 0)
                {
                    HeartCode.life--;

                }

                else if (HeartCode.life == 0)
                {
                    FallCode.carouselcirclecounter = 0;
                    FallCode.carouseltrianglecounter = 0;
                    FallCode.carouselsquarecounter = 0;
                    HeartCode.life = 3;
                    SceneManager.LoadScene("CarouselOver");

                }
            }
            else if(collision.gameObject.tag == "CarouselBomb")
            {

            }
            
            PositionCode.pos1--;
            FallCode.arr.RemoveAt(0);
        }
        else
        {
            
        }
    }

    IEnumerator sec()
    {
        yield return new WaitForSeconds(1.0f);
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
        rend.enabled = true;
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

