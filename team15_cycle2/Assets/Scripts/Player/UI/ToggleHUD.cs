using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHUD : MonoBehaviour
{
    private Canvas HUD;
    private MenuManager MenuManager;

    void Start()
    {
        HUD = gameObject.GetComponent<Canvas>();
        HUD.enabled = true;

        MenuManager = FindObjectOfType<MenuManager>();
    }

    void Update()
    {
        HUD.enabled = !MenuManager.pauseMenuActive;
    }
}
