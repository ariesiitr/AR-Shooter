using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneScript : MonoBehaviour
{
    Vector3 Current;
    float time;

    private Transform target;
    private void Awake()
    {
        target = Camera.main.transform;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        time += Time.deltaTime / 1500;
        float p = Random.RandomRange(0.06f, 0.09f)+time;
       // Debug.Log(p);
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, p);
    }
  
}
