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
    public Button voulume;
    public Button vibration;
    public AudioSource audioSource;

    int counter = 0;

    public static Setting inst;

    private void Awake()
    {
        inst = this;
    }

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
            voulume.image.sprite = mute;
            
        }

        else if (counter == 1)
        {
            counter = 0;
            audioSource.mute = false;
            voulume.image.sprite = unmute;
           

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
        ScreenManager.instance.showNextScreen(ScreenList.HomeScreen);
        HomeScreen.inst.Pannel.gameObject.SetActive(false);
    }
}
