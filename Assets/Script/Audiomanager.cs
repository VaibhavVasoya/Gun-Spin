using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager inst;
    public Sound BackgroundSound;
    public Sound[] playersoundsound;
    public AudioSource BackgroundSource, playersoundsource;

    private void Awake()
    {
        inst = this;
    }

    public void Start()
    {
        OnBGplay();
    }

    public void OnBGplay()
    {
       BackgroundSource.clip = BackgroundSound.audioClip;
       BackgroundSource.Play();
    }

    public void OnplaySound(string Name)
    {
        Sound s = Array.Find(playersoundsound, x => x.Name == Name);
        if (s == null)
        {
            Debug.Log("sound not found");
        }
        else
        {
            playersoundsource.PlayOneShot(s.audioClip,1);
            
        }
    }

   
   



}



[System.Serializable]
public class Sound
{
    public string Name;
    public AudioClip audioClip;
}
