using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZhuziPanelController : MonoBehaviour
{
    List<peopleInfo> People;
    public string[] peopleName ;
   public  string[] peopleCountry;
   public  string[] peopletitle;
   public  string[] shilu;
    public string choosePeople;
    public GameObject picture;

    public int num;
    int People_Count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InitializeData()
    {
        num = 0;
        People = GameObject.Find("ChineseMap").transform.GetComponent<PeopleManager>().Peoples;
        People_Count = People.Count;
        peopleName = new string[People.Count];
        peopleCountry = new string[People.Count];
        peopletitle = new string[People.Count];
        shilu = new string[People.Count];
        int i = 0;
        foreach(peopleInfo people in People)
        {
            peopleName[i] = people.name;
            peopletitle[i] = people.title;
            peopleCountry[i] = people.country;
            shilu[i] = people.country;
            i++;
        }
        GameObject.Find("title").GetComponent<UnityEngine.UI.Text>().text  = peopletitle[num];
        GameObject.Find("shilu").GetComponent<UnityEngine.UI.Text>().text = peopleCountry[num];
        GameObject.Find("PeopleName").GetComponent<Text>().text = peopleName[num];
        Object MissionPanel = Resources.Load(peopleName[num], typeof(GameObject));
        GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
        missionPanel.transform.SetParent(this.transform, false);
        missionPanel.transform.position = GameObject.Find("portraitSite").transform.position;
        picture = missionPanel;
        Debug.Log(People.Count);
    }

    public void Next()
    {
        if (num+1== People.Count)return;
        num++;
        GameObject.Find("title").GetComponent<UnityEngine.UI.Text>().text = peopletitle[num] ;
        GameObject.Find("shilu").GetComponent<UnityEngine.UI.Text>().text = peopleCountry[num];
        GameObject.Find("PeopleName").GetComponent<Text>().text = peopleName[num];
        Destroy(picture.gameObject);
        Object MissionPanel = Resources.Load(peopleName[num], typeof(GameObject));
        GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
        missionPanel.transform.SetParent(this.transform, false);
        missionPanel.transform.position = GameObject.Find("portraitSite").transform.position;
        picture = missionPanel;

    }
    public void Prev()
    {
        if (num == 0) return;
        num--;
        GameObject.Find("title").GetComponent<UnityEngine.UI.Text>().text = peopletitle[num];
        GameObject.Find("shilu").GetComponent<UnityEngine.UI.Text>().text = peopleCountry[num];
        GameObject.Find("PeopleName").GetComponent<Text>().text = peopleName[num];
        Destroy(picture.gameObject);
        Object MissionPanel = Resources.Load(peopleName[num], typeof(GameObject));
        GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
        missionPanel.transform.SetParent(this.transform, false);
        missionPanel.transform.position = GameObject.Find("portraitSite").transform.position;
        picture = missionPanel;
    }
    public void MissionClick()
    {
        choosePeople = peopleName[num];
        Debug.Log(choosePeople);
        if (GameObject.Find("Mission(Clone)") == false)
        {
            Object MissionPanel = Resources.Load("Mission", typeof(GameObject));
            GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
            missionPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);

        }
    }
}
