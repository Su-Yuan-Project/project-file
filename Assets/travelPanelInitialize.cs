using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class travelPanelInitialize : MonoBehaviour
{
    public GameObject ChineseMap;
    public List<CountryInfo> countries;
    public GameObject countrySite;
    public GameObject verticalGroup;
    public GameObject hasChoosedCountryGroup;
    public int roundTimes = 0;
    public GameObject showRound;
    // Start is called before the first frame update
    void Start()   
    {
        ChineseMap= GameObject.Find("ChineseMap");
        countries = ChineseMap.transform.GetComponent<CountryManager>().countries;
        countrySite = GameObject.Find("countrySiteList"); //国家按钮位置
        verticalGroup = GameObject.Find("VerticalGroup"); //以后有可能会和countryPanel的verticalGroup相冲突
        hasChoosedCountryGroup = GameObject.Find("countryChoosedGroup");
        showRound = GameObject.Find("ShowRound");
        foreach(CountryInfo country in countries)
        {
            Object countryButton = Resources.Load("countryPath", typeof(GameObject));
            GameObject countryClickButton = Instantiate(countryButton) as GameObject;
            countryClickButton.transform.SetParent(verticalGroup.transform, false);
            //Generate state name
            Transform Text = countryClickButton.transform.GetChild(0);
            Text.GetComponent<UnityEngine.UI.Text>().text = country.state;
        }
    }

    // Update is called once per frame
    void Update()
    {
        showRound.transform.GetComponent<Text>().text = roundTimes.ToString() + "回合";
    }
}
