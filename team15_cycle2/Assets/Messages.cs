using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages : MonoBehaviour
{
    public Text countDownText;
    private TimeShifter TimeShifter;
    public string text_update;

    void Start()
    {
        countDownText = GetComponentInChildren<Text>();
        countDownText.text = "";
        text_update = "Go to Gaia.";
        TextLog();
    }

    void Update()
    {
    
    }
    public void TextLog()
    {
        countDownText.text = "";
        StartCoroutine(ExampleCoroutine());

    }
    public IEnumerator ExampleCoroutine()
    {
        for (int i = 0; i < text_update.Length; i++) 
        {
            yield return new WaitForSeconds(0.1f);
            countDownText.text += text_update[i];
        }
    }
    

}
