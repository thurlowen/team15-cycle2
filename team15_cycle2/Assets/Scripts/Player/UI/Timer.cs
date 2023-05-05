using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text countDownText;
    private TimeShift TimeShift;

    void Start()
    {
        countDownText = GetComponentInChildren<Text>();
        TimeShift = FindObjectOfType<TimeShift>();
    }

    void Update()
    {
        countDownText.text = TimeShift.currentTime.ToString();
    }
}
