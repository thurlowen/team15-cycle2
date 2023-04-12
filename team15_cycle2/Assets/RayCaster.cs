using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public Vector3 RayLocation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    RaycastHit objectHit; 

    void Update()
    {
        if(Input.GetKeyDown("l"))
        {
            
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            Debug.DrawRay(transform.position, fwd * 50, Color.green);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 50))
            {
                //do something if hit object ie
                if(objectHit.collider.gameObject.name=="Ground")
                {
                    Debug.Log(objectHit.point);
                    RayLocation = new Vector3(objectHit.point.x, objectHit.point.y, objectHit.point.z);
                    
                }

            }
        }
    }
}
