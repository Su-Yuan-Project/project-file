using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class travelWorld : MonoBehaviour
{
    float die_clock = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOPunchPosition(new Vector3(0, 60, 0), 1, 40, 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        die_clock += Time.deltaTime;
        if(die_clock > 7){
            Destroy(this.gameObject);
        }
    }
}
