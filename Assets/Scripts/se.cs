using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class se : MonoBehaviour,IDragHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("123");
    }
    public void OnDrag(PointerEventData eventData)
	{
        var rect = GetComponent<RectTransform>();
        Vector3 pos = Vector3.zero;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(rect,eventData.position,eventData.enterEventCamera,out pos);
        rect.position = pos ;
	}
}
