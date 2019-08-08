
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour// , IPointerEnterHandler, IPointerExitHandler
{
    //public Transform InteractionLocation;

    public void RunInteraction()
    {
        Debug.Log("Interaction is running.");
    }


 

    /*public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer Enter.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer Exit.");
    }*/


}
