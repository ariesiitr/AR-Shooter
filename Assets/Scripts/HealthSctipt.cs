using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSctipt : MonoBehaviour
{
    public Text Health;
    public static int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        Health.text = health.ToString() + "Health";

    }

    // Update is called once per frame
    void Update()
    {
        Health.text = "Health :" + health;

    }
}
