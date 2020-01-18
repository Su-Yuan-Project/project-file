using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartIntro : MonoBehaviour
{
    public GameObject juanzhouobject;
    private float time_i;
    private float time_start = 3600;
    // Start is called before the first frame update
    void Start()
    {
        juanzhouobject = GameObject.Find("juanzhouobject");
        time_i = 0;
        transform.DOMove(juanzhouobject.transform.position,1,false);
      //  transform.DOPunchPosition(new Vector3(0, 60, 0), 1, 40, 0.001f);

    }
    public void StartDrop()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        time_i += Time.deltaTime;
       
        if(time_i>10) Destroy(this.gameObject);
        if(time_i>1&&time_i<1.018)transform.DOPunchPosition(new Vector3(0, 40, 0), 2, 10, 0.025f);
        
    }
}
