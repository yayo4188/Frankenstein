using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Panel;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Panel.SetActive(true);  
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Panel.SetActive(false);
    }    
}
