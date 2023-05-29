using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPhase : MonoBehaviour
{
    private TimeShifter TimeShifter;
    public Text EndText;

    // Start is called before the first frame update
    void Start()
    {
        TimeShifter = FindObjectOfType<TimeShifter>();
    }

    // Update is called once per frame
    void Update()
    {
        EndText.text = "Thanks to you...\nGaia will protect "+TimeShifter.waveCount+" generations.";
    }
}
