using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(LineRenderer))]

public class RayCastGun : MonoBehaviour
{
    public Camera playerCamera;
    public Transform laserOrigin;
    public float gunRange = 50f;
    public float fireRate = 0.2f;
    public float laserDuration = 0.05f;
    public GameObject arCamera;
    public GameObject smoke;
    public AudioSource sound;
    LineRenderer laserLine;
    bool playing = false;
    [SerializeField] HealthSctipt _healthbar;
    [SerializeField] ScoreScript _scorescript;


    void Awake()
    {
        laserLine = GetComponent<LineRenderer>();
        sound = GetComponent<AudioSource>();
        playing = true;
    }

    [System.Obsolete]
    public void Shoot()
    {
        RaycastHit hit;
       
        laserLine.SetPosition(0, laserOrigin.position);
      

        Vector3 rayOrigin = playerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
       
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            Debug.Log("raycast"); 
           _scorescript.AddScore();
            Destroy(hit.transform.gameObject);
            AudioSource.PlayClipAtPoint(sound.clip,rayOrigin);
            Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
        }
        if (Physics.Raycast(rayOrigin, playerCamera.transform.forward, out hit, gunRange))
        {
            laserLine.SetPosition(1, hit.point);

        }
        else
        {
            laserLine.SetPosition(1, rayOrigin + (playerCamera.transform.forward * gunRange));
        }
        StartCoroutine(ShootLaser());
    }





    void Update()
    {
        float val = _healthbar.GetHealth();
        if (val<= 0)
        {
            Debug.Log("ded");
            playing = false;
            Vector3 finalpos = arCamera.transform.position;
            AudioSource.PlayClipAtPoint(sound.clip,finalpos);
            PlayerPrefs.SetFloat("Score", _scorescript.getScore());
            SceneManager.LoadScene("GAME_OVER");

        }
    }
      public bool isPlaying()
    {
        return playing;
    }

    IEnumerator ShootLaser()
        {
            laserLine.enabled = true;
            yield return new WaitForSeconds(laserDuration);
            laserLine.enabled = false;
        }
    }


