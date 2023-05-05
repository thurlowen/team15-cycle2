using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShift : MonoBehaviour
{
    private GameObject seed;
    private GameObject tree;
    private int timeState = 0;

    private float maxTime = 10;
    public float currentTime;

    void Start()
    {
        seed = this.gameObject.transform.GetChild(0).gameObject;
        tree = this.gameObject.transform.GetChild(1).gameObject;

        ResetTimer();
    }

    void Update()
    {
        Timer();

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

    private void Timer()
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

    private void ToFuture()
    {
        if (timeState == 0)
        {
            timeState++;
        }
    }

    private void ToPast()
    {
        if (timeState == 1)
        {
            timeState--;
        }
    }

    private void ResetTimer()
    {
        currentTime = maxTime;
    }
}
