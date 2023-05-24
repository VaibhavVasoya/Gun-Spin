using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HomeScreen : BaseClass
{
    public Button btnplay;
    public float StartForce;
    public Button btnGunshop;
    public GameObject settingPannel;
    GunControler controler;

    

    private void Start()
    {
        btnplay.onClick.AddListener(OnPlay);
        btnGunshop.onClick.AddListener(OnGunShop);
        ScoreManager.instance.Display();
       
    }
   

    public void OnPlay()
    {

        ScreenManager.instance.showNextScreen(ScreenList.GamePlayandPauseScreen);
        GunControler.inst.GameOnstart();
       // controler.GameOnstart();
    }

    public void OnGunShop()
    {
        ScreenManager.instance.showNextScreen(ScreenList.GunShopScreen);
    }


    public void SettingPannel()
    {
        settingPannel.gameObject.SetActive(true);
    }
   
}
