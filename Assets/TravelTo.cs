using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelTo : MonoBehaviour
{
    public bool hasChoosed = false; //是否选中作为目的地
    public GameObject countrychoosedGroup;
    public GameObject hasNotChooseGroup;
    public GameObject travelPanel;
    // Start is called before the first frame update
    void Start()
    {
        countrychoosedGroup = GameObject.Find("countryChoosedGroup");
        hasNotChooseGroup = GameObject.Find("VerticalGroup");
        travelPanel = GameObject.Find("TravelTo(Clone)");
    }
    public void chooseToTravel()
    {
        if(!hasChoosed){
            this.transform.SetParent(countrychoosedGroup.transform);
            hasChoosed = true;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "秦") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 5;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "齐") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 1;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "鲁") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 0;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "魏") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 3;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "晋") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 3;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "楚") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 4;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "郑") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 3;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "宋") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 3;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "卫") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes += 2;



        }
        else if(hasChoosed){
            this.transform.SetParent(hasNotChooseGroup.transform);
            hasChoosed = false;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "秦") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 5;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "齐") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 1;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "鲁") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 0;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "魏") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 3;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "晋") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 3;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "楚") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 4;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "郑") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 3;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "宋") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 3;
            if (this.transform.GetChild(0).GetComponent<Text>().text == "卫") travelPanel.transform.GetComponent<travelPanelInitialize>().roundTimes -= 2;

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
