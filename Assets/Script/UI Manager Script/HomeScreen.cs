using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HomeScreen : MonoBehaviour
{
    public Button playbutton;
    public float StartForce;
    public Button Gunshop;
    public GameObject Pannel;

    public static HomeScreen inst;

    private void Start()
    {
        playbutton.onClick.AddListener(OnPlay);
        Gunshop.onClick.AddListener(OnGunShop);
       
    }

    private void Awake()
    {
        inst = this;
    }

    public void OnPlay()
    {
        ScreenManager.instance.showNextScreen(ScreenList.GamePlayandPauseScreen);
        GunControler.inst.isplaying = true;
        GunControler.inst.Gamestate();
    }

    public void OnGunShop()
    {
        ScreenManager.instance.showNextScreen(ScreenList.GunShopScreen);
    }


    public void SettingPannel()
    {
        Pannel.gameObject.SetActive(true);
    }
   
}
