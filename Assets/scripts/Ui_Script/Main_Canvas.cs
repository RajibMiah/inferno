using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Canvas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject restart_Panel;

    private void Awake()
    {
      //  FindObjectOfType<Sounds>().Mute(true);
    }

    public void re_Start()
    {
       
        restart_Panel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Button_Touch");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
    public void quit()
    {
        FindObjectOfType<SoundManager>().Play("Button_Touch");
        SceneManager.LoadScene(0);

    }
    
    private void OnDestroy()
    {
        Time.timeScale = 1;
    }

}
