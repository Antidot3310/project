using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public static bool GameisPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                PauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;           
        }
    }

    public void Menu()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
        SceneManager.LoadScene("Menu");
    }
    public void Resume()
    {

        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

}
