//Houses the timer and controls the hotkeys for development.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShifter : MonoBehaviour
{
    //private float maxTime = 30;
    public float currentTime;
    public int timeState = 0;

    public bool isHotbar;
    public bool isAttack;

    private Messages msg;
    

    void Start()
    {
        msg = FindObjectOfType<Messages>();
        ResetTimer();

        //Set up player controls at start of game!!
        isHotbar = true;
        isAttack = false;
    }

    void Update()
    {
        Timer();

        //Go to past
        if (Input.GetKeyDown("o"))
        {
            ToPast();
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
            msg.text_update = "They are coming.";
            msg.TextLog();

            timeState++;

            isHotbar = false;
            isAttack = true;
        }
    }

    public void ToPast()
    {
        if (timeState == 1)
        {
            msg.text_update = "Set your defences.";
            msg.TextLog();

            timeState--;

            isAttack = false;
            isHotbar = true;
        }
        ResetTimer();
    }

    public void ResetTimer()
    {
        currentTime = 30;
    }
}
