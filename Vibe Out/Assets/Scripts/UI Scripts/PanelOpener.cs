using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;


    public void OpenPanel()
    {
        if(Panel != null)
        {
            Panel2.SetActive(false);
            Panel3.SetActive(false);
            Panel4.SetActive(false);
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
    public void OpenPanel2()
    {
        if(Panel2 != null)
        {
            Panel3.SetActive(false);
            Panel.SetActive(false);
            Panel4.SetActive(false);
            bool isActive = Panel2.activeSelf;

            Panel2.SetActive(!isActive);
        }
    }    
    
    public void OpenPanel3()
    {
        if(Panel3 != null)
        {
            Panel.SetActive(false);
            Panel2.SetActive(false);
            Panel4.SetActive(false);
            bool isActive = Panel3.activeSelf;

            Panel3.SetActive(!isActive);
        }
    }
    
    public void OpenPanel4()
    {
        if(Panel3 != null)
        {
            Panel.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(false);
            bool isActive = Panel3.activeSelf;

            Panel4.SetActive(!isActive);
        }
    }
 
    
}
