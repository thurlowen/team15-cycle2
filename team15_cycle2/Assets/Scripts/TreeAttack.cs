using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAttack : MonoBehaviour
{
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
            collision.gameObject.GetComponent<LookAtCam>().EnemyHealth = collision.gameObject.GetComponent<LookAtCam>().EnemyHealth - 0.65f;
            if(collision.gameObject.GetComponent<LookAtCam>().fxstatus.text.Contains("2"))
            {}
            else
            {
                collision.gameObject.GetComponent<LookAtCam>().fxstatus.text = collision.gameObject.GetComponent<LookAtCam>().fxstatus.text + "2";
            }
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<LookAtCam>().fxstatus.text = "";
        }
    }
}
