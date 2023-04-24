using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotbar : MonoBehaviour
{
    public int currentSlot = 0;
    private int maxSlots = 3;
    private int minSlots = 0;

    void Start()
    {
        
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
