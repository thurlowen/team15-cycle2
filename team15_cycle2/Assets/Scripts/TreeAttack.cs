using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAttack : MonoBehaviour
{
    private float enemy_health = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<LookAtCam>().EnHealth = collision.gameObject.GetComponent<LookAtCam>().EnHealth - 0.65f;
            
        }
    }
}
