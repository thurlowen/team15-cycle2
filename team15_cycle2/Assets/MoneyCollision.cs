using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollision : MonoBehaviour
{
    private PlayerCurrency playerc;

    // Start is called before the first frame update
    void Start()
    {
        playerc = GameObject.Find("Player").GetComponent<PlayerCurrency>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            playerc.p_curr += 25;

        }
    }
}
