using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityMVC;

public class GameAudio : MonoBehaviour
{
    public AudioClip errorAudioClip;
    public AudioSource sfxAudioSource;

    void Start()
    {
        var middleware = MVC.ConfigureMiddleware();

        middleware.OnRoute("Alert/*", (ctx, type) => 
        {
            sfxAudioSource.PlayOneShot(errorAudioClip);
            return true;
        });
    }
}
