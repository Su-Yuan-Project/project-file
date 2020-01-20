using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class teachingInitialize : MonoBehaviour
{
    public string Name;
    public string Site;
    public string[] prentice;                   //师父的所有徒弟
    public List <string> teachablePeople;       //可以授课的对象，要求是徒弟且和师父在同一地区
    public string teachingType;
    public int selected = 0;
    public List<string> selectedPerson;         //玩家选中进行讲学的对象，暂定只能六个
    private string[] Question = new string[3];  //问的问题

    public bool QuestionAsk = false;
    public string QuestionTitle;
    public GameObject []ThreeTopic = new GameObject[3];
    public bool hasCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        Question[0] = "谈谈你们的志向";
        Question[1] = "有没有可以终身奉行的行为呢？";
        Question[2] = "如何平衡理想与现实？";
        Name = GameObject.Find("ZhuZi(Clone)").transform.GetComponent<ZhuziPanelController>().choosePeople;
        List<peopleInfo> Peoples = GameObject.Find("ChineseMap").transform.GetComponent<PeopleManager>().Peoples;
        List<peopleInfo> AI = GameObject.Find("ChineseMap").transform.GetComponent<PeopleManager>().AI;
        foreach(peopleInfo people in Peoples){
            if (people.name == Name) 
            { 
                Site = people.country; 
            }
        }
        //到使者序列中查找
        foreach(peopleInfo people in Peoples)
        {
            if(people.master==Name&&people.country==Site){
                teachablePeople.Add(people.name);
            }
        }
        //到AI序列中查找

        foreach (peopleInfo people in AI)
        {
            if (people.master == Name && people.country == Site) teachablePeople.Add(people.name);
        }
        //生成肖像

        for (int i = 0; i < teachablePeople.Count;i++){
            Object MissionPanel = Resources.Load(teachablePeople[i]+"btn", typeof(GameObject));
            GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
            missionPanel.transform.SetParent(this.transform, false);
            missionPanel.transform.position = GameObject.Find("PS" + i.ToString()).transform.position;
        }
        if (teachablePeople.Count == 0) 
            GameObject.Find("prompt").transform.GetComponent<UnityEngine.UI.Text>().text = "尚未收徒，无授课对象！";



    }
    public void initializePortrait()
    {
        List<peopleInfo> Peoples = GameObject.Find("ChineseMap").transform.GetComponent<PeopleManager>().Peoples;
        foreach (peopleInfo people in Peoples)
        {
            if (people.name == Name)
            {
                prentice = new string[people.apprentices.Count];   //徒弟
                for (int i = 0; i < people.apprentices.Count; i++)
                {
                    prentice[i] = people.apprentices[i];
                    Object MissionPanel = Resources.Load(prentice[i], typeof(GameObject));
                    GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
                    missionPanel.transform.SetParent(this.transform, false);
                    missionPanel.transform.position = GameObject.Find("P" + i.ToString()).transform.position;
                    GameObject.Find("name" + i.ToString()).GetComponent<UnityEngine.UI.Text>().text = prentice[i];
                }
            }

        }
        if(teachingType == "修身")
        {

           
                Object MissionPanel = Resources.Load("teachingContent", typeof(GameObject));
                GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
                missionPanel.transform.SetParent(this.transform, false);
                missionPanel.transform.GetChild(0).transform.GetComponent<UnityEngine.UI.Text>().text = "人而不仁，如礼何？";
                missionPanel.transform.position = GameObject.Find("TC1").transform.position;

                Object MissionPanel1 = Resources.Load("teachingContent", typeof(GameObject));
                GameObject missionPanel1 = Instantiate(MissionPanel) as GameObject;
                missionPanel1.transform.SetParent(this.transform, false);
                missionPanel1.transform.GetChild(0).transform.GetComponent<UnityEngine.UI.Text>().text = "可为禽兽乎?";
                missionPanel1.transform.position = GameObject.Find("TC2").transform.position;

                Object MissionPanel2 = Resources.Load("teachingContent", typeof(GameObject));
                GameObject missionPanel2 = Instantiate(MissionPanel) as GameObject;
                missionPanel2.transform.SetParent(this.transform, false);
                missionPanel2.transform.GetChild(0).transform.GetComponent<UnityEngine.UI.Text>().text = "说说老师的为人";
                missionPanel2.transform.position = GameObject.Find("TC3").transform.position;
           
            
        }

    }
    public void selectPeople()
    {
        if (selected < 6) 
        {
            selected++;GameObject.Find("selectNumber").transform.GetComponent<UnityEngine.UI.Text>().text = selected.ToString() + "/6";
        }

    }

     public void closePanel()
       
      {
        Destroy(this.gameObject);
      }
    public void teachingClick()
    {
        Debug.Log("34555");
    }
    public void Enterteaching()
    {
        if (GameObject.Find("chooseteaching").transform.GetComponent<UnityEngine.UI.Text>().text == "开始讲学！")
        {
            GameObject.Find("chooseteaching").SetActive(false);
            GameObject.Find("selectNumber").SetActive(false);

            for (int i = 0; i < 6; i++)
            {
                GameObject personBtn = GameObject.Find(selectedPerson[i]);
                personBtn.transform.DOMove(GameObject.Find("P" + i.ToString()).transform.position, 1);
                personBtn.transform.GetComponent<CanvasGroup>().alpha = 1;
            }
            //关闭未选中的徒弟object
            foreach (string pr in teachablePeople)
            {
                if (GameObject.Find(pr + "btn(Clone)").transform.GetComponent<darkle>().activeOrNot == true)
                {
                    GameObject.Find(pr + "btn(Clone)").SetActive(false);
                }
            }
            for (int i = 0; i < 3;i++)
            {
                //生成三个讨论问题
                Object SetObject = Resources.Load("teachingContent", typeof(GameObject));
                GameObject missionButtonPanel = Instantiate(SetObject) as GameObject;
                ThreeTopic[i] = missionButtonPanel;
                missionButtonPanel.transform.SetParent(this.transform, false);
                missionButtonPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = Question[i];
                missionButtonPanel.transform.position = GameObject.Find("Q" + i.ToString()).transform.position;
            }
           

        }
        else
            return;
            
    }
    public void Update()
    {
        if (selected == 6) {
            GameObject.Find("chooseteaching").GetComponent<Text>().text = "开始讲学！";
            selected = 0;
        }
        if(hasCompleted == true)
        {
            ;
        }

        if (QuestionAsk == true)
        {
            QuestionAsk = false;
            GameObject.Find(selectedPerson[0]).transform.GetComponent<darkle>().answer_Seq = 0;
            GameObject.Find(selectedPerson[0]).transform.GetComponent<darkle>().answered = true;
            GameObject.Find(selectedPerson[1]).transform.GetComponent<darkle>().answer_Seq = 1;
            GameObject.Find(selectedPerson[1]).transform.GetComponent<darkle>().answered = true;
            GameObject.Find(selectedPerson[2]).transform.GetComponent<darkle>().answer_Seq = 2;
            GameObject.Find(selectedPerson[2]).transform.GetComponent<darkle>().answered = true;
            GameObject.Find(selectedPerson[3]).transform.GetComponent<darkle>().answer_Seq = 3;
            GameObject.Find(selectedPerson[3]).transform.GetComponent<darkle>().answered = true;
            GameObject.Find(selectedPerson[4]).transform.GetComponent<darkle>().answer_Seq = 4;
            GameObject.Find(selectedPerson[4]).transform.GetComponent<darkle>().answered = true;
            GameObject.Find(selectedPerson[5]).transform.GetComponent<darkle>().answer_Seq = 5;
            GameObject.Find(selectedPerson[5]).transform.GetComponent<darkle>().answered = true;

        }
    }
	// Update is called once per frame

}
