using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetect : MonoBehaviour
{
    public int count;
    private void Start()
    {
        count = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "collidor")
        {
         
            FindObjectOfType<SoundManager>().Play("Busket_Touch");
            count++;
        }
        if(collision.gameObject.tag == "ground")
        {
            FindObjectOfType<SoundManager>().Play("Bounce");
            //count = -10;
        }
        
    }//oncollision

}
