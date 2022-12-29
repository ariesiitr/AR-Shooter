using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSctipt : MonoBehaviour
{
    Slider _healthSlider;
    internal static int Maxhealth =100;

    private void Start()
    {
        _healthSlider = GetComponent<Slider>();
       
    }
    // Start is called before the first frame update
    public void SetMaxHealth(int Maxhealth)
    {
        _healthSlider.maxValue = Maxhealth;
        _healthSlider.value = Maxhealth;
    }
    public void SetHealth(int health)
    {
        _healthSlider.value = health;
    }
    public float GetHealth()
    {
        return _healthSlider.value;
    }
    
    
}
