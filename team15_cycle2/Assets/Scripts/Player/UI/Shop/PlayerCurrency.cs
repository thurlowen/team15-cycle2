using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCurrency : MonoBehaviour
{
    public int playerCurrency;
    private Text playerCurrencyTxt;

    // Start is called before the first frame update
    void Start()
    {
        
        playerCurrencyTxt = GameObject.Find("PlayerCurr").GetComponent<Text>();
        playerCurrency = 350;

    }

    // Update is called once per frame
    void Update()
    {
        playerCurrencyTxt.text = playerCurrency.ToString();
    }
}
