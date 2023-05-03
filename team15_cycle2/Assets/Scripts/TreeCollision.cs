using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollision : MonoBehaviour
{
    private EnableShop player_shop;

    // Start is called before the first frame update
    void Start()
    {
        player_shop = GameObject.Find("Player").GetComponent<EnableShop>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "EndTree")
        {
            player_shop.ShopVis();
        }
        
    }
}
