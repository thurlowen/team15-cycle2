using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FovChange : MonoBehaviour
{
    float t = 90f;
    bool fovEffect = false;
    int count = 0;

    private TimeShifter TimeShifter;
    private bool fovEffectMet = false;

    void Start()
    {
        TimeShifter = FindObjectOfType<TimeShifter>();
    }

    void Update()
    {

        Camera.main.fieldOfView = t;
        if(fovEffect == true && count == 0)
        {
            if(t <= 190f)
            {
                t += Time.deltaTime * 1000;
            }
            else
            {
                count = 1;
            }
        }
        if(fovEffect == true && count == 1)
        {
            if(t >= 90f)
            {
                t -= Time.deltaTime * 1000;
            }
            else
            {
                fovEffect = false;
                count = 0;
            }
        }

        if(TimeShifter.currentTime <= 0 && !fovEffectMet)
        {
            fovEffect = true;
            fovEffectMet = true;
        }
    }
}
