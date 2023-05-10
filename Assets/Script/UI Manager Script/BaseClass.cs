using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{ 
    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void CanvasEnable()
    {
        canvas.enabled = true;
    }

    public void CanvasDisable()
    {
        canvas.enabled = false;
    }
}

public enum ScreenList
{
    HomeScreen,
    GamePlayandPauseScreen,
    GameOverScreen,
}

