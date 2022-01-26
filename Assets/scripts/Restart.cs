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
        SceneManager.LoadScene("Level");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
