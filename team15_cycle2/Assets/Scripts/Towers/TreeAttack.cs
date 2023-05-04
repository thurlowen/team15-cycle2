using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAttack : MonoBehaviour
{
    private int EnemyNo = 0;

    private TowerAttacks tower_attacks;
    // Start is called before the first frame update
    void Start()
    {
        tower_attacks = GameObject.Find("TowerDamage").GetComponent<TowerAttacks>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<LookAtCam>().EnemyHealth = collision.gameObject.GetComponent<LookAtCam>().EnemyHealth - tower_attacks.treeDamage/EnemyNo;
            if(collision.gameObject.GetComponent<LookAtCam>().fxstatus.text.Contains("2"))
            {}
            else
            {
                collision.gameObject.GetComponent<LookAtCam>().fxstatus.text = collision.gameObject.GetComponent<LookAtCam>().fxstatus.text + "2";
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
