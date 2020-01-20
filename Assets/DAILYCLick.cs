using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
//
public class DAILYCLick : MonoBehaviour
{
    public GameObject objPlace;
    public GameObject originalPlace;
    public bool expend = false;
    private float time_i;
    // Start is called before the first frame update
    void Start()
    {
        time_i = 0;
    }
    public void DailyClick()
    {
        /*
        if (expend == false)
        {
            time_i = 0;
            this.transform.DOMove(objPlace.transform.position, 1);
            this.transform.DOScale(9, 1);
            expend = true;
        }
        if(expend == true)
        {
            if(time_i > 1){
                this.transform.DOMove(originalPlace.transform.position, 1);
                this.transform.DOScale(1, 1);
                expend = false;
            }
        }
        */
    }
    // Update is called once per frame
    void Update()
    {
        time_i += Time.deltaTime;
    }
}
