using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public static GameManager instance;

    private const string HIGH_SCORE = "High Score";

    void Awake(){
        _MakeSingleInstance();
        IsGameStartedForTheFisrtTime();
    }

    void IsGameStartedForTheFisrtTime(){
        if (!PlayerPrefs.HasKey("IsGameStartedForTheFisrtTime")){
            PlayerPrefs.SetInt(HIGH_SCORE, 0);
            PlayerPrefs.SetInt("IsGameStartedForTheFisrtTime",0);
        }
    }

    void _MakeSingleInstance(){
        if(instance != null){
            Destroy(gameObject);
        } else{
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }

    public void SetHighScore(int score){
        PlayerPrefs.SetInt(HIGH_SCORE, score);
    }

    public int GetHighScore(){
        return PlayerPrefs.GetInt(HIGH_SCORE);
    }
}
