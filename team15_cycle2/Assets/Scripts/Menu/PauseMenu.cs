using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private MenuManager MenuManager;
    private Canvas PM;

    void Start()
    {
        MenuManager = FindObjectOfType<MenuManager>();
        PM = gameObject.GetComponent<Canvas>();
        PM.enabled = false;
    }

    void Update()
    {
        PM.enabled = MenuManager.pauseMenuActive;
    }

    public void Resume()
    {
        PM.enabled = false;
        MenuManager.pauseMenuActive = false;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
