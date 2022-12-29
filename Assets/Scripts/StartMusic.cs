using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMusic : MonoBehaviour
{

    // Update is called once per frame
    public AudioSource bgmusic;
    [SerializeField] RayCastGun game;
  
    bool MusicON = false;
  
    void Awake()
    {
        bgmusic = GetComponent<AudioSource>();
       
        while (game.isPlaying()&&MusicON)
            bgmusic.Play();
    }
    

}
