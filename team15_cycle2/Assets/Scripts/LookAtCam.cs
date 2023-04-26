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
    public Text fxstatus;
    
    void Start()
    {

        slider = GetComponentInChildren<Scrollbar>();
        fxstatus = GetComponentInChildren<Text>();
        fxstatus.text = "";
        MaxHealth = 100f;
        EnHealth = 100f;
    }

    void Update()
    {
        //fxstatus.text = "100";
        slider.size = EnHealth/MaxHealth;
        Vector3 v = Camera.main.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(Camera.main.transform.position - v);
        transform.Rotate(0, 180, 0);

        if(EnHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    // void OnCollisionStay(Collision col)
    // {
    //     Debug.Log(col.gameObject.tag);
    // }

}