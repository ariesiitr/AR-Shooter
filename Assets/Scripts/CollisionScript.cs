using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    int health = 300;
   void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        HealthSctipt.health -= 10;
        Debug.Log(health);
        Handheld.Vibrate();
    }
    
    
  
    // Update is called once per frame
    void Update()
    {
       

    }
}
