using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CardsManager : MonoBehaviour
{

    private int StartCardsNumber;//初始的卡牌数量
    private float RotateTime = 0.3f;
    // Start is called before the first frame update


  
    void Start()
    {
        StartCardsNumber = this.transform.childCount;
        //卡牌归位
        for (int i = 0; i < StartCardsNumber;i++)
        {
            Transform cardTransform = this.transform.GetChild(i).transform;
            Transform objPlace = GameObject.Find("CardFrame").transform.GetChild(i).transform;
            Transform front = cardTransform.GetChild(0).transform;
            Transform back = cardTransform.GetChild(1).transform;
           // StartCoroutine(Rotate(front,back));
            cardTransform.DOMove(new Vector3(objPlace.transform.position.x,objPlace.position.y,0),0.5f);
            cardTransform.DOScale(new Vector3(0.6f, 0.6f, 0), 0.3f);

        }
    }
    IEnumerator Rotate(Transform front,Transform back)
    {
        front.DORotate(new Vector3(0, 90, 0), RotateTime);
        for (float i = RotateTime; i >= 0; i -= Time.deltaTime)
            yield return 0;
        back.transform.DORotate(new Vector3(0, 0, 0), RotateTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
