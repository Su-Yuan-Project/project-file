using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class darkle : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private int selectedNumber;
    public bool activeOrNot = true;   //判断是否被选中
    private int RandomBubble;
    private float time_i = 4;        //选择授课对象界面生成气泡
    private string [] teachAnswer = new string[15];
    public float time_j = 10000; //控制气泡间隔，用于开始回答问题
    public float time_k = 10000; //用于限制时间触发对话
    public float time_q = 10000; //按钮弹出时间
    public bool answered = false; //回答触发
    public int answer_Seq = -1;//回答顺序
    public bool hasAnswered = false;
    private int bubbleTriggerTime;//气泡触发时刻
    private int buttonTriggerTime;//按钮触发时刻
    private string bubblecontent;//触发气泡的对话内容
    private string button_S1;    //按钮上的内容
    private string button_S2;
   
    public GameObject teachingPanel;
    public string Name;
    private int answerSeq;
    public GameObject Q0;//问题出现的位置,一共三个
    public GameObject Q1;//问题出现的位置,一共三个
    public GameObject Q2;//问题出现的位置,一共三个

    // Start is called before the first frame update
    void Start()
    {
      
      //  Debug.Log(s.Replace("ffff",""));
        Name = this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text;
        teachingPanel = GameObject.Find("teaching(Clone)");
        canvasGroup = this.GetComponent<CanvasGroup>();
        teachAnswer[0] ="学而时习之,不亦说乎?";
        teachAnswer[1] ="三人行必有我师焉";
        teachAnswer[2] ="择善而从，不善而改";
        teachAnswer[3] ="朝闻道，夕死可矣";
        teachAnswer[4] ="竹简再沉!刻字再难也不能阻挡我学习的脚步!";
        teachAnswer[5] ="我非生而知之者,敏以求之者也";
        teachAnswer[6] ="见贤思齐焉";
        teachAnswer[7] ="知之为知之，不知为不知";
        teachAnswer[8] ="学习使我成长,谦虚使人进步";
        teachAnswer[9] ="再来100斤竹简！";
        teachAnswer[10] ="逝者如斯夫，不舍昼夜";
        teachAnswer[11] ="人有不为也，而后可以有为";
        teachAnswer[12] ="竹简是人类进步的阶梯";
        teachAnswer[13] ="不学习就等着过程淘汰吧";
        teachAnswer[14] ="冲鸭！！！！";
        Q0 = GameObject.Find("Q0");
        Q1 = GameObject.Find("Q1");
        Q2 = GameObject.Find("Q2");


    }
    public  void Darkle()
    {
        selectedNumber = GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().selected;
        if (selectedNumber < 6&&activeOrNot==true)
        {
            GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().selectedPerson.Add(this.gameObject.name);
            activeOrNot = false;
            selectedNumber=++GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().selected;
            //selectedNumber = GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().selected++;
            canvasGroup.alpha = 0.3f;//
            GameObject. Find("selectNumber").transform.GetComponent<UnityEngine.UI.Text>().text = selectedNumber.ToString() + "/6";
        }
        else if(activeOrNot==false&&hasAnswered==true)//选中人物回答问题
        {
            //清楚所有已经生成的问题按钮
            if(Q0.transform.childCount!=0)Destroy(Q0.transform.GetChild(0).gameObject);  
            if(Q1.transform.childCount!=0)Destroy(Q1.transform.GetChild(0).gameObject);  
            if(Q2.transform.childCount!=0)Destroy(Q2.transform.GetChild(0).gameObject);  
            GameObject.Find("prompt").transform.GetComponent<UnityEngine.UI.Text>().text = "";
            for (int i = 0; i < 3;i++)
            {
                Object SetObject = Resources.Load("questionList", typeof(GameObject));
                GameObject missionButtonPanel = Instantiate(SetObject) as GameObject;
                missionButtonPanel.transform.SetParent(GameObject.Find("Q" + i.ToString()).transform, false);
                missionButtonPanel.transform.position = this.transform.position;
                missionButtonPanel.transform.DOMove(GameObject.Find("Q" + i.ToString()).transform.position, 1);
                if (i == 0) missionButtonPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "赞同"+Name;
                if (i == 1) missionButtonPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "反对"+Name;
                if (i == 2) missionButtonPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "讨论"+Name+"的观点";
            }
            //Destroy(GameObject.Find("questionList(Clone)").transform);
        }
        else
            return;
    }
    public void Answer()
    {
        hasAnswered = true;   //
        // Debug.Log(this.gameObject.name);
        string s = teachingPanel.transform.GetComponent<teachingInitialize>().QuestionTitle;
        Object MissionPanel = Resources.Load("bubble", typeof(GameObject));
        GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
        missionPanel.transform.SetParent(this.transform, false);
        missionPanel.transform.position = this.transform.GetChild(1).transform.position;
        missionPanel.transform.DOPunchPosition(new Vector3(0, 8, 0), 1, 30, 0.001f);
        if (s == "谈谈你们的志向" && this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "仲由")
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "我的理想是从军,用拳头伸张正义";
        if (s == "谈谈你们的志向" && this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "子贡")
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "我的理想是成为侠士,为和平奔走劝告";
        if (s == "谈谈你们的志向" && this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "颜回")
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "辅佐明主,教化百姓,愿永葆和平";
        if (s == "谈谈你们的志向" && this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "冉雍")
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "我乃商贾,富甲天下,便可施舍四方";
        if (s == "谈谈你们的志向" && this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "冉耕")
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "我愿跟着老师,继续老师的使命";
        if (s == "谈谈你们的志向" && this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "孔及")
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "我且先听各位师兄所言";
        if (s == "谈谈你们的志向" && this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "子夏")
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "学而优则仕,治国平天下";
        if (s == "谈谈你们的志向" && this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "有若")
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "我希望成为像老师一样的人";


    }
    public void button_pop(int time,int buttonNum, string s1, string s2)//最多生成三个应对
    {
        time_q = 0;
        buttonTriggerTime = time;
        button_S1 = s1;
        button_S2 = s2;

    }
    public void time_speaking(int time,string s) //time:触发产生气泡的时间，s:气泡的内容
    {
        time_k = 0;
        bubbleTriggerTime = time;
        bubblecontent = s;
    }
    // Update is called once per frame
    void Update()
    {
        time_k += Time.deltaTime;
        time_j += Time.deltaTime;
        time_q += Time.deltaTime;

        RandomBubble = Random.Range(0, 1500);
        time_i += Time.deltaTime;
        if (RandomBubble < 4&&time_i > 4&&activeOrNot==true) {     //人物选中
            time_i = 0;
            Object MissionPanel = Resources.Load("bubble", typeof(GameObject));
            GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
            missionPanel.transform.SetParent(this.transform, false);
            missionPanel.transform.position = this.transform.GetChild(1).transform.position;
            missionPanel.transform.DOPunchPosition(new Vector3(0, 8, 0), 1, 30, 0.001f);
            int Random_bubble = Random.Range(0,15);
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = teachAnswer[Random_bubble];
        }
        //判断是否触发回答
        if(answered==true){
            time_j = 0;
            answered = false;
        }
        if(time_j>answer_Seq*3 && time_j<10000)
        {
            time_j = 10000;
            Answer();
        }
        if(time_k > bubbleTriggerTime &&time_k < 10000)
        {
            time_k = 10000;
            Object MissionPanel = Resources.Load("bubble", typeof(GameObject));
            GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
            missionPanel.transform.SetParent(this.transform, false);
            missionPanel.transform.position = this.transform.GetChild(1).transform.position;
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = bubblecontent;
            missionPanel.transform.DOPunchPosition(new Vector3(0, 8, 0), 1, 30, 0.001f);
            if(this.transform.name =="孔及btn(Clone)") GameObject.Find("prompt").transform.GetComponent<UnityEngine.UI.Text>().text = " 颜回 师徒关系+3 \n 子贡 师徒关系+1\n 冉雍 师徒关系-2\n 冉耕 师徒关系-1";

        }
        if(time_q > buttonTriggerTime&&time_q<10000)
        {
            time_q = 10000;
            Object MissionPanel = Resources.Load("questionList", typeof(GameObject));
            GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
            missionPanel.transform.SetParent(GameObject.Find("Q1").transform, false);
            missionPanel.transform.position = this.transform.position;
            missionPanel.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = button_S1;
            missionPanel.transform.DOMove(GameObject.Find("Q0").transform.position,1);

            Object MissionPanel2 = Resources.Load("questionList", typeof(GameObject));
            GameObject missionPanel2 = Instantiate(MissionPanel2) as GameObject;
            missionPanel2.transform.SetParent(GameObject.Find("Q2").transform, false);
            missionPanel2.transform.position = this.transform.position;
            missionPanel2.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = button_S2;
            missionPanel2.transform.DOMove(GameObject.Find("Q1").transform.position, 1);




        }
      


    }

  
}
