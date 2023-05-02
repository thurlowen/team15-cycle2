using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushAttack : MonoBehaviour
{
    private float bushDamageToEnemy = 0.3f;
    private int EnemyNo = 0;

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<LookAtCam>().EnemyHealth = collision.gameObject.GetComponent<LookAtCam>().EnemyHealth - bushDamageToEnemy/EnemyNo;
            
            if (collision.gameObject.GetComponent<LookAtCam>().fxstatus.text.Contains("3"))
            {

            }
            else
            {
                collision.gameObject.GetComponent<LookAtCam>().fxstatus.text = collision.gameObject.GetComponent<LookAtCam>().fxstatus.text + "3";
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
