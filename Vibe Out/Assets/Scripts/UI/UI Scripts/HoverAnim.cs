using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverAnim : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public RectTransform Button;
    // Start is called before the first frame update
    void Start()
    {
        Button.GetComponent<Animator>().Play("Hover Off");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("HoverAnimation");
    } 
    
    public void OnPointerExit(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Hover Off");
    }
    
   
}
