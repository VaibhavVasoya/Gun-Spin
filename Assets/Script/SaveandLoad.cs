using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveandLoad : MonoBehaviour
{
    public Scoresave GetScoresave;
    public static SaveandLoad inst;


    private void Awake()
    {
        inst = this;
        LoadData();
    }

    public void Saveplayerdata(int score)
    {
        GetScoresave.HighScore = score;
    }

    public void loadplayerdat()
    {
        //PlayerControler.inst.transform.position = gamesave.position;
//        ScoreManager.instance.savegame();
       // ScoreManager.instance.HighScore = GetScoresave.HighScore;

    }


    public void SaveData()
    {
        File.WriteAllText(Application.dataPath + "/Playerdata.json", JsonUtility.ToJson(GetScoresave));
    }

    public void LoadData()
    {
        GetScoresave = JsonUtility.FromJson<Scoresave>(File.ReadAllText(Application.dataPath + "/Playerdata.Json"));
    }

}


[System.Serializable]
public class Scoresave
{
    public int HighScore;
}
