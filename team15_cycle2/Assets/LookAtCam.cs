using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtCam : MonoBehaviour
{
    //public Camera cameraToLookAt;
    
    private float EnHealth;
    private float MaxHealth;
    private Scrollbar slider;
    
    void Start()
    {
        slider = GetComponentInChildren<Scrollbar>();
        MaxHealth = 100f;
        EnHealth = 75f;
    }

    void Update()
    {
        slider.size = EnHealth/MaxHealth;
        Vector3 v = Camera.main.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(Camera.main.transform.position - v);
        transform.Rotate(0, 180, 0);
    }

    public void SetHealth()
    {
        //slider.size EnHealth / MaxHeal
    }
}