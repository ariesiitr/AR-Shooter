using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoScript : MonoBehaviour
{
    Slider _ammoSlider;
    internal static int MaxAmmo = 10;

    private void Awake()
    {
        _ammoSlider = GetComponent<Slider>();

    }
    // Start is called before the first frame update
    public void SetMaxAmmo(int MaxAmmo)
    {
        _ammoSlider.maxValue = MaxAmmo;
        _ammoSlider.value = MaxAmmo;
    }
    public void SetAmmo(float ammo)
    {
        _ammoSlider.value = ammo;
       
    }
    public float GetAmmo()
    {
        return _ammoSlider.value;
    }
   
}
