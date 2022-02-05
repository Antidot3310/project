using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recordscore : MonoBehaviour
{
    public Text RecordscoreTextMenu;
    public int  RecordscoreMenu;
    public int  scoreMenu;
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
}
