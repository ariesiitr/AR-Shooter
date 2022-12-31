using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AmmoScript _ammobar;
   
    int count=0;
   
    public void Onclick()
    {
        count++;
        _ammobar.SetAmmo(AmmoScript.MaxAmmo);
      
        Debug.Log("ammo set to max" +count);
        Debug.Log("ammobar value" + _ammobar.GetAmmo());
    }
}
