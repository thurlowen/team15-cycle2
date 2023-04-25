# Game Reference List

## First Person Controller:
https://assetstore.unity.com/packages/3d/characters/modular-first-person-controller-189884

## Hotbar Scroller:
https://www.youtube.com/watch?v=-xB4xEmGtCY&list=PLOyj0nn-asmaqBZ_hGoCh-PBlraNaHLyA
https://forum.unity.com/threads/how-do-you-get-mouse-scroll-input.825672/
https://chat.openai.com/
### ChatGPT Prompt:
"This is my code, it is supposed to change the colour of the selected hotbar slot based upon the users input. I have two colours, bcHex which is the base colour for when the slot is not selected and scHex which is the selected colour. how do i firstly set these colours and secondly make only the selected slot changes to the scHex colour?
```csharp
public event Action<int> onCurrentSlotChanged;

    public int currentSlot;
    private int maxSlots = 3;
    private int minSlots = 0;

    private string bcHex = "#373737";
    private string scHex = "#878787";

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

    changeSlotColour();

    //Raise the event whenever the hotbar value changes
    if (onCurrentSlotChanged != null)
    {
        onCurrentSlotChanged(currentSlot);
    }
}

    void changeSlotColour()
{
    GameObject s0 = transform.Find("Slot0").gameObject;
    Image image0 = s0.GetComponent<Image>();
    GameObject s1 = transform.Find("Slot1").gameObject;
    Image image1 = s1.GetComponent<Image>();
    GameObject s2 = transform.Find("Slot2").gameObject;
    Image image2 = s2.GetComponent<Image>();
    GameObject s3 = transform.Find("Slot3").gameObject;
    Image image3 = s3.GetComponent<Image>();

    if (currentSlot == 0)
    {

    }
}
```
"
