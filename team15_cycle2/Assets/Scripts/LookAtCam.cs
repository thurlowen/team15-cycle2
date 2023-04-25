using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtCam : MonoBehaviour
{
    //public Camera cameraToLookAt;
    
    public float EnHealth;
    private float MaxHealth;
    private Scrollbar slider;
    
    void Start()
    {
        slider = GetComponentInChildren<Scrollbar>();
        MaxHealth = 100f;
        EnHealth = 100f;
    }

    void Update()
    {
        slider.size = EnHealth/MaxHealth;
        Vector3 v = Camera.main.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(Camera.main.transform.position - v);
        transform.Rotate(0, 180, 0);

        if(EnHealth <= 0)
        {
            Debug.Log("enemy dead");
            Destroy(gameObject);
        }
    }

    // void OnCollisionStay(Collision collision)
    // {
    //     Debug.Log(collision.gameObject.tag);
    //     if (collision.gameObject.tag == "1Tree")
    //     {
    //         Debug.Log("test");
    //         EnHealth -= 0.1f;
    //     }
    // }
}