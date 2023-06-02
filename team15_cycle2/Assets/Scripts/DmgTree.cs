using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgTree : MonoBehaviour
{
    private Transform childObject;
    private SphereCollider childSphereCollider;
    UnityEngine.AI.NavMeshAgent agent;
    private TreeHealth TreeHealth;
    private Animator anim;
    private ParticleSystem flame_enable;

    private MenuManager MenuManager;

    // Start is called before the first frame update
    void Start()
    {
        flame_enable = GetComponentInChildren<ParticleSystem>();
        anim = GetComponentInChildren<Animator>();
        TreeHealth = FindObjectOfType<TreeHealth>();
        agent = GetComponentInParent<UnityEngine.AI.NavMeshAgent>();
        //childObject = GetChildByName("AtkCol");
        childObject = transform.Find("AtkCol");
        childSphereCollider = childObject.GetComponent<SphereCollider>();

        flame_enable.Pause();

        MenuManager = FindObjectOfType<MenuManager>();
    }

    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (!MenuManager.pauseMenuActive)
        {
            if(col.gameObject.tag == "EndTree")
            {
                agent.speed = 0f;
                agent.velocity = new Vector3(0,0,0);
                agent.acceleration = 0f;

                TreeHealth.TreeHealthNo = TreeHealth.TreeHealthNo - 0.1f;

                //CHANGE ANIMATION HERE
                anim.Play("Attack",0,0);
                flame_enable.Play();
            }
        }
    }
}
