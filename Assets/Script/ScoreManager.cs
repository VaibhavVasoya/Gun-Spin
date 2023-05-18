using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text GamePlayCoin;
    public TMP_Text GameOverCoin;
    public TMP_Text GameOverHighestCoin;
    public TMP_Text HomeScreenCoin;
    public TMP_Text GunShopCoin;
    public bool isGameover = false;

    int Coin;
   public int highestcoin;
    


    private void Awake()
    {
        instance = this;
    }

    
    private void Start()
    {
        highestcoin = PlayerPrefs.GetInt("Highest", 0);
    }

    public void Display()
    {
        highestcoin = PlayerPrefs.GetInt("Highest", 0);
        GameOverHighestCoin.text = HomeScreenCoin.text = GunShopCoin.text = PlayerPrefs.GetInt("Highest").ToString();

    }

    public void AddCoin()
    {
        Coin++;
        GamePlayCoin.text = "Coin:- "+ Coin.ToString();
        GameOverCoin.text = GamePlayCoin.text;
    }

    public void UpdateHighest()
    {
        PlayerPrefs.SetInt("Highest",(highestcoin + Coin));
        Display();
    }


    
    

}

