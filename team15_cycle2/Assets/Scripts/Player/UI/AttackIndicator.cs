using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackIndicator : MonoBehaviour
{
    private TimeShifter ts;
    private Canvas indicatorElement;

    void Start()
    {
        ts = GameObject.Find("TowerDamage").GetComponent<TimeShifter>();
        
        indicatorElement = gameObject.AddComponent<Canvas>();
        indicatorElement.enabled = false;
    }

    void Update()
    {
        if (ts.isAttack == true)
        {
            indicatorElement.enabled = true;
        }

        if (ts.isAttack == false)
        {
            indicatorElement.enabled = false;
        }
    }
}
