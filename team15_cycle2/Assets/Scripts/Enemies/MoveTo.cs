using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    private Transform treeLocation;
    NavMeshAgent agent;
    private int TimeState;
    private TimeShifter TimeShifter;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TimeState = 0;
        agent.speed = 0f;

        GameObject tree = GameObject.FindGameObjectWithTag("EndTree");
        treeLocation = tree.transform;
        TimeShifter = FindObjectOfType<TimeShifter>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeState = TimeShifter.timeState;
        agent.destination = treeLocation.transform.position;

        if(TimeState == 1)
        {
            agent.speed = 3.5f;
        }
        else
        {
            agent.speed = 0f;
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
            agent.velocity = new Vector3(-1,0,0);
            agent.acceleration = 1f;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            agent.velocity = new Vector3(-1f,0,0);
            agent.acceleration = 8f;
        }
    }
}
