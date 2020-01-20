using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cardTurnOver : MonoBehaviour
{
    public GameObject cardFront;
    public GameObject cardBack;
    private Transform frontTransform;
    private Transform backTransform;
    private float mTime = 0.3f;
    private string cardState = "Front";

    // Start is called before the first frame update
    void Start()
    {
        frontTransform= this.gameObject.transform.GetChild(1);
        backTransform = this.gameObject.transform.GetChild(0);
        cardFront = GameObject.Find("Front");
        cardBack = GameObject.Find("Back");
       // print(transform.GetSiblingIndex());
        float posX = transform.position.x;
        float posY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartRotate()
    {
        StartCoroutine(Rotate());
    }

    IEnumerator Rotate()
    {
       
        if(cardState=="Front"){
            frontTransform.DORotate(new Vector3(0, 90, 0), mTime);
            for (float i = mTime; i >= 0; i -= Time.deltaTime)
                yield return 0;
            backTransform.transform.DORotate(new Vector3(0, 0, 0), mTime);
            cardState = "Back";
        }
        else if(cardState == "Back")
        {
            backTransform.transform.DORotate(new Vector3(0, 90, 0), mTime);
            for (float i = mTime; i >= 0; i -= Time.deltaTime)
                yield return 0;
            frontTransform.transform.DORotate(new Vector3(0, 0, 0), mTime);
            cardState = "Front";
        }




    }

}
