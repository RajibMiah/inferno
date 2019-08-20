using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour {
    public GameObject combo_anim;
    public GameObject hand_anim;
    public collisionDetect cd;
    public RandomPositon rp;
    public BallCount ballCount;
    private  Vector2 startPos, endPos, direction,trailpos; // touch start position, touch end position, swipe direction
    float touchTimeStart, touchTimeFinish, timeInterval; // to calculate swipe time to sontrol throw force in Z direction
    [SerializeField]
    float throwForceInXandY ;
    [SerializeField]
    float throwForceInZ; 

    Rigidbody rb;
    public float restartDelay; 
    public bool oneTouch;
    [SerializeField]
    private Vector3 ballPosition;
    public Score score;
    public  bool touchTheScreen;
    private bool isComboReady;

    void Start()
    {
        //for delete all the playerprefs data; 
       // PlayerPrefs.DeleteAll();
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        restartDelay = 0;
        touchTheScreen = false;
        oneTouch = true;
        if (!PlayerPrefs.HasKey("handtutorial"))
        {
            PlayerPrefs.SetInt("handtutorial", 0);
            Debug.Log("Rajib");
        }
     
        if (PlayerPrefs.GetInt("handtutorial") == 0)
        {
            hand_anim.SetActive(true);
            Debug.Log("ahmed");
        }
    }//end start

    void Update()
    {
        //  transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -0.72f, 1f), transform.position.z);
        if (touchTheScreen == true)
        {
            changeBallPosition();         
        }
        if(isComboReady == true)
        {
            isComboReady = false;
            FindObjectOfType<SoundManager>().Play("Combo_sound");
            Instantiate(combo_anim, combo_anim.transform.position, Quaternion.identity);
        }

    }//update
    private void FixedUpdate()
    {
        TouchControll();
    }

    private void TouchControll()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began  && oneTouch == true )
        {
           
            hand_anim.SetActive(false);
            touchTheScreen = true;
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;       
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && oneTouch == true  )
        {
            FindObjectOfType<SoundManager>().Play("Swipe");
            touchTheScreen = true;
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch(0).position;        
            direction = startPos - endPos;
            if (timeInterval > 0.05)
            {
                rb.isKinematic = false;
                rb.AddForce(-direction.x * 0.15f, -direction.y * throwForceInXandY, throwForceInZ / timeInterval);
            }
            else
            {
                rb.isKinematic = false;
                rb.AddForce(-direction.x * 0.15f, 0.1f, 0.1f);
            }
            oneTouch = false;  
            PlayerPrefs.SetInt("handtutorial", 1);
        }
    }//touchControll

    private void changeBallPosition()
    {               
        restartDelay += Time.deltaTime;
        
            if (restartDelay > 3)
            {    
                ballCount.ballDecrease();                   
                rb.isKinematic = true;      
                touchTheScreen = false;
                ballCount.ballCountDecrease = true;
                ballCount.ballIncrease();
                oneTouch = true;
                cd.count = 0;
                if(score.coins >= 25)
                {                 
                    transform.rotation = Quaternion.Euler(30.3f, 25f, 25f);
                    ballPosition = new Vector3(Random.Range(-0.3f, 0.3f), -0.58f, -0.3f);
                    transform.position = ballPosition;
                }
                if(score.coins < 25)
                {
                    transform.rotation = Quaternion.Euler(30.3f, 25f, 25f);
                    ballPosition = new Vector3(0f, -0.58f, -0.3f);
                    transform.position = ballPosition;
                }
                if(rp.isInTheBusket == false)
                {
                  rp.comboCount = 0;
                }
                if(rp.comboCount == 2)
                {
                // combo sounds
                   isComboReady = true;                          
                }
                rp.isInTheBusket = false;
                rp.coinsCollect = true;
                restartDelay = 0;
        }     
    }//changeBallPosition
}
