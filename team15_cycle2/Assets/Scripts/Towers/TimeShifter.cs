using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShifter : MonoBehaviour
{
    private float maxTime = 30;
    public float currentTime;
    public int timeState = 0;

    void Start()
    {
        ResetTimer();
    }

    void Update()
    {
        Timer();

        //Go to past
        if (Input.GetKeyDown("o"))
        {
            ToPast();
            ResetTimer();
        }

        //Skip to future
        if (Input.GetKeyDown("p"))
        {
            ToFuture();
        }
    }

    public void Timer()
    {
        if (currentTime > 0 && timeState == 0)
        {
            currentTime -= 1 * Time.deltaTime;
            //Debug.Log(currentTime);
        }

        if (currentTime <= 0 && timeState == 0)
        {
            ToFuture();
        }
    }

    public void ToFuture()
    {
        if (timeState == 0)
        {
            timeState++;
        }
    }

    public void ToPast()
    {
        if (timeState == 1)
        {
            timeState--;
        }
    }

    public void ResetTimer()
    {
        currentTime = maxTime;
    }
    
}
