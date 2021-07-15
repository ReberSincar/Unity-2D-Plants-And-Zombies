using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolumeController : MonoBehaviour
{
    public Slider slider;
    void Start()
    {
        slider.value = PlayerSettings.GetVolumeLevel();
        ListenSlider();
    }

    public void ListenSlider()
    {
        slider.onValueChanged.AddListener(delegate {
            PlayerSettings.SetVolumeLevel(slider.value);
            MusicController.audioSource.volume = slider.value;
        });
    }
}
