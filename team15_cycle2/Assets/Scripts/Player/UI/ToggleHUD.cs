using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHUD : MonoBehaviour
{
    private Canvas HUD;

    private MenuManager MenuManager;
    private static bool toggle;

    void Start()
    {
        HUD = gameObject.AddComponent<Canvas>();
        HUD.enabled = true;

        //MenuManager = GameObject.Find("Menu").GetComponent<MenuManager>();
    }

    void Update()
    {
        toggle = MenuManager.pauseMenuActive;
        
        HUD.enabled = toggle;
    }
}
