using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Displays proper menus on awake
        ResumeGame();
    }

    // Update is called once per frame
    void Update()
    {

        // Checks for pause menu
        if (Input.GetButtonDown("space"))
        {
            if (gameIsPaused)
            {
                Debug.Log("game is resumed");
                Resume();
            }
            else
            {
                Debug.Log("game is paused");
                Pause();
            }
        }
    }

    /////////////////////////////////
    //        Menu Navigator       //
    /////////////////////////////////

    // Pause Game
    public static bool gameIsPaused = false;

    public void Resume()
    {
        ResumeGame();
        gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        PauseMenu();
        gameIsPaused = true;
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Debug.Log("Return");
        SceneManager.LoadScene(0);
    }

    // Menu Screens
    public GameObject gameOverlay;
    public GameObject pauseScreen;
    public GameObject winScreen;
    public GameObject loseScreen;

    public void ResumeGame()
    {
        gameOverlay.gameObject.SetActive(true);
        pauseScreen.gameObject.SetActive(false);
        winScreen.gameObject.SetActive(false);
        loseScreen.gameObject.SetActive(false);
    }

    public void PauseMenu()
    {
        gameOverlay.gameObject.SetActive(false);
        pauseScreen.gameObject.SetActive(true);
        winScreen.gameObject.SetActive(false);
        loseScreen.gameObject.SetActive(false);
    }

    public void WinGame()
    {
        gameOverlay.gameObject.SetActive(false);
        pauseScreen.gameObject.SetActive(false);
        winScreen.gameObject.SetActive(true);
        loseScreen.gameObject.SetActive(false);
    }

    public void LoseGame()
    {
        Debug.Log("Reached pause manager");
        gameOverlay.gameObject.SetActive(false);
        pauseScreen.gameObject.SetActive(false);
        winScreen.gameObject.SetActive(false);
        loseScreen.gameObject.SetActive(true);
    }
}
