using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MapScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOPunchRotation(new Vector3(2,2,2),1,10,0.5f);//上下震动 DoPunchPosition DoPunchRotation
        transform.DOShakePosition(10,Vector3.one,10,90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
