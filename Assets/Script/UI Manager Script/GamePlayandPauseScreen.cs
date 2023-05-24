using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayandPauseScreen : BaseClass
{    
    public Button btnhome;
    public GameObject pausepannel;
    
    private void Start()
    {
        btnhome.onClick.AddListener(OnHome);
    }

    public void OnHome()
    {
        //ScreenManager.instance.showNextScreen(ScreenList.HomeScreen);
        pausepannel.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void OnPause()
    {
        pausepannel.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnPlay()
    {
        pausepannel.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
       

    
}
