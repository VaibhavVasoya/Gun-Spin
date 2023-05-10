using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreen : MonoBehaviour
{
    public Button playbutton;

    private void Start()
    {
        playbutton.onClick.AddListener(OnPlay);
    }

    public void OnPlay()
    {
        ScreenManager.instance.showNextScreen(ScreenList.GamePlayandPauseScreen);
    }
}
