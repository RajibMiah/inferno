using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PusedButton : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject P_Manu;
    public GameObject restartPanel;
    public void pusedManu()
    {
        Time.timeScale = 0;
        P_Manu.SetActive(true);
    }

    public void Play()
    {
        P_Manu.SetActive(false);
        Time.timeScale = 1;


    }
    public void re_Start()
    {
        P_Manu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Main_Manu()
    {
        P_Manu.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void restart()
    {
        
        restartPanel.SetActive(false);
        SceneManager.LoadScene(1);

    }
}
