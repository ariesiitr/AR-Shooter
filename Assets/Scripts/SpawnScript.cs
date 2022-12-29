using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject Drones;
    public Transform[] spawnpoint;

    [System.Obsolete]
    void Start()
    {
        StartCoroutine(StartSpawning()); 
    }

    [System.Obsolete]
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2);

        int i = Random.RandomRange(0, 8);
            Instantiate(Drones, spawnpoint[i].position, Quaternion.identity);
            StartCoroutine(StartSpawning());
        
    }
}
