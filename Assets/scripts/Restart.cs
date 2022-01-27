using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{

    public Text score;
    public ScoreManager sm;

    private void Awake()
    {
        score.text = ("¬аш счЄт: ") + sm.score.ToString();
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
