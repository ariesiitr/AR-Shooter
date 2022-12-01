using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;



public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            Debug.Log("raycast");
            ScoreScript.points += 1;
            Destroy(hit.transform.gameObject);
            Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
   

        }
    }
   
}
