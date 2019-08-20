using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReLoad : MonoBehaviour
{
    public GameObject restartPanel;

    public void reStart()
    {
        Time.timeScale = 0;
        restartPanel.SetActive(true);
    }
}
