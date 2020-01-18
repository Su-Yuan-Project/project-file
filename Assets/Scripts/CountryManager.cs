using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class CountryInfo
{
    public string state;
    public string king;
    public string primeMinister;
    public Transform[] territory;
    public float[] thoughtsRatio = new float[4];
    public string countryState;//?
    public CountryInfo(int n)
    {
        territory = new Transform[n];
    }
}

public class CountryManager : MonoBehaviour
{
    public List<CountryInfo> countries = new  List<CountryInfo>();//  list of country information
    public GameObject MainCamera;
    protected float scaleSpeed = 0.5F;     //the speed of zoom
  
    public void Start()
    {

         Transform WeiHai = GameObject.Find("临淄").transform;


        //齐国
        CountryInfo country1 = new CountryInfo(5);
        country1.state = "齐";
        country1.king = "齐桓公";
        country1.primeMinister = "管仲";
        country1.thoughtsRatio[0] = 25f; country1.thoughtsRatio[1] = 25f;country1.thoughtsRatio[2] = 25f;country1.thoughtsRatio[3] = 25f;
        country1.territory[0] = GameObject.Find("临淄").transform;
       // country1.territory[1] = GameObject.Find("东莱").transform;
        country1.territory[2] = GameObject.Find("历下").transform;
        country1.territory[3] = GameObject.Find("夜").transform;
        country1.territory[4] = GameObject.Find("淳于").transform;

        //鲁国
        CountryInfo country2 = new CountryInfo(5);
        country2.state = "鲁";
        country2.king = "鲁昭公";
        country2.primeMinister = "季平子";
        country2.thoughtsRatio[0] = 25f; country2.thoughtsRatio[1] = 25f; country2.thoughtsRatio[2] = 25f; country2.thoughtsRatio[3] = 25f;
      
        country2.territory[0] = GameObject.Find("曲阜").transform;

        //卫国
        CountryInfo country3 = new CountryInfo(5);
        country3.state = "卫";
        country3.king = "卫襄公";
        country3.primeMinister = "";
        country3.thoughtsRatio[0] = 25f; country3.thoughtsRatio[1] = 25f; country3.thoughtsRatio[2] = 25f; country3.thoughtsRatio[3] = 25f;
        country3.territory[0]= GameObject.Find("朝歌").transform;
        country3.territory[1]= GameObject.Find("城濮").transform;

        //晋国
        CountryInfo country4 = new CountryInfo(10);
        country4.state = "晋";
        country4.king = "晋定公";
        country4.primeMinister = "";
        country4.thoughtsRatio[0] = 25f; country4.thoughtsRatio[1] = 25f; country4.thoughtsRatio[2] = 25f; country4.thoughtsRatio[3] = 25f;
        country4.territory[0] = GameObject.Find("朝歌").transform;
        country4.territory[1] = GameObject.Find("城濮").transform;

        //郑国
        CountryInfo country5 = new CountryInfo(5);
        country5.state = "郑";
        country5.king = "郑声公";
        country5.primeMinister = "";
        country5.thoughtsRatio[0] = 25f; country5.thoughtsRatio[1] = 25f; country5.thoughtsRatio[2] = 25f; country5.thoughtsRatio[3] = 25f;
        country5.territory[0] = GameObject.Find("朝歌").transform;
        country5.territory[1] = GameObject.Find("城濮").transform;

        //宋国
        CountryInfo country6 = new CountryInfo(5);
        country6.state = "宋";
        country6.king = "宋襄公";
        country6.primeMinister = "";
        country6.thoughtsRatio[0] = 25f; country6.thoughtsRatio[1] = 25f; country6.thoughtsRatio[2] = 25f; country6.thoughtsRatio[3] = 25f;
        country6.territory[0] = GameObject.Find("朝歌").transform;
        country6.territory[1] = GameObject.Find("城濮").transform;
      

        //秦国
        CountryInfo country7 = new CountryInfo(10);
        country7.state = "秦";
        country7.king = "秦惠公";
        country7.primeMinister = "";
        country7.thoughtsRatio[0] = 25f; country7.thoughtsRatio[1] = 25f; country7.thoughtsRatio[2] = 25f; country7.thoughtsRatio[3] = 25f;
        country7.territory[0] = GameObject.Find("朝歌").transform;
        country7.territory[1] = GameObject.Find("城濮").transform;

        //楚国
        CountryInfo country8 = new CountryInfo(10);
        country8.state = "楚";
        country8.king = "秦惠公";
        country8.primeMinister = "";
        country8.thoughtsRatio[0] = 25f; country8.thoughtsRatio[1] = 25f; country8.thoughtsRatio[2] = 25f; country8.thoughtsRatio[3] = 25f;
        country8.territory[0] = GameObject.Find("朝歌").transform;
        country8.territory[1] = GameObject.Find("城濮").transform;

        countries.Add(country1);
        countries.Add(country2);
        countries.Add(country3);
        countries.Add(country4);
        countries.Add(country5);
        countries.Add(country6);
        countries.Add(country7);
        countries.Add(country8);



    }


    public void GenerateCountryData()//Generate state name on countryPanel
    {
        foreach (CountryInfo country in countries)
            {
            Debug.Log("111");
                GameObject VerticalGroup = GameObject.Find("VerticalGroup");
                Object countryButton = Resources.Load("countryButton", typeof(GameObject));
                GameObject countryClickButton = Instantiate(countryButton) as GameObject;
                countryClickButton.transform.SetParent(VerticalGroup.transform, false);
                //Generate state name
                Transform Text = countryClickButton.transform.GetChild(0);
                Text.GetComponent<UnityEngine.UI.Text>().text = country.state;

                //generate data

            }
   
   
    }
    public void GenerateCountryDetailedInfo(string statename)
    {
        Debug.Log("Detail");
        //Left Move the countryListPanel

        //Generate countryInfo Panel
        Object countryInfoPanel = Resources.Load("countryInfo", typeof(GameObject));
        GameObject InfoPanel = Instantiate(countryInfoPanel) as GameObject;
        InfoPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);


        //acquire Text transform
        Transform PMText = InfoPanel.transform.GetChild(0);
        Transform ThoughtsText = InfoPanel.transform.GetChild(1);
        foreach (CountryInfo country in countries)
        {
            if (country.state == statename)
            {
                string king = country.king;
                string PM = country.primeMinister;
                float Ru = country.thoughtsRatio[0];
                float Dao = country.thoughtsRatio[1];
                float Fa = country.thoughtsRatio[2];
                float Mo = country.thoughtsRatio[3];
                InfoPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = king;
                InfoPanel.transform.GetChild(1).GetComponent<UnityEngine.UI.Text>().text = PM;
                //Generate thoughts data
                InfoPanel.transform.GetChild(2).GetComponent<UnityEngine.UI.Text>().text = Ru.ToString();
                InfoPanel.transform.GetChild(3).GetComponent<UnityEngine.UI.Text>().text = Dao.ToString();
                InfoPanel.transform.GetChild(4).GetComponent<UnityEngine.UI.Text>().text = Fa.ToString();
                InfoPanel.transform.GetChild(5).GetComponent<UnityEngine.UI.Text>().text = Mo.ToString();
                //Get ScreenAxis of territory
                Vector3 territoryAxis = country.territory[0].transform.position;
                Vector3 screenAxis = Camera.main.WorldToScreenPoint(territoryAxis);
                if (screenAxis.x > Screen.width/2){
                   float distance_X = (screenAxis.x - Screen.width / 2)/160;
                    Debug.Log(distance_X);
                    MainCamera.transform.DOMoveX(MainCamera.transform.position.x+distance_X, 2);
                }
                if(screenAxis.x < Screen.width/2){
                    float distance_X = (Screen.width / 2 - screenAxis.x) / 160;

                    MainCamera.transform.DOMoveX(MainCamera.transform.position.x - distance_X, 2);
                }
                if (screenAxis.y > Screen.height / 2){
                    float distance_Y = (screenAxis.y - Screen.height / 2) / 160;
                    MainCamera.transform.DOMoveY(MainCamera.transform.position.y+distance_Y,2);
                }
                if(screenAxis.y < Screen.height /2){
                    float distance_Y = (Screen.height / 2 - screenAxis.y) / 160;
                    MainCamera.transform.DOMoveY(MainCamera.transform.position.y - distance_Y,2);
                }

                    
             
              // if (country.territory == null) Debug.Log("123dfsdfsfsd");
              //  MainCamera.transform.DOMoveX(1, 2);

            }

        }



    }



}
