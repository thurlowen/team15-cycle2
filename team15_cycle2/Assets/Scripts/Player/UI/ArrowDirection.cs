using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDirection : MonoBehaviour
{
    private GameObject EndTree;
    private MenuManager MenuManager;

    void Start()
    {
        EndTree = GameObject.FindGameObjectWithTag("EndTree");
        MenuManager = GameObject.Find("Menu").GetComponent<MenuManager>();
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(90,0,0);
        transform.LookAt(EndTree.transform);
    }
}
