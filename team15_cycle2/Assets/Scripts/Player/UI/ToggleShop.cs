using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleShop : MonoBehaviour
{
    private Canvas Shop;
    private MenuManager MenuManager;

    void Start()
    {
        Shop = gameObject.GetComponent<Canvas>();
        Shop.enabled = true;

        MenuManager = GameObject.Find("Menu").GetComponent<MenuManager>();
    }

    void Update()
    {
        Shop.enabled = !MenuManager.pauseMenuActive;
    }
}
