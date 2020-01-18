using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsControllers : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
       float x = this.transform.GetChild(0).transform.position.x;
        float y = this.transform.GetChild(0).transform.position.y;
        Debug.Log("123"+x);
        Debug.Log("123"+y);

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.mousePosition.x;
        float y = Input.mousePosition.y;
        Debug.Log("x="+x);
        Debug.Log("y="+y);
    }
}
