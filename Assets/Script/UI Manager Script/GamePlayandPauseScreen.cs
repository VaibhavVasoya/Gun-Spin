using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayandPauseScreen : MonoBehaviour
{    
    public Button home;
    public GameObject pannel;
    
    private void Start()
    {
        home.onClick.AddListener(OnHome);
    }

    public void OnHome()
    {
        ScreenManager.instance.showNextScreen(ScreenList.HomeScreen);
        pannel.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void OnPause()
    {
        pannel.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnPlay()
    {
        pannel.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
       

    
}
