using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private Vector3 RayLocation;
    public GameObject TreeCreator;
    public GameObject BushCreator;
    public GameObject BeeCreator;
    public GameObject terrainnn;
    public GameObject WaterSlow;

    
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
            //Debug.DrawRay(transform.position, fwd * 10, Color.green);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
            {
                //do something if hit object ie
                if(objectHit.collider.gameObject.tag=="Ground")
                {
                    Debug.Log(objectHit.point);
                    RayLocation = new Vector3(objectHit.point.x, objectHit.point.y, objectHit.point.z);
                    Instantiate(TreeCreator, new Vector3(RayLocation.x,2,RayLocation.z), Quaternion.identity);
                    
                }

            }
        }
        if(Input.GetKeyDown("k"))
        {
            
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            //Debug.DrawRay(transform.position, fwd * 10, Color.green);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
            {
                //do something if hit object ie
                if(objectHit.collider.gameObject.tag=="Ground")
                {
                    Debug.Log(objectHit.point);
                    RayLocation = new Vector3(objectHit.point.x, objectHit.point.y, objectHit.point.z);
                    Instantiate(BushCreator, new Vector3(RayLocation.x,2,RayLocation.z), Quaternion.identity);
                    
                }

            }
        }
        if(Input.GetKeyDown("j"))
        {
            
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            //Debug.DrawRay(transform.position, fwd * 10, Color.green);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
            {
                //do something if hit object ie
                if(objectHit.collider.gameObject.tag=="Ground")
                {
                    Debug.Log(objectHit.point);
                    RayLocation = new Vector3(objectHit.point.x, objectHit.point.y, objectHit.point.z);
                    Instantiate(BeeCreator, new Vector3(RayLocation.x,2,RayLocation.z), Quaternion.identity);
                    
                }

            }
        }
        if(Input.GetKeyDown("h"))
        {
            
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            //Debug.DrawRay(transform.position, fwd * 10, Color.green);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
            {
                //do something if hit object ie
                if(objectHit.collider.gameObject.tag=="Ground")
                {
                    Debug.Log(objectHit.point);
                    //RayLocation = new Vector3(objectHit.point.x, objectHit.point.y, objectHit.point.z);
                    terrainnn.GetComponent<TerrainDeformer>().DestroyTerrain(new Vector3(objectHit.point.x, objectHit.point.y+10, objectHit.point.z),5);
                    Instantiate(WaterSlow, objectHit.point, Quaternion.identity);
                    
                }

            }
        }
    }
}
