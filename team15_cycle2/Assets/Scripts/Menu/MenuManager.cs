using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    //shop
    //hotbar
    //attack indicator
    //sprintbar
    //persistant - timer, top meesages
    //direction

    public bool pauseMenuActive = false;

    void Update()
    {
        ActivatePauseMenu();
        
    }

    private void ActivatePauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.B)) //MUST CHANGE TO esc
        {
            pauseMenuActive = !pauseMenuActive;
            Debug.Log("Paused: " + (pauseMenuActive ? "T" : "F"));
        }
    }

}
