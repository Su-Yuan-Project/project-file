using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateZhuZiData : MonoBehaviour
{
    private int peopleNumber;
    public GameObject cardFrame;
    public GameObject[] Portrait;
    List<peopleInfo> People;
    public string[] country;
    public string[] title;
    // Start is called before the first frame update
    void Start()
    {
        People = GameObject.Find("ChineseMap").transform.GetComponent<PeopleManager>().Peoples;
    }
    public void GeneratePortrait()
    {
        country = new string[People.Count];
        title = new string[People.Count];
        for (int i = 0; i < People.Count; i++)
        {
            country[i] = People[i].country;
            title[i] = People[i].title;
        }

       // GameObject.Find("title").transform.GetComponent<UnityEngine.UI.Text>().text = title[0];
        GameObject.Find("shilu").transform.GetComponent<UnityEngine.UI.Text>().text = country[0];
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
