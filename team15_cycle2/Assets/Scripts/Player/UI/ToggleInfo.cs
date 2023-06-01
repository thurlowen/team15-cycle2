using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInfo : MonoBehaviour
{
    private Canvas Info;
    private MenuManager MenuManager;
    
    void Start()
    {
        Info = gameObject.GetComponent<Canvas>();
        Info.enabled = true;
        
        MenuManager = GameObject.Find("Menu").GetComponent<MenuManager>();
    }

    void Update()
    {
        Info.enabled = !MenuManager.pauseMenuActive;
    }
}
