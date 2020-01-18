using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConstantScaler: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float w = Screen.width/1362;
        float h = Screen.height/940;
        Screen.SetResolution(2442,1628,false);
    }
     void Update()
	{
        float w = Screen.width;
        float h = Screen.height;
        Debug.Log(w);
        Debug.Log(h);
	}
}
