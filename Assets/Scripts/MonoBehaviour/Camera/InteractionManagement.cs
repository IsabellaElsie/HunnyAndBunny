using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManagement : MonoBehaviour
{
    public Interactable currentObject;

    LayerMask m_LayerMask;

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;



    private void Awake()
    {
        m_LayerMask = LayerMask.GetMask("InteractableItems");
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, m_LayerMask))
        {
            /*IF hit object == An Interactable Object*/
               // Debug.Log("RayCast HIT!");
        }
    }

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        Debug.Log("OnMouseEnter called.");
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
        Debug.Log("OnMouseExit called.");
    }

}
