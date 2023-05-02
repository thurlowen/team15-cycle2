using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCurrency : MonoBehaviour
{
    public int p_curr;
    private Text player_c;

    // Start is called before the first frame update
    void Start()
    {
        
        player_c = GameObject.Find("PlayerCurr").GetComponent<Text>();
        p_curr = 100;

    }

    // Update is called once per frame
    void Update()
    {
        player_c.text = p_curr.ToString();
    }
}
