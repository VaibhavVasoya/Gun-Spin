using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Button Home;
    public Button Retry;

    private void Start()
    {
        Home.onClick.AddListener(OnHome);

        Retry.onClick.AddListener(OnRetry);
    }

    public void OnHome()
    {
        ScreenManager.instance.showNextScreen(ScreenList.HomeScreen);
    }

    public void OnRetry()
    {
        ScreenManager.instance.showNextScreen(ScreenList.GamePlayandPauseScreen);
    }

    
}

