using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerAttacks : MonoBehaviour
{
    public float treeDamage;
    public float venusDamage;
    public float bushDamage;
    private PlayerCurrency curr;
    private FirstPersonController fps_con;

    private int tree_count = 0;
    private Text tree_amount;
    private int bush_count = 0;
    private Text bush_amount;
    private int venus_count = 0;
    private Text venus_amount;
    private int speed_count = 0;
    private Text speed_amount;

    // Start is called before the first frame update
    void Start()
    {
        treeDamage = 0.65f;
        venusDamage = 0.15f;
        bushDamage = 0.3f;
        curr = GameObject.Find("Player").GetComponent<PlayerCurrency>();
        fps_con = GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>();

        tree_amount = GameObject.Find("TreeAmount").GetComponent<Text>();
        bush_amount = GameObject.Find("BushAmount").GetComponent<Text>();
        venus_amount = GameObject.Find("VenusAmount").GetComponent<Text>();
        speed_amount = GameObject.Find("SpeedAmount").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tree_amount.text = "AMOUNT: "+tree_count;
        bush_amount.text = "AMOUNT: "+bush_count;
        venus_amount.text = "AMOUNT: "+venus_count;
        speed_amount.text = "AMOUNT: "+speed_count;
    }
    
    public void TreeUp()
    {
        if(curr.playerCurrency >= 100)
        {
            treeDamage = treeDamage*1.2f;
            curr.playerCurrency -= 100;
            tree_count++;
        }
    }
    public void VenusUp()
    {
        if(curr.playerCurrency >= 100)
        {
            venusDamage = venusDamage*1.2f;
            curr.playerCurrency -= 100;
            venus_count++;
        }
    }
    public void BushUp()
    {
        if(curr.playerCurrency >= 100)
        {
            bushDamage = bushDamage*1.2f;
            curr.playerCurrency -= 100;
            bush_count++;
        }
    }

    public void SpeedUp()
    {
        if(curr.playerCurrency >= 25)
        {
            fps_con.walkSpeed = fps_con.walkSpeed*1.1f;
            fps_con.sprintSpeed = fps_con.sprintSpeed*1.1f;
            curr.playerCurrency -= 25;
            speed_count++;

        }
    }
}
