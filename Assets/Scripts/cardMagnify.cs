using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cardMagnify : MonoBehaviour
{
    private float PosX;
    private float PosY;
    private string cardState="normal"; 
    // Start is called before the first frame update
    void Start()
    {
        PosX = this.transform.position.x;
        PosY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
 
        float mouseAxis_X = Input.mousePosition.x;
        float mouseAxis_Y = Input.mousePosition.y;
        if (mouseAxis_X - PosX < 70 &&  mouseAxis_X - PosX > -70 && mouseAxis_Y-PosY<100 && mouseAxis_Y - PosY>-100)
        {
            Debug.Log(mouseAxis_X-PosX);
        
            transform.DOScale(new Vector3(1.5f, 1.5f, 0), 0.3f);
        }
        else {
            transform.DOScale(new Vector3(1f,1f,0),0.5f);
    
        }
   
            

            
        
        
    }
}
