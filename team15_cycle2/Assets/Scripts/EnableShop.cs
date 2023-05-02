using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableShop : MonoBehaviour
{
    private bool isShop;
    private GameObject store;
    private GameObject hud;
    private Text curr_text;
    private PlayerCurrency curr;

    // Start is called before the first frame update
    void Start()
    {
        isShop = false;
        store = GameObject.Find("Store");
        hud = GameObject.Find("HUD");
        curr_text = GameObject.Find("ug_text").GetComponent<Text>();
        curr = GameObject.Find("Player").GetComponent<PlayerCurrency>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("m"))
        {
            isShop = !isShop;
        }
        if(isShop == false)
        {
            hud.SetActive(true);
            store.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        if(isShop == true)
        {
            hud.SetActive(false);
            store.SetActive(true);
            Cursor.lockState = CursorLockMode.None;

            curr_text.text = "UPGRADES: "+curr.p_curr;

        }
    }
    
    public void ShopVis()
    {
        isShop = !isShop;
    }
}
