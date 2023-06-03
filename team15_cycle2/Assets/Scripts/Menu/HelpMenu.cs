using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpMenu : MonoBehaviour
{
    //private Canvas HM;

    public GameObject TabButton1;
    public GameObject TabButton2;
    public GameObject TabButton3;

    public GameObject TabContents1;
    public GameObject TabContents2;
    public GameObject TabContents3;

    void Start()
    {
        //HM = gameObject.GetComponent<Canvas>();
        //HM.enabled = false;
        gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    public void HideAllTabs()
    {
        TabContents1.SetActive(false);
        TabContents2.SetActive(false);
        TabContents3.SetActive(false);

        TabButton1.GetComponent<Button>().image.color = new Color32(0, 0, 0, 240);
        TabButton2.GetComponent<Button>().image.color = new Color32(0, 0, 0, 240);
        TabButton3.GetComponent<Button>().image.color = new Color32(0, 0, 0, 240);
    }

    public void ShowTab1()
    {
        HideAllTabs();
        TabContents1.SetActive(true);
        TabButton1.GetComponent<Button>().image.color = new Color32(0, 0, 0, 250);
    }

    public void ShowTab2()
    {
        HideAllTabs();
        TabContents2.SetActive(true);
        TabButton2.GetComponent<Button>().image.color = new Color32(0, 0, 0, 250);
    }

    public void ShowTab3()
    {
        HideAllTabs();
        TabContents3.SetActive(true);
        TabButton3.GetComponent<Button>().image.color = new Color32(0, 0, 0, 250);
    }
}
