using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class territoryController : MonoBehaviour
{
    private float fromValue = 0f;
    private float toValue = 1f;
    //获取所有地块
    public GameObject Shandong;
    private int ShanDongChildCount;
    // Start is called before the first frame update
    void Start()
    {
         ShanDongChildCount = Shandong.transform.childCount;
        Debug.Log("Shand="+ShanDongChildCount);
        for (int i = 0; i < ShanDongChildCount;i++){
             Transform childTransform = Shandong.transform.GetChild(i);
             childTransform.GetComponent<CanvasGroup>().alpha = 0.5f;

        
           
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
