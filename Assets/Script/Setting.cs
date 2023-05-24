using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class Setting : MonoBehaviour
{
  
    public Sprite mute;
    public Sprite unmute;
   // public Sprite VibrationOn;
    //public Sprite VibrationOff;
    public Button btnvoulume;
    public Button vibration;
    public AudioSource audioSource;

    int counter = 0; 
    

  public void OnPlay()
    {
        audioSource.Play();
    }

    public void Volume()
    {
        if (counter == 0)
        {
            counter = 1;
            audioSource.mute = true;
            btnvoulume.image.sprite = mute;
            
        }

        else if (counter == 1)
        {
            counter = 0;
            audioSource.mute = false;
            btnvoulume.image.sprite = unmute;
           

        }

    }


   //public void Vibration()
   //{
   //    if (counter == 0)
   //    {
   //        counter = 1;
   //        // audioSource.mute = true;
   //        vibration.image.sprite = VibrationOff;
   //        VibrationButton.text = "Vibration Off";
   //    }
   //
   //    else if (counter == 1)
   //    {
   //        counter = 0;
   //        //audioSource.mute = false;
   //        vibration.image.sprite = VibrationOn;
   //        VibrationButton.text = "Vibration On";
   //
   //    }       
   //}
    public void OnClose()
    {        
        gameObject.SetActive(false);
    }
}
