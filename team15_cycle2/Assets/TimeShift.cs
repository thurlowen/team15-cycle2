using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShift : MonoBehaviour
{
    private GameObject seed;
    private GameObject tree;
    private int TimeState = 0;

    // Start is called before the first frame update
    void Start()
    {
        seed = this.gameObject.transform.GetChild(0).gameObject;
        tree = this.gameObject.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeState == 0)
        {
            seed.gameObject.SetActive(true);
        }
        else{
            seed.gameObject.SetActive(false);
        }

        if(TimeState == 1)
        {
            tree.gameObject.SetActive(true);
        }
        else{
            tree.gameObject.SetActive(false);
        }

        if(Input.GetKeyDown("o"))
        {
            TimeState--;
        }
        if(Input.GetKeyDown("p"))
        {
            TimeState++;
        }
    
    }
}
