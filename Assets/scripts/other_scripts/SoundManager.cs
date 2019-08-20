using UnityEngine.Audio;
using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public Sounds[] sounds;
    // Start is called before the first frame update
    
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

      DontDestroyOnLoad(gameObject);
        
        foreach(Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.playOnAwake = s.OnAwake;    
        }
    }
    public void Start()
    {
        Play("background");
    }
   
    public void Play( string name)
    {
        Sounds s = Array.Find(sounds,Sounds=>Sounds.name == name);
        if(s == null)
        {
            return;
        }
        if(!s.source.isPlaying)
        {
            s.source.Play();            
        }
     
    }
    public void Paused(string name)
    {
        Sounds s = Array.Find(sounds, Sounds => Sounds.name == name);
        if (s == null)
        {
            return;
        }
        if (!s.source.isPlaying)
        {
            s.source.Pause();
        }
    }
}
