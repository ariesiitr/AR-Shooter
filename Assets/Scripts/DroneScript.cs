using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneScript : MonoBehaviour
{
    Vector3 Current;
    
    private Transform target;
    private void Awake()
    {
        target = Camera.main.transform;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 0.08f);
    }
  
}
