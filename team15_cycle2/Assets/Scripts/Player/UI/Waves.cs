using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waves : MonoBehaviour
{
    public Text waveText;
    
    // Start is called before the first frame update
    void Start()
    {
        waveText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //waveText.text = "Wave: 1";
    }
}
