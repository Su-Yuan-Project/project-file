using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeTravelPanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void closePanel()
    {
        Destroy(GameObject.Find("TravelTo(Clone)"));
        Destroy(GameObject.Find("Mission(Clone)"));
        Destroy(GameObject.Find("ZhuZi(Clone)"));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
