using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : BaseClass
{
    public Button btnHome;
    //public Button Retry;

    private void Start()
    {
        btnHome.onClick.AddListener(OnHome);

      //  Retry.onClick.AddListener(OnRetry);
    }

    public void OnHome()
    {
        //ScreenManager.instance.showNextScreen(ScreenList.HomeScreen);
        SceneManager.LoadScene(0);
    }

    //public void OnRetry()
    //{
    //    ScreenManager.instance.showNextScreen(ScreenList.GamePlayandPauseScreen);
    //    SceneManager.LoadScene(0);
    //
    //
    //}

    
}

