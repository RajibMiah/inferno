using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Restart : MonoBehaviour
{
    public GameObject resButton;

    private void Start()
    {
        resButton= GetComponent<GameObject>();


    }

    public void restart()
    {
        resButton.SetActive(true);
           
    }
    
}

