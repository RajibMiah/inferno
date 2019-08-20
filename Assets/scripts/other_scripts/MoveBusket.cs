using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBusket : MonoBehaviour
{
    public Score score;
    [SerializeField]
    private float maxvalue, minvalue;
    [SerializeField]
    private bool isRight, isLeft;
    // Start is called before the first frame update
    void Start()
    {
        isRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (score.coins >= 50)
        {

            if (isRight)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 0.1f, Space.World);
            }
            else if (isLeft)
            {
                transform.Translate(Vector3.left * Time.deltaTime * 0.1f, Space.World);
            }


            //move busket
            if (transform.position.x >= maxvalue)
            {
                isLeft = true;
                isRight = false;
            }
            if (transform.position.x <= minvalue)
            {
                isRight = true;
                isLeft = false;
            }
        }
    }//update

   



}
