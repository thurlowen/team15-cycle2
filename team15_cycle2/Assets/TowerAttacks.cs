using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttacks : MonoBehaviour
{
    public float treeDamage;
    public float venusDamage;
    public float bushDamage;
    // Start is called before the first frame update
    void Start()
    {
        treeDamage = 0.65f;
        venusDamage = 0.15f;
        bushDamage = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TreeUp()
    {
        treeDamage = treeDamage*1.2f;
    }
    public void VenusUp()
    {
        venusDamage = venusDamage*1.2f;
    }
    public void BushUp()
    {
        bushDamage = bushDamage*1.2f;
    }
}
