using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float points;
    public float gOVscore =0;
    public float highscore=0;
    public Text HighScoreText;
    public Text Score;
    public float prevscore;
    public Text prevscoreText;
     // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("HighScore");
        points = 0;
        prevscore = PlayerPrefs.GetFloat("Score");
    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.Log(points);
        if (points > highscore)
        {
            PlayerPrefs.SetFloat("HighScore", points);
            highscore = points;
        }
        HighScoreText.text = highscore.ToString();
        Score.text = points.ToString();
        prevscoreText.text = prevscore.ToString();
    }
    public void AddScore()
    {
        points++;
    }
    public float getScore()
    {
        return points;
    }
   
}
