using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choosePrentice : MonoBehaviour
{
    public GameObject countrychoosedGroup;
    public GameObject hasNotChooseGroup;

    // Start is called before the first frame update
    void Start()
    {
        countrychoosedGroup = GameObject.Find("prenticeChoosedGroup");
        hasNotChooseGroup = GameObject.Find("notchosePrenGroup");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
