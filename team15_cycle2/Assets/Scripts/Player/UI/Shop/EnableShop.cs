using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableShop : MonoBehaviour
{
    private bool showShop;

    private GameObject store;
    private GameObject hud;
    private Text currencyText;
    private PlayerCurrency currency;
    private FirstPersonController fpsCon;

    // Start is called before the first frame update
    void Start()
    {
        showShop = false;
        store = GameObject.Find("Store");
        hud = GameObject.Find("HUD");
        currencyText = GameObject.Find("ug_text").GetComponent<Text>();
        currency = GameObject.Find("Player").GetComponent<PlayerCurrency>();
        fpsCon = GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>();

    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown("m"))
        // {
        //     isShop = !isShop;
        // }
        
        if(showShop == false)
        {
            hud.SetActive(true);
            store.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            fpsCon.cameraCanMove = true;
            fpsCon.playerCanMove = true;
            fpsCon.enableHeadBob = true;
        }
        if(showShop == true)
        {
            hud.SetActive(false);
            store.SetActive(true);
            Cursor.lockState = CursorLockMode.None;

            currencyText.text = "UPGRADES: "+currency.playerCurrency;
            fpsCon.cameraCanMove = false;
            fpsCon.playerCanMove = false;
            fpsCon.enableHeadBob = false;

        }
    }
    
    public void ShopVis()
    {
        showShop = !showShop;
    }

    
}
