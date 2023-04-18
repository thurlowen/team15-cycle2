using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public GameObject AttackLocation;
    NavMeshAgent agent;
    private int TimeState;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TimeState = 0;
        agent.speed = 0f;

    }

    // Update is called once per frame
    void Update()
    {

        agent.destination = AttackLocation.transform.position;

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
}
