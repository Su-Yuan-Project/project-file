using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManage : MonoBehaviour
{
    public string title;
    public int buttonNumber = 3;
    public float[] thoughtsRatio;
    public string shilu;
    public string peopleName;
    // Start is called before the first frame update
    void Start()
    {
        
        string text = GameObject.Find("title").transform.GetComponent<UnityEngine.UI.Text>().text;
        peopleName = GameObject.Find("ZhuZi(Clone)").GetComponent<ZhuziPanelController>().choosePeople;
        foreach(peopleInfo people in GameObject.Find("ChineseMap").transform.GetComponent<PeopleManager>().Peoples)
        {
            if(peopleName==people.name) {
                Debug.Log("10101");
                title = people.title;
                thoughtsRatio = people.thoughtsRatio;
                break;
            }
          
        }
        Debug.Log(peopleName);
        Object MissionPanel = Resources.Load(peopleName, typeof(GameObject));
        GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
        missionPanel.transform.SetParent(this.transform, false);
        missionPanel.transform.position = GameObject.Find("site").transform.position;
        Debug.Log(peopleName);
        Debug.Log("12333");
        InstantiateMissionbutton();
    }

    void InstantiateMissionbutton()
    {
        int Pos_y = 50;
   
        for (int i = 0; i < buttonNumber;i++)
        {
            Object SetObject = Resources.Load("missionButton", typeof(GameObject));
            GameObject missionButtonPanel = Instantiate(SetObject) as GameObject;
            missionButtonPanel.transform.SetParent(this.transform, false);
            if (i == 0) missionButtonPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "访问国君";
            if (i == 1) missionButtonPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "讲学";
            if (i == 2) missionButtonPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "著书";
            missionButtonPanel.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(-155, Pos_y);
            Pos_y -= 55;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
