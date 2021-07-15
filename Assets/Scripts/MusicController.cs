using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    static MusicController musicController;
    public static AudioSource audioSource;
    void Start()
    {
        if(musicController != null)
        {
            Destroy(gameObject);
        }
        else
        {
            musicController = this;
            audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
            Invoke("LoadMenuScene", 3f);
        }
    }

    void LoadMenuScene()
    {
        GameObject.Find("SceneControlManager").GetComponent<SceneController>().LoadMenu();
    }

    
}
