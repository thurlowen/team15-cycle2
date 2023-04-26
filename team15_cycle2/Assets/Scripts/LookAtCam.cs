using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtCam : MonoBehaviour
{
    //public Camera cameraToLookAt;
    
    public float EnemyHealth;
    private float MaxHealth;
    private Scrollbar slider;
    public Text fxstatus;
    
    void Start()
    {

        slider = GetComponentInChildren<Scrollbar>();
        fxstatus = GetComponentInChildren<Text>();
        fxstatus.text = "";
        MaxHealth = 100f;
        EnemyHealth = 100f;
    }

    void Update()
    {
        //fxstatus.text = "100";
        slider.size = EnemyHealth/MaxHealth;
        Vector3 v = Camera.main.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(Camera.main.transform.position - v);
        transform.Rotate(0, 180, 0);

        if(EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    // void OnCollisionStay(Collision col)
    // {
    //     Debug.Log(col.gameObject.tag);
    // }

}