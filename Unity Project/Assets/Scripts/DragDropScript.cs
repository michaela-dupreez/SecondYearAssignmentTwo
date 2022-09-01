using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerDownHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    public GameObject itemBeingMoved;

    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public Vector3 defaultPos;
    public bool droppedOnSlot;

    void Start()
    {
        defaultPos = transform.position;
        //Establishes the vector positions of all gameObjects
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        //Position, size, anchor and pivot information of the gameObjects 
        canvasGroup = GetComponent<CanvasGroup>();
        //Allows all the UI elements within the canvas to be controlled from one CanvasGroup

        defaultPos = transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        //When the item starts being dragged, collision with gameObjects is turned off

        eventData.pointerDrag.GetComponent<DragDropScript>().droppedOnSlot = false;
        //Stops the item from being dropped onto the slot when the drag begins 

    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        //Makes the item follow the mouse while it's being dragged 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        //When the item is no longer being dragged, collision with gameObjects is turned on 

        if (droppedOnSlot == false)
        {
            transform.position = defaultPos;
        }
        //If the item is not dropped onto a new slot, it returns to the slot that it was originally on 
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
    //Tracks when the mouse is pushed down 

}
