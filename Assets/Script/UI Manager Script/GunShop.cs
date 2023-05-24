using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunShop : BaseClass
{
    public Button Close;
   // GunControler gun;


    private void Start()
    {
        Close.onClick.AddListener(Onclose);
        ScoreManager.instance.Display();
    }

    public void Onclose()
    {
        ScreenManager.instance.showNextScreen(ScreenList.HomeScreen);
    }


    public void GunSelect(int number)
    
    {
        GunControler.inst.CurrentGun = number;
       
    }


    public void Onbuy()
    {
        if (ScoreManager.instance.highestcoin >= 500)
        {
            Debug.Log("Buy");
            ScoreManager.instance.highestcoin -= 500;
            GunControler.inst.isbuyed = true;
        }
        else
        {
            Debug.Log("not enough coin");
        }
    }


   





}
