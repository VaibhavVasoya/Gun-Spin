using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private TMP_Text Score;    
    public TMP_Text HighScore;

    int score;
    int highScore;
    

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Score.text =   " Current Score :- " + score.ToString();
       HighScore.text = " HighScore:-" + highScore.ToString();


    }

    public void savegame()
    {
        //SaveLoadGame.inst.Saveplayerdata(transform.position);
        SaveandLoad.inst.Saveplayerdata(score);
    }



    public void ChangeScore()
    {
        score += 1;
        Score.text = " Current Score :- " + score.ToString();        
    }
}
