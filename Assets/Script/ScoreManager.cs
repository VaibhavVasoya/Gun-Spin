using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text Score;
   // public TMP_Text HighScore;

    int score;
    int highScore;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Score.text =   " Current Score :- " + score.ToString();
      // HighScore.text = " HighScore:-" + highScore.ToString();


    }

    public void ChangeScore()
    {
        score += 1;
        Score.text = " Current Score :- " + score.ToString();
    }
}
