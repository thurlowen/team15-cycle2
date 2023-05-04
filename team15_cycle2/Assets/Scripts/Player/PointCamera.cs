using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCamera : MonoBehaviour
{
    private Scrollbar slider;
    
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Scrollbar>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = Camera.main.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(Camera.main.transform.position - v);
        transform.Rotate(0, 180, 0);
    }
}
