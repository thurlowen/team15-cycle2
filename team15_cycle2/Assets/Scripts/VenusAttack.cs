using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusAttack : MonoBehaviour
{
    // Start is called before the first frame update
    private int EnemyNo = 0;

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
            collision.gameObject.GetComponent<LookAtCam>().EnemyHealth = collision.gameObject.GetComponent<LookAtCam>().EnemyHealth - 0.15f/EnemyNo;
            if(collision.gameObject.GetComponent<LookAtCam>().fxstatus.text.Contains("4"))
            {

            }
            else
            {
                collision.gameObject.GetComponent<LookAtCam>().fxstatus.text = collision.gameObject.GetComponent<LookAtCam>().fxstatus.text + "4";
            }
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyNo++;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyNo--;
            collision.gameObject.GetComponent<LookAtCam>().fxstatus.text = "";
        }
    }
}
