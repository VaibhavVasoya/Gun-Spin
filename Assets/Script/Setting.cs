using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Setting : MonoBehaviour
{
    public Text VolumeButton;
    public Text VibrationButton;
    public Sprite mute;
    public Sprite unmute;
    public Sprite VibrationOn;
    public Sprite VibrationOff;
    public Button voulume;
    public Button vibration;

    int counter = 0;
    
    public void Volume()
    {
        if (counter == 0)
        {
            counter = 1;
            // audioSource.mute = true;
            voulume.image.sprite = mute;
            VolumeButton.text = "Volume Off";
        }

        else if (counter == 1)
        {
            counter = 0;
            //audioSource.mute = false;
            voulume.image.sprite = unmute;
            VolumeButton.text = "Volume On";

        }

    }


    public void Vibration()
    {
        if (counter == 0)
        {
            counter = 1;
            // audioSource.mute = true;
            vibration.image.sprite = VibrationOff;
            VibrationButton.text = "Vibration Off";
        }

        else if (counter == 1)
        {
            counter = 0;
            //audioSource.mute = false;
            vibration.image.sprite = VibrationOn;
            VibrationButton.text = "Vibration On";

        }       
    }
    public void OnClose()
    {
        ScreenManager.instance.showNextScreen(ScreenList.HomeScreen);
        HomeScreen.inst.Pannel.gameObject.SetActive(false);
    }
}
