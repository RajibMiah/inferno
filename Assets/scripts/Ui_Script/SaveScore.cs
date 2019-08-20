using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScore : MonoBehaviour
{
    private int highScore, totalScore;
    public Text TotalScore_Text;
    public Text HighScore_Text;
    private void OnEnable()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        totalScore = PlayerPrefs.GetInt("TotalScore");
    }
    private void Start()
    {
        TotalScore_Text.text = " " + totalScore;
        HighScore_Text.text = "" + highScore;
      
    }
    private void OnDisable()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        totalScore = PlayerPrefs.GetInt("TotalScore");
        
    }
}
