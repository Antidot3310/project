using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int score;
    public Text scoreDisplay;
    public int recordscore;

    private void Update()
    {

        scoreDisplay.text = score.ToString();
        if(recordscore<score)
        {
            recordscore = score;
        }
        PlayerPrefs.SetInt("score", recordscore);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("shesternia"))
        {
            score++;
        }
    }

}
