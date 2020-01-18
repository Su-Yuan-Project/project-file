using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countryClick : MonoBehaviour
{
    bool hasChoosed = false; //是否选中作为目的地

    public void CLickCountry()
    {
        string statename = this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text;
        Debug.Log(statename);
        GameObject chineseMap = GameObject.Find("ChineseMap");
        chineseMap.GetComponent<CountryManager>().GenerateCountryDetailedInfo(statename);
    }




}
