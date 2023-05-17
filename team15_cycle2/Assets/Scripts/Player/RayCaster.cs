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

    private Hotbar hb;
    private int hotbarValue;
    private PlayerCurrency pc;
    private TimeShifter ts;

    
    // Start is called before the first frame update
    void Start()
    {
        //Get a reference to the hotbar script
        hb = GameObject.Find("Hotbar").GetComponent<Hotbar>();
        hb.onCurrentSlotChanged += handleCurrentSlotChanged;
        hotbarValue = hb.currentSlot;
        pc = this.GetComponentInParent<PlayerCurrency>();

        ts = GameObject.Find("TowerDamage").GetComponent<TimeShifter>();
    }

    void handleCurrentSlotChanged(int newSlot)
    {
        hotbarValue = newSlot;
    }

    // Update is called once per frame
    RaycastHit objectHit; 

    void Update()
    {
        if (hotbarValue == 0 && Input.GetMouseButtonDown(0) && pc.playerCurrency >= 100 && ts.isHotbar == true)
        {

            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
            {
                //do something if hit object ie
                if (objectHit.collider.gameObject.tag == "Ground")
                {
                    terrainnn.GetComponent<TerrainDeformer>().DestroyTerrain(new Vector3(objectHit.point.x, objectHit.point.y + 10, objectHit.point.z), 5);
                    Instantiate(WaterSlow, objectHit.point, Quaternion.identity);
                    pc.playerCurrency -= 100;

                }

            }
        }

        if (hotbarValue == 1 && Input.GetMouseButtonDown(0) && pc.playerCurrency >= 75 && ts.isHotbar == true)
        {
            
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
            {
                //do something if hit object ie
                if(objectHit.collider.gameObject.tag=="Ground")
                {
                    RayLocation = new Vector3(objectHit.point.x, objectHit.point.y, objectHit.point.z);
                    Instantiate(TreeCreator, new Vector3(RayLocation.x,2,RayLocation.z), Quaternion.identity);
                    pc.playerCurrency -= 75;
                    
                }

            }
        }

        if(hotbarValue == 2 && Input.GetMouseButtonDown(0) && pc.playerCurrency >= 50 && ts.isHotbar == true)
        {
            
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
            {
                //do something if hit object ie
                if(objectHit.collider.gameObject.tag=="Ground")
                {
                    RayLocation = new Vector3(objectHit.point.x, objectHit.point.y, objectHit.point.z);
                    Instantiate(BushCreator, new Vector3(RayLocation.x,2,RayLocation.z), Quaternion.identity);
                    pc.playerCurrency -= 50;
                    
                }

            }
        }

        if(hotbarValue == 3 && Input.GetMouseButtonDown(0) && pc.playerCurrency >= 25 && ts.isHotbar == true)
        {
            
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, fwd, out objectHit, 5))
            {
                //do something if hit object ie
                if(objectHit.collider.gameObject.tag=="Ground")
                {
                    RayLocation = new Vector3(objectHit.point.x, objectHit.point.y, objectHit.point.z);
                    Instantiate(BeeCreator, new Vector3(RayLocation.x,2,RayLocation.z), Quaternion.identity);
                    pc.playerCurrency -= 25;
                    
                }

            }
        }
        
    }
}
