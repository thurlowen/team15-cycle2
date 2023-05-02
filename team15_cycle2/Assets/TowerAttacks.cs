using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttacks : MonoBehaviour
{
    public float treeDamage;
    public float venusDamage;
    public float bushDamage;
    private PlayerCurrency curr;
    private FirstPersonController fps_con;
    // Start is called before the first frame update
    void Start()
    {
        treeDamage = 0.65f;
        venusDamage = 0.15f;
        bushDamage = 0.3f;
        curr = GameObject.Find("Player").GetComponent<PlayerCurrency>();
        fps_con = GameObject.Find("FirstPersonController").GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TreeUp()
    {
        if(curr.p_curr >= 100)
        {
            treeDamage = treeDamage*1.2f;
            curr.p_curr -= 100;
        }
    }
    public void VenusUp()
    {
        if(curr.p_curr >= 100)
        {
            venusDamage = venusDamage*1.2f;
            curr.p_curr -= 100;
        }
    }
    public void BushUp()
    {
        if(curr.p_curr >= 100)
        {
            bushDamage = bushDamage*1.2f;
            curr.p_curr -= 100;
        }
    }

    public void SpeedUp()
    {
        if(curr.p_curr >= 25)
        {
            fps_con.walkSpeed = fps_con.walkSpeed*1.1f;
            fps_con.sprintSpeed = fps_con.sprintSpeed*1.1f;
            curr.p_curr -= 25;

        }
    }
}
