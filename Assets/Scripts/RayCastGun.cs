using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
  
  

    void Awake()
    {
        laserLine = GetComponent<LineRenderer>();
        sound = GetComponent<AudioSource>();
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
            
            ScoreScript.points += 1;
            Destroy(hit.transform.gameObject);
            AudioSource.PlayClipAtPoint(sound.clip, hit.point);
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
        


        

      /*  void Update()
        {
            
            if (Input.GetButtonDown("Fire1") && fireTimer > fireRate)
            {
               
                
            }
        }*/

        IEnumerator ShootLaser()
        {
            laserLine.enabled = true;
            yield return new WaitForSeconds(laserDuration);
            laserLine.enabled = false;
        }
    }


