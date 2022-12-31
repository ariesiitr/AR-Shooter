using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmusic : MonoBehaviour
{
    public AudioSource sound;
    [SerializeField] AmmoScript _ammobar;
    public void Bgmusic()
    {
        
        if (_ammobar.GetAmmo()>0)
        {
            sound.Play();
        }
    }
}
