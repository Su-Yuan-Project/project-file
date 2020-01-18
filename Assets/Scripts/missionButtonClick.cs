using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class missionButtonClick : MonoBehaviour
{
    string missionType;
    List<peopleInfo> Peoples; 
    string peopleName;
    bool Xiushen = false;
    bool Qijia = false;
    bool Zhiguo = false;
    bool PingTianXia = false;

    // Start is called before the first frame update
    void Start()
    {
        Peoples = GameObject.Find("ChineseMap").transform.GetComponent<PeopleManager>().Peoples;
        missionType = this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text;
        peopleName = GameObject.Find("ZhuZi(Clone)").transform.GetComponent<ZhuziPanelController>().choosePeople;
    }
    public  void MissionGenerate()
    {
        if (missionType == "访问国君")
        {
            //清空列表
            int num = GameObject.Find("Mission(Clone)").transform.childCount;
            //  for (int i = 1; i < num;i++){
            //      GameObject.Find("Mission(Clone)").transform.GetChild(i).DOMoveX(-300,1);
            // }
            Object SetObject = Resources.Load("dialogue", typeof(GameObject));
            GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
            GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);

        }
        else if (missionType == "著书")
        {
            foreach (peopleInfo people in Peoples)
            {
                if (people.name == peopleName )
                {
          
                    if (people.bookWriting == false)
                    {
                        Object SetObject = Resources.Load("chooseWritten", typeof(GameObject));
                        GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
                        GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
                        GameSetPanel.transform.DOPunchPosition(new Vector3(0, 15, 0), 1, 50, 0.001f);
                    }
                    else
                    {
                        Object SetObject = Resources.Load("MakeBook", typeof(GameObject));
                        GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
                        GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
                    }
                    break;
                }
               

            }
        }
        else if(missionType == "讲学")
        {
            Object SetObject = Resources.Load("teaching", typeof(GameObject));
            GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
            GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
        }
        else if (missionType == "出游")
        {
            Object SetObject = Resources.Load("TravelTo", typeof(GameObject));
            GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
            GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
        }
    }
   
    // Update is called once per frame
    public void teachingButtonClick()
    {
        
    }
}
