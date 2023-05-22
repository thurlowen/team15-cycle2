using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeHealth : MonoBehaviour
{
    public float TreeHealthNo;
    private float MaxHealth;
    private Scrollbar slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Scrollbar>();

        MaxHealth = 100f;
        TreeHealthNo = 100f;
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
        }
    }
}
