using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxvalue;
    public float minvalue;
    private bool isRight;
    private bool isLeft;
    public float move_speed;

    void Start()
    {
        isRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime * move_speed, Space.World);
        }
        else if (isLeft)
        {
            transform.Translate(Vector3.left * Time.deltaTime * move_speed, Space.World);
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
}
