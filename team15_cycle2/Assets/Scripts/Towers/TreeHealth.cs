using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeHealth : MonoBehaviour
{
    public float TreeHealthNo;
    private float MaxHealth;
    private Scrollbar slider;

    private AudioSource treeChop;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Scrollbar>();

        MaxHealth = 100f;
        TreeHealthNo = 100f;

        treeChop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.size = TreeHealthNo/MaxHealth;
    }

    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.tag == "EnemyDMG")
        {
            TreeHealthNo = TreeHealthNo - 0.1f;
            //treeChop.Play();
        }
        
    }
}
