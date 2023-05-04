using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FovChange : MonoBehaviour
{
    float t = 90f;
    bool fovEffect = false;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Camera.main.fieldOfView = t;
        if(fovEffect == true && count == 0)
        {
            if(t <= 190f)
            {
                t += Time.deltaTime * 500;
            }
            else
            {
                count = 1;
            }
        }
        if(fovEffect == true && count == 1)
        {
            if(t >= 90f)
            {
                t -= Time.deltaTime * 500;
            }
            else
            {
                fovEffect = false;
                count = 0;
            }
        }


        if(Input.GetKeyDown("p"))
        {
            fovEffect = true;
        }
    }

}
