using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public int health = HealthSctipt.Maxhealth;
    [SerializeField] HealthSctipt _healthbar;
   void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        health -= 10;
        _healthbar.SetHealth(health);
        Handheld.Vibrate();
    }
    
    
  
    // Update is called once per frame
    void Update()
    {
       

    }
}
