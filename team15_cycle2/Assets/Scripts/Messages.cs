using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages : MonoBehaviour
{
    public Text countDownText;
    private TimeShifter TimeShifter;
    public string text_update;

    private bool isRunning = false;

    void Start()
    {
        countDownText = GetComponentInChildren<Text>();
        countDownText.text = "";

        text_update = "";
        TextLog();
        text_update = "Go to Gaia.";
        TextLog();
    }

    void Update()
    {
    
    }
    public void TextLog()
    {
        
        if(isRunning==false)
        {
            countDownText.text = "";
            StartCoroutine(ExampleCoroutine());
        }

    }
    public IEnumerator ExampleCoroutine()
    {
        isRunning = true;
        for (int i = 0; i < text_update.Length; i++) 
        {
            yield return new WaitForSeconds(0.05f);
            countDownText.text += text_update[i];
        }
        isRunning = false;
    }
    

}
