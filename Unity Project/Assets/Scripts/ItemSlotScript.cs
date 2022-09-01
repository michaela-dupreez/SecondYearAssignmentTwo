using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotScript : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject parentPanel;
    public Transform parentPanelTransform;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<DragDropScript>().defaultPos = transform.position;
        }
        //Drops the item onto the slot when the mouse is no longer being clicked

        parentPanelTransform = parentPanel.transform;
        eventData.pointerDrag.GetComponent<DragDropScript>().itemBeingMoved.transform.SetParent(parentPanelTransform, false);
        //Changes the parent of the item gameObject so that the item can be dropped onto a slot in another panel
        //i.e. An item being moved from the shop panel into the bag panel 

    }
}
