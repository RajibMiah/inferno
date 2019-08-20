using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  //  public Text comboCount;
    public RandomPositon rp;

    public Text scoreText;
    private int highScore;
    public int coins,newTotalScore;
    private int currentScore;
    void Start()
    {
        coins = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
        currentScore = PlayerPrefs.GetInt("TotalScore");    
    }
  
    void Update()
    {    
        if (coins > highScore)
        {
            highScore = coins;
        }//highscore
        scoreText.text = "" + coins;
    }
    public void minus_coins()
    {
        currentScore -= 25;
    }
    private void OnDisable()
    {
        PlayerPrefs.SetInt("HighScore", highScore );
        PlayerPrefs.SetInt("TotalScore", currentScore += coins);
        PlayerPrefs.Save();
    } 
}
