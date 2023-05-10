using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public List<BaseClass> Screenlist;
    BaseClass currentscreen;

    public static ScreenManager instance;

    private void Awake()
    {
        instance = this;
        currentscreen = Screenlist[0];
    }

    public void showNextScreen(ScreenList screen)
    {
        currentscreen.CanvasDisable();
        Screenlist[(int)screen].CanvasEnable();
        currentscreen = Screenlist[(int)screen];
    }
}




