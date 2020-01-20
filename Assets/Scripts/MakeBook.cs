using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeBook : MonoBehaviour
{
    public Slider slider;
    //获取peopleManager
    public string Name;
    Text text;
    string s = "";
    string word="";
    string[] firstday = new string[2];
    string[] seconday = new string[2];
    string[] thirday = new string[2];
    string[] forthday = new string[2];
    string[] fifthday = new string[2];
    string[] sixthday = new string[2];
    string[][] words = new string[6][] ;
    string[] Booklevel = new string[4];
    string[] nameA = {"春","左","夏","令","公","青","楚","海","灵","论"};
    string[] nameB = { "语", "辞", "秋", "子", "传", "穹", "语", "辞", "典", "事" };
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("content").transform.GetComponent<Text>();
        words[0] = firstday;words[1] = seconday;words[2] = thirday;words[3] = forthday;words[4] = fifthday;words[5] = sixthday;
        firstday[0] = "写点什么好呢？得寻思寻思";
        firstday[1] = "不知道从何写起，看看前人写的竹简寻找一下灵感吧，不过学而不思则惘，死而不学则怠";
        seconday[0] ="子曾经曰过...哪个子...我以后也会是个子...吾当奋起直追，自勉励之！";
        seconday[1] = "没有头绪，心情烦躁...礼崩乐坏的世界,吾辈可令复兴，吾自当奋勇向前";
        thirday[0] = "上古先贤的智慧遭到废弃，真是令人痛心疾首！这群人还在这里为了一些小事叽叽喳喳！大好的年华被这样浪费！痛心疾首！痛心疾首！";
        thirday[1] ="道法自然，天地合一，这些学说并非一无是处，但是需要以仁义为基石，天地不仁，以万物为刍狗";
        forthday[0] = "写书也是一种修行，我所受到的痛苦和上古先贤相比又算得了什么呢？天将降大任于是人也，必先苦其心志，饿其筋骨，劳其体肤，空乏其身，行拂乱其所为，所以动心忍性，增益其所不能";
        forthday[1] ="人生漫漫，宇宙无疆，伏远地阔，我行天地间";
        fifthday[0] = "快要收尾了，几千年后的人们读到这里，怕也是会被我的思想震撼到吧";
        fifthday[1] ="今天吃了蒸鱼，想当年这可是只有周天子才能吃到的食物，礼崩乐坏,礼崩乐坏..掌嘴";
        sixthday[0] ="世界如此美好，我却如此暴躁，这样不好不好...我伟大的著作，愿思想传诸后世";
        sixthday[1] ="写完了，又是一份学术垃圾";
        Booklevel[0] = "学术垃圾";
        Booklevel[1] = "老生常谈";
        Booklevel[2] = "传世之作";
        Booklevel[3] = "华夏经典";
        Name = GameObject.Find("ZhuZi(Clone)").transform.GetComponent<ZhuziPanelController>().choosePeople;
        List<peopleInfo> Peoples = GameObject.Find("ChineseMap").transform.GetComponent<PeopleManager>().Peoples;
        GameObject.Find("writer").GetComponent<UnityEngine.UI.Text>().text = Name;
        foreach(peopleInfo people in Peoples)
        {
            if(people.name==Name)
            {
                foreach (Books book in people.books)
                {
                    string ss = GameObject.Find("complete").transform.GetComponent<Text>().text;
                    GameObject.Find("complete").transform.GetComponent<Text>().text = ss + book.name;
                }
                if (people.bookWriting == false) { people.bookWriting = true; people.bookpercent = 0;GameObject.Find("percent").transform.GetComponent<UnityEngine.UI.Text>().text = people.bookpercent.ToString() + "%"; }
               
                else
                {
                    people.bookpercent += Random.Range(0, 20);
                    // people.bookpercent += 20;
                    if (people.bookpercent < 100) { GameObject.Find("percent").transform.GetComponent<UnityEngine.UI.Text>().text = people.bookpercent.ToString() + "%"; slider.value = people.bookpercent;}
                    else {
                           GameObject.Find("percent").transform.GetComponent<UnityEngine.UI.Text>().text = "著书完成"; 
                           Object SetObject = Resources.Load("BookComplete", typeof(GameObject));
                           GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
                           GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
                           int firstName = Random.Range(0, 10); int lastName = Random.Range(0, 10);int titleRandom = Random.Range(0, 4);
                           GameSetPanel.transform.GetChild(1).GetComponent<Text>().text = nameA[firstName] + nameB[lastName];
                           GameSetPanel.transform.GetChild(2).GetComponent<Text>().text = Booklevel[titleRandom];
                           //向数据库中插入书
                           Books newbook = new Books();newbook.name = nameA[firstName] + nameB[lastName]; newbook.title = Booklevel[titleRandom];
                           people.books.Add(newbook);
                           people.bookWriting = false;
                           Destroy(this.gameObject);
                         }
                }
                int a = Random.Range(0, 2);
                if(a==0){
                    word = words[people.bookpercent / 20][0];
                    PlayText();
                }
                else{
                    word = words[people.bookpercent / 20][1];
                    PlayText();
                }
            }
           
        }
        Object MissionPanel = Resources.Load(Name, typeof(GameObject));
        GameObject missionPanel = Instantiate(MissionPanel) as GameObject;
        missionPanel.transform.SetParent(this.transform, false);
        missionPanel.transform.position = GameObject.Find("BookSite").transform.position;
   
    }
    private void PlayText()
    {

        StartCoroutine(ShowText(word.Length));
    }

    IEnumerator ShowText(int strLength)
    {
        s = "";
        int i = 0;
        while (i < strLength)
        {
            yield return new WaitForSeconds(0.05f);
            s += word[i].ToString();
            text.text = s;
            i += 1;
        }
        //显示完成，停止所有协成
        StopAllCoroutines();
    }

    public void panelClose()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
