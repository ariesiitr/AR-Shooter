using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int points = 0;
    
    public Text Score;
   

    // Start is called before the first frame update
    void Start()
    {
        Score.text = points.ToString() + " Points";
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score : " + points;
       
        
    }
}
