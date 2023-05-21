using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgTree : MonoBehaviour
{
    private Transform childObject;
    private SphereCollider childSphereCollider;
    UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponentInParent<UnityEngine.AI.NavMeshAgent>();
        //childObject = GetChildByName("AtkCol");
        childObject = transform.Find("AtkCol");
        childSphereCollider = childObject.GetComponent<SphereCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "EndTree")
        {
            agent.speed = 0f;
            agent.velocity = new Vector3(0,0,0);
            agent.acceleration = 0f;

            //CHANGE ANIMATION HERE
        }
    }
}
