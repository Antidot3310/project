using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Recordscore : MonoBehaviour
{
    public Text RecordscoreTextMenu;
    public int  RecordscoreMenu;
    public int  scoreMenu;
    public int resetrecord;
    void Start()
    {
      RecordscoreMenu = PlayerPrefs.GetInt("RecordscoreMenu");
      scoreMenu = PlayerPrefs.GetInt("score");
      if(scoreMenu>RecordscoreMenu)
      {
        RecordscoreMenu = scoreMenu;
      }
      PlayerPrefs.SetInt("RecordscoreMenu", RecordscoreMenu);
      RecordscoreTextMenu.text = RecordscoreMenu.ToString();
    }

    public void resetrecord_metod()
    {
        resetrecord = 0;
        RecordscoreMenu = 0;
        scoreMenu = 0;
        PlayerPrefs.SetInt("RecordscoreMenu", resetrecord);
        PlayerPrefs.SetInt("score", scoreMenu);
        RecordscoreTextMenu.text = RecordscoreMenu.ToString();
    }
}
