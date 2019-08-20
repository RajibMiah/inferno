using UnityEngine;
using UnityEngine.UI;

public class BallCount : MonoBehaviour
{
    public GameObject ball;
    public Score score;
    public ReLoad reLoad;
    public SwipeScript swipeScript;
    private int  totalScore ;
    public int ballCount;
    private int temp;
    public bool ballCountDecrease;
    public bool ballCountIncrease;
    public Text ballText;
    

    void Start()
    {
        ballCount = 10;
        ballCountDecrease = true;
        ballCountIncrease = true;
        totalScore = PlayerPrefs.GetInt("TotalScore");

    }
    void Update()
    {
        if (ballCount < 1)
        {          
            reLoad.reStart();
        }      
        ballText.text = "" + ballCount;
    } 
    public void ballDecrease()
    {
        if(ballCountDecrease == true && swipeScript.touchTheScreen == true)
        {
            ballCount--;          
        }     
    }
    public void ballIncrease()
    {
        if(ballCountIncrease == true)
        {
            ballCount++;
            ballCountIncrease = false;
        }
    }

    public void increaseBall()
    {
        if(totalScore > 24)
        {
            FindObjectOfType<SoundManager>().Play("coin");
            ballCount++;
            score.minus_coins();
            totalScore -= 25;
            //PlayerPrefs.SetInt("TotalScore", totalScore);
        }
    }

    public  void frizz()
    {
        ballCount++;
        ballCountIncrease = false;
        swipeScript.restartDelay = 4;     
        Time.timeScale = 0;
    }
    public void is_Disable()
    {
        FindObjectOfType<SoundManager>().Play("Button_Touch");
        Time.timeScale = 1;
    }
    /*
    public void OnDisable()
    {
        PlayerPrefs.SetInt("TotalScore", totalScore);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetInt("TotalScore"));
    }
   */
}
