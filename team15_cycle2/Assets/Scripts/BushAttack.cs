using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushAttack : MonoBehaviour
{
    private float bushDamageToEnemy = 0.3f;

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<LookAtCam>().EnemyHealth = collision.gameObject.GetComponent<LookAtCam>().EnemyHealth - bushDamageToEnemy;
            
            if (collision.gameObject.GetComponent<LookAtCam>().fxstatus.text.Contains("3"))
            {

            }
            else
            {
                collision.gameObject.GetComponent<LookAtCam>().fxstatus.text = collision.gameObject.GetComponent<LookAtCam>().fxstatus.text + "3";
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
