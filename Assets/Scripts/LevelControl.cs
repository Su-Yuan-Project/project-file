using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class LevelControl : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
    private ScrollRect scrollRect;
    // Start is called before the first frame update
    private GameObject TextScroller;
    private ScrollRect TextScrollRect;
    void Start()
    {
        scrollRect = this.GetComponent<ScrollRect>();
        TextScroller = GameObject.Find("TextScroller");
        TextScrollRect = TextScroller.GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        float pos = TextScrollRect.horizontalNormalizedPosition;
        Debug.Log(pos);

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        float pos = scrollRect.horizontalNormalizedPosition;
        if (pos > 0.35 && pos < 0.9)
            scrollRect.horizontalNormalizedPosition = 0.5f;
        else if (pos > 0.8)
            scrollRect.horizontalNormalizedPosition = 1.0f;
        else
            scrollRect.horizontalNormalizedPosition = 0f;
            
           Debug.Log(pos);


    }
   
    public void RightArrowControl()
    {
        float pos = scrollRect.horizontalNormalizedPosition;
        if (pos < 0.4){
            scrollRect.horizontalNormalizedPosition = 0.5f;
            TextScrollRect.horizontalNormalizedPosition = 0.5f;
        }
        else if (pos < 0.8){
            scrollRect.horizontalNormalizedPosition = 0.998f;
            TextScrollRect.horizontalNormalizedPosition = 1.0f;
        }
        
        else
        {
            GameObject rightArrow = GameObject.Find("rightBlack");
            rightArrow.GetComponent<MeshRenderer>().material.color = Color.gray;
        }


    }
    public void LeftArrowControl()
    {
        float pos = scrollRect.horizontalNormalizedPosition;
        if (pos > 0.8)
        {
            scrollRect.horizontalNormalizedPosition = 0.5f;
            TextScrollRect.horizontalNormalizedPosition = 0.5f;
        }
        else if (pos > 0.4){
            scrollRect.horizontalNormalizedPosition = 0.0f; 
            TextScrollRect.horizontalNormalizedPosition = 0.0f;
        }
           
        else
        {
            GameObject rightArrow = GameObject.Find("LeftBlack");
            rightArrow.GetComponent<MeshRenderer>().material.color = Color.gray;
        }


    }


}
