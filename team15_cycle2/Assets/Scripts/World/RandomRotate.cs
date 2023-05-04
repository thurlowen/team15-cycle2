using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(0.0f, Random.Range(0f, 360f), 0.0f, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
