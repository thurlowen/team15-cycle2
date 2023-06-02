using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public bool pauseMenuActive = true;

    void Update()
    {
        TogglePauseMenu();
    }

    private void TogglePauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) //MUST CHANGE TO esc
        {
            pauseMenuActive = !pauseMenuActive;
            //Debug.Log("Paused: " + (pauseMenuActive ? "T" : "F"));
        }
    }
}
