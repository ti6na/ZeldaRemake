using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string introSongName;
    
    // Start is called before the first frame update
    void Start()
    {
        MainMenuScreen();

        // Apply audio manager
        audioManager = AudioManager.instance;

        //audioManager.PlaySound(introSongName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("escape"))
        {
            QuitGame();
        }

        /*if (Input.GetButtonDown("space"))
        {
            StartGame();
        }*/
    }

    // Reference AudioManager script
    private AudioManager audioManager;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public GameObject aboutScreen;
    public GameObject mainMenu;
    public GameObject creditScreen;
    
    public void ShowAboutScreen()
    {
        aboutScreen.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
        creditScreen.gameObject.SetActive(false);
    }

    public void MainMenuScreen()
    {
        aboutScreen.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        creditScreen.gameObject.SetActive(false);
    }

    public void ShowCreditScreen()
    {
        aboutScreen.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        creditScreen.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Application closed");
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        Debug.Log("Return");
        SceneManager.LoadScene(0);
    }
}
