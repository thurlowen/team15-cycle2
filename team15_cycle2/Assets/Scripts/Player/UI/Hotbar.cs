using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hotbar : MonoBehaviour
{
    public int currentSlot;
    private int maxSlots = 3;
    //private int minSlots = 0;

    //Creates an event for switching between different towers
    public event Action<int> onCurrentSlotChanged;

    private TimeShifter ts;
    private Canvas hotbarElement;

    //Hotbar colours
    private string bcHex = "#373737"; //resting (background) colour - dark grey
    private string scHex = "#878787"; //selected colour - light grey

    //Toggle the hotbar based on timestate
    void Start()
    {
        ts = GameObject.Find("TowerDamage").GetComponent<TimeShifter>();

        hotbarElement = gameObject.AddComponent<Canvas>();
        hotbarElement.enabled = true;
    }

    void Update()
    {
        if (ts.isHotbar == true)
        {
            hotbarElement.enabled = true;
            
            //Toggles between the 4 slots
            float scroll = Input.GetAxis("Mouse ScrollWheel");

            //if (scroll > 0f)
            //{
            //    currentSlot += 1;
            //    if (currentSlot >= maxSlots)
            //    {
            //        currentSlot = maxSlots;
            //    }
            //}
            //else if (scroll < 0f)
            //{
            //    currentSlot -= 1;
            //    if (currentSlot <= minSlots)
            //    {
            //        currentSlot = minSlots;
            //    }



            if (scroll < 0)
            {
                if (currentSlot < maxSlots)
                {
                    currentSlot++;
                }
                else
                {
                    currentSlot = 0;
                }
            }
            else if (scroll > 0)
            {
                if (currentSlot > 0)
                {
                    currentSlot--;
                }
                else
                {
                    currentSlot = maxSlots;
                }
            }

            changeSlotColour();

            //Raise the above event whenever the hotbar value changes so the RayCaster script knows whats happening
            if (onCurrentSlotChanged != null)
            {
                onCurrentSlotChanged(currentSlot);
            }
        }

        if (ts.isHotbar == false)
        {
            hotbarElement.enabled = false;
        }
    }

    void changeSlotColour()
    {
        //Translates the colours into ones unity understands
        Color baseColour = Color.white;
        ColorUtility.TryParseHtmlString(bcHex, out baseColour);

        Color selectedColour = Color.white;
        ColorUtility.TryParseHtmlString(scHex, out selectedColour);
        
        //Gets the the slot, then the image child, then sets translated bg colour for all slots
        GameObject s0 = transform.Find("Slot0").gameObject;
        Image image0 = s0.GetComponent<Image>();
        image0.color = baseColour;

        GameObject s1 = transform.Find("Slot1").gameObject;
        Image image1 = s1.GetComponent<Image>();
        image1.color = baseColour;

        GameObject s2 = transform.Find("Slot2").gameObject;
        Image image2 = s2.GetComponent<Image>();
        image2.color = baseColour;

        GameObject s3 = transform.Find("Slot3").gameObject;
        Image image3 = s3.GetComponent<Image>();
        image3.color = baseColour;

        //Sets the colours based upon what slot is selected
        if (currentSlot == 0)
        {
            image0.color = selectedColour;
        }
        else if (currentSlot == 1)
        {
            image1.color = selectedColour;
        }
        else if (currentSlot == 2)
        {
            image2.color = selectedColour;
        }
        else if (currentSlot == 3)
        {
            image3.color = selectedColour;
        }
    }
}
