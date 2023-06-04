using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private FirstPersonController FPS;
    private Collider Terrain;

    void Start()
    {
        FPS = FindObjectOfType<FirstPersonController>();
        Terrain = GameObject.Find("Terrain").GetComponent<TerrainCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
