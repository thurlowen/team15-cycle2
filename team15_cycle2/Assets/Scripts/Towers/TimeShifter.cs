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
    private Waves waves;
    public int waveCount = 0;
    private EnemySpawner enSpawn;
    private int lastWave = 3;
    private int enAmount;
    

    void Start()
    {
        enSpawn = FindObjectOfType<EnemySpawner>();
        waves = FindObjectOfType<Waves>();
        msg = FindObjectOfType<Messages>();
        ResetTimer();
        currentTime = 90;

        //Set up player controls at start of game!!
        isHotbar = true;
        isAttack = false;
    }

    void Update()
    {
        waves.waveText.text = "Wave: "+waveCount;
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && timeState == 1) 
        {
            
            enAmount = Random.Range(lastWave, waveCount*3);
            for(int i=0; i<enAmount; i++)
            {
                enSpawn.SpwnEn();

            }
            lastWave = enAmount;
            ToPast();
        }
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
        if (currentTime > 0)
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
        waveCount++;
        if (timeState == 0)
        {
            msg.text_update = "";
            msg.TextLog();
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
            msg.text_update = "";
            msg.TextLog();
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
