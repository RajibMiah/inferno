using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManu : MonoBehaviour
{
    public void Play_Game()
    {
        FindObjectOfType<SoundManager>().Play("Button_Touch");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public  void infinity()
    {
        FindObjectOfType<SoundManager>().Play("Button_Touch");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void challange1()
    {
        FindObjectOfType<SoundManager>().Play("Button_Touch");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void OpenURL()
    {
        Application.OpenURL("https://inferno-console-it.web.app/");
    }

}
