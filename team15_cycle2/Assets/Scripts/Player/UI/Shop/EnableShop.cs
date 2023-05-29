using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableShop : MonoBehaviour
{
    private GameObject store;
    private GameObject hud;
    private Text currencyText;
    private PlayerCurrency currency;
    private FirstPersonController fpsCon;
    private Messages msg;

    public GameObject direction;
    private TimeShifter timeShifter;

    private GameObject pauseMenu;
    public bool showShop = false;
    private TreeHealth TreeHealth;
    public GameObject endscreen;

    // Start is called before the first frame update
    void Start()
    {
        timeShifter = FindObjectOfType<TimeShifter>();
        msg = FindObjectOfType<Messages>();
        showShop = false;
        store = GameObject.Find("Store");
        hud = GameObject.Find("HUD");
        currencyText = GameObject.Find("ug_text").GetComponent<Text>();
        currency = GameObject.Find("Player").GetComponent<PlayerCurrency>();
        fpsCon = GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>();
        TreeHealth = FindObjectOfType<TreeHealth>();

        pauseMenu = GameObject.Find("Menu");
        showShop = false; //GetComponent<MenuManager>().pauseMenuActive;
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

        if(TreeHealth.TreeHealthNo <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            endscreen.SetActive(true);
        }
    }
    
    public void ShopVis()
    {
        showShop = !showShop;

        if(showShop == false)
        {
            msg.text_update = "";
            msg.TextLog();
            msg.text_update = "Set your defences.";
            msg.TextLog();
        }
        direction.SetActive(false);
        if(direction.activeSelf == false)
        {
            timeShifter.currentTime = 30;
        }
    }

    
}
