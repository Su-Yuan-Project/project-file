using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeChange : MonoBehaviour
{
    public Text text ;
    public GameObject cardFrame;
    public GameObject ChineseMap;
    private int Age = 500;
    List<peopleInfo> peoples;

    // Start is called before the first frame update
    void Start()
    {
        text = this.transform.GetComponent<UnityEngine.UI.Text>();
        ChineseMap = GameObject.Find("ChineseMap");
       peoples = ChineseMap.transform.GetComponent<PeopleManager>().Peoples;
    }

    // Update is called once per frame
    public void TimeChange()
    {
        //获取当前年代
        Age--;
        text .GetComponent<UnityEngine.UI.Text>().text = "BC" + Age.ToString() ;
     


    }
    public void yearOldChange()
    {
        for (int i = 0; i < 10;i++){
            GameObject Frame = cardFrame.transform.GetChild(i + 1).gameObject;
            if (Frame.transform.childCount == 0) return;
            else {
                Transform Card = Frame.transform.GetChild(0);
                Transform old = Card.GetChild(0).GetChild(1);
                //获取目前年龄
                string last_Old = old.GetComponent<UnityEngine.UI.Text>().text;
                float floatLast_old = float.Parse(last_Old);
                int new_old = (int)floatLast_old+1;
                old.GetComponent<UnityEngine.UI.Text>().text = new_old.ToString();
            }
        }
    }

}
