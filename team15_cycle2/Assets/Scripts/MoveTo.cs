using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    private Transform treeLocation;
    NavMeshAgent agent;
    private int TimeState;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TimeState = 0;
        agent.speed = 0f;

        GameObject tree = GameObject.FindGameObjectWithTag("EndTree");
        treeLocation = tree.transform;
    }

    // Update is called once per frame
    void Update()
    {

        agent.destination = treeLocation.transform.position;

        if(TimeState == 1)
        {
            agent.speed = 3.5f;
        }

        if(Input.GetKeyDown("o"))
        {
            TimeState--;
        }
        if(Input.GetKeyDown("p"))
        {
            TimeState++;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            agent.velocity = new Vector3(0,0,0);
            agent.acceleration = 1f;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            agent.acceleration = 8f;
        }
    }
}
