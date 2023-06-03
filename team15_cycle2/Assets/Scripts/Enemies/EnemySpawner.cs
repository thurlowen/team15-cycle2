using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private TimeShifter TimeShifter;

    // Start is called before the first frame update
    void Start()
    {
        //enemy = GameObject.FindGameObjectWithTag("Enemy");
        TimeShifter = FindObjectOfType<TimeShifter>();

        for(int i=0; i<2; i++)
        {
            SpwnEn();
            //Instantiate(enemy, new Vector3(13,2,Random.Range(-15, 15)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            Debug.Log("spawn");
            SpwnEn();
            //Instantiate(enemy, new Vector3(13,2,Random.Range(-15, 15)), Quaternion.identity);
            TimeShifter.ToPast();
            
        }
        if(Input.GetKeyDown("2"))
        {
            SpwnEn();
            SpwnEn();
            SpwnEn();
            TimeShifter.ToPast();
        }
        if(Input.GetKeyDown("3"))
        {
            SpwnEn();
            SpwnEn();
            SpwnEn();
            SpwnEn();
            SpwnEn();
            TimeShifter.ToPast();
        }
    }

    public void SpwnEn()
    {
        Instantiate(enemy, new Vector3(80,2,Random.Range(-10, 30)), Quaternion.identity);
    }
    
}
