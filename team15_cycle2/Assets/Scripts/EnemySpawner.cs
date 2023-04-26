using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        for(int i=0; i<2; i++)
        {
            Instantiate(enemy, new Vector3(13,2,Random.Range(-15, 15)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
