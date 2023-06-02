using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Canvas MM;

    void Start()
    {
        MM = gameObject.GetComponent<Canvas>();
        MM.enabled = true;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void HelpMenu()
    {
        Debug.Log("help");
    }
}
