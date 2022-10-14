using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public Slider slider;
    public AudioSource music;

    public static float volume;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volume");
        volume = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {
        
        volume = slider.value;
        music.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.Save();

    }
}
