//gets the time from time shifter and uses it to change the state of the towers thats all.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShift : MonoBehaviour
{
    private GameObject seed;
    private GameObject tree;
    private int timeState = 0;

    private TimeShifter ts;

    

    void Start()
    {
        seed = this.gameObject.transform.GetChild(0).gameObject;
        tree = this.gameObject.transform.GetChild(1).gameObject;
        ts = GameObject.Find("TowerDamage").GetComponent<TimeShifter>();

        
    }

    void Update()
    {
        timeState = ts.timeState;
        Debug.Log(ts.timeState);

        if (timeState == 0)
        {
            tree.gameObject.SetActive(false);
            seed.gameObject.SetActive(true);
        }

        if (timeState == 1)
        {
            seed.gameObject.SetActive(false);
            tree.gameObject.SetActive(true);
        }
    }   
}