using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositon : MonoBehaviour
{
 
    public collisionDetect collDetect;
    public GameObject coin1;
    public GameObject coin3;
    public GameObject coin5;
    public GameObject coin25;
    public GameObject busket5;
    public GameObject busket1;
    public Score score;
    public SwipeScript ss;
    public BallCount ballCount;
    private Vector3 position;
    public bool isInTheBusket;
    public int comboCount;
    public bool comboShootStart;
    public bool coinsCollect;

  
    void Start()
    {
        comboCount = 0;
        coinsCollect = true;
    }
    private void OnTriggerEnter(Collider target)
    {
        if(coinsCollect == true)
        {
            coinsCollect = false;
            if (target.gameObject.tag == "Player")
            {
                isInTheBusket = true;
                if (collDetect.count == 0)
                {
                    comboCount++;
                    if (comboCount == 3)
                    {
                        //coins25;
                        FindObjectOfType<SoundManager>().Play("coin");
                        Instantiate(coin25, transform.position, Quaternion.identity);
                        score.coins += 25;
                        //ball 5;
                        FindObjectOfType<SoundManager>().Play("Bonus");
                        Instantiate(busket5, transform.position, Quaternion.identity);
                        ballCount.ballCount += 5;
                        comboCount = 0;
                    }
                    else
                    {
                        FindObjectOfType<SoundManager>().Play("wow");
                        FindObjectOfType<SoundManager>().Play("Bonus");
                        FindObjectOfType<SoundManager>().Play("coin");
                        Instantiate(coin5, coin5.transform.position, Quaternion.identity);
                        Instantiate(busket1, transform.position, Quaternion.identity);//bouns 1 ball to play
                        ballCount.ballCountIncrease = true;
                        score.coins += 5;
                    }
                }
                if (collDetect.count == 1)
                {
                    if (comboCount == 2)
                    {
                        FindObjectOfType<SoundManager>().Play("coin");
                        Instantiate(coin25, transform.position, Quaternion.identity);
                        score.coins += 25;
                        comboCount = 0;
                    }
                    else
                    {
                        FindObjectOfType<SoundManager>().Play("coin");
                        Instantiate(coin3, transform.position, Quaternion.identity);
                        score.coins += 3;
                        comboCount = 0;
                    }
                }
                if (collDetect.count == 2 || collDetect.count == 3 || collDetect.count == 4 || collDetect.count == 5)
                {
                    if (comboCount == 2)
                    {
                        FindObjectOfType<SoundManager>().Play("coin");
                        Instantiate(coin25, transform.position, Quaternion.identity);
                        score.coins += 25;
                        comboCount = 0;
                    }
                    else
                    {
                        FindObjectOfType<SoundManager>().Play("coin");
                        Instantiate(coin1, transform.position, Quaternion.identity);
                        score.coins += 1;
                        comboCount = 0;
                    }
                }
            }
            ballCount.ballCountDecrease = false;
        }
    }//Onenter   
}
