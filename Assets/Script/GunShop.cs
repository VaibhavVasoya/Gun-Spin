using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunShop : MonoBehaviour
{
    public Button Close;


    private void Start()
    {
        Close.onClick.AddListener(Onclose);
    }

    public void Onclose()
    {
        ScreenManager.instance.showNextScreen(ScreenList.HomeScreen);
    }


    public void GunSelect(int number)
    
    {
        GunControler.inst.CurrentGun = number;
    }



   





}
