using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Books
{
    public string name;
    public string title;
}
public class peopleInfo
{
    public string name;
    public string old;
    public string title;
    public string country;
    public float[] thoughtsRatio;
    public int bookpercent;    //当前书完成进度
    public bool bookWriting;   //是否正在写书
    public List<Books> books = new List<Books>();  //写完的书
    public List<string> apprentices = new List<string>();   //徒弟列表
    public string master;                //师父

}
public class PeopleManager : MonoBehaviour
{
    
    public List<peopleInfo> Peoples = new List<peopleInfo>();
    public List<peopleInfo> AI = new List<peopleInfo>();
    // Start is called before the first frame update
    void Start()
    {
        //孔子
        peopleInfo people1 = new peopleInfo();
        people1.name = "孔丘";
        people1.old = "53";
        people1.title = "中都宰";
        people1.country = "鲁";
        people1.bookWriting = false;
        people1.thoughtsRatio = new float[4] { 70, 0, 10, 10 };
        people1.apprentices.Add("子贡"); people1.apprentices.Add("仲由");
        people1.apprentices.Add("颜回");people1.apprentices.Add("冉雍");
        people1.apprentices.Add("冉耕");people1.apprentices.Add("孔及");
        //zigong
        peopleInfo people2 = new peopleInfo();
        people2.name = "子贡";
        people2.old = "38";
        people2.title = "中尉";
        people2.country = "鲁";
        people2.bookWriting = false;
        people2.thoughtsRatio = new float[4] { 60, 10, 10, 10 };
        people2.master = "孔丘";
        //zhongyou
        peopleInfo people3 = new peopleInfo();
        people3.name = "仲由";
        people3.old = "54";
        people3.title = "执戟";
        people3.country = "鲁";
        people3.master = "孔丘";
        people3.bookWriting = false;
        people3.thoughtsRatio = new float[4] { 50, 10, 20, 10 };
        peopleInfo people4 = new peopleInfo();
        people4.name = "颜回";
        people4.old = "36";
        people4.title = "平民";
        people4.country = "鲁";
        people4.master = "孔丘";
        people4.bookWriting = false;
        peopleInfo people5 = new peopleInfo();
        people5.name = "冉耕";
        people5.old = "42";
        people5.title = "平民";
        people5.country = "鲁";
        people5.master = "孔丘";
        people5.bookWriting = false;
        peopleInfo people6 = new peopleInfo();
        people6.name = "冉雍";
        people6.old = "44";
        people6.title = "平民";
        people6.country = "鲁";
        people6.master = "孔丘";
        people6.bookWriting = false;
        Peoples.Add(people1);
        Peoples.Add(people2);
        Peoples.Add(people3);
        Peoples.Add(people4);
        Peoples.Add(people5);
        Peoples.Add(people6);

        peopleInfo AI1 = new peopleInfo();
        AI1.name = "孔及";
        AI1.old = "18";
        AI1.title = "无";
        AI1.country = "鲁";
        AI1.master = "孔丘";
        AI1.bookWriting = false;
        AI.Add(AI1);


        peopleInfo AI2 = new peopleInfo();
        AI2.name = "有若";
        AI2.old = "32";
        AI2.title = "无";
        AI2.country = "鲁";
        AI2.master = "孔丘";
        AI2.bookWriting = false;
        AI.Add(AI2);


        peopleInfo AI3 = new peopleInfo();
        AI3.name = "子夏";
        AI3.old = "38";
        AI3.title = "无";
        AI3.country = "鲁";
        AI3.master = "孔丘";
        AI3.bookWriting = false;
        AI.Add(AI3);

    }

    // Update is called once per frame
    void Update()
    {




    }
}
