using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text countDownText;
    private TimeShifter TimeShifter;

    void Start()
    {
        countDownText = GetComponentInChildren<Text>();
        TimeShifter = FindObjectOfType<TimeShifter>();
    }

    void Update()
    {
        countDownText.text = TimeShifter.currentTime.ToString();
    }
}
