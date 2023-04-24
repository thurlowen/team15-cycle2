using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hotbar : MonoBehaviour
{
    public int currentSlot = 0;
    private int maxSlots = 3;
    private int minSlots = 0;

    private GameObject Slot0;
    private GameObject Slot1;
    private GameObject Slot2;
    private GameObject Slot3;

    void Start()
    {
        Slot0 = GameObject.Find("Slot0");
        Image slot0Image = Slot0.GetComponent<Image>();

        Slot1 = GameObject.Find("Slot1");
        Image slot1Image = Slot1.GetComponent<Image>();

        Slot2 = GameObject.Find("Slot2");
        Image slot2Image = Slot2.GetComponent<Image>();

        Slot3 = GameObject.Find("Slot3");
        Image slot3Image = Slot3.GetComponent<Image>();
    }

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0f)
        {
            currentSlot += 1;
            if (currentSlot >= maxSlots)
            {
                currentSlot = maxSlots;
            }
        }
        else if (scroll < 0f)
        {
            currentSlot -= 1;
            if (currentSlot <= minSlots)
            {
                currentSlot = minSlots;
            }
        }


        
    }
}
