using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolumeController : MonoBehaviour
{
    public Slider slider;
    public float volume;
    void Start()
    {
        ListenSlider();
    }

    public void ListenSlider()
    {
        slider.onValueChanged.AddListener(delegate {
            MusicController.audioSource.volume = slider.value;
            volume = slider.value;
        });
    }
}
