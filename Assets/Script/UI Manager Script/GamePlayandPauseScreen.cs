using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayandPauseScreen : MonoBehaviour
{
    //public Button pause;
   // public Button play;
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
    }

    public void OnPause()
    {
        pannel.gameObject.SetActive(true);
    }
  
    public void OnPlay()
    {
        pannel.gameObject.SetActive(false);
    }

    
}
