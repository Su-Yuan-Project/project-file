using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoguePanelController : MonoBehaviour
{
    int num;
    string peopleName;
    string king;    //国君的名字
    string shilu;
    string country;
    string str = "先生来了，赐座";
    string s = "";
    float[] ratio = new float[4];
    public GameObject ChineseMap;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        ChineseMap = GameObject.Find("ChineseMap");
        //获取君主姓名
        num = GameObject.Find("ZhuZi(Clone)").transform.GetComponent<ZhuziPanelController>().num;
        peopleName = GameObject.Find("ZhuZi(Clone)").transform.GetComponent<ZhuziPanelController>().peopleName[num];
        country = GameObject.Find("ZhuZi(Clone)").transform.GetComponent<ZhuziPanelController>().peopleCountry[num];
        Debug.Log(country);
        List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;
        foreach (CountryInfo coun in countries)
        {
            if (coun.state == country)
            {
                king = coun.king;
            }
        }
        GameObject.Find("KingName").transform.GetComponent<UnityEngine.UI.Text>().text = king;
        text = GameObject.Find("DialogueText").transform.GetComponent<Text>();
        if (peopleName == "孔丘") 
        PlayText();
        if(peopleName == "子贡")
        {
            str = "是孔丘的高足？有何见解？";
            PlayText();
        }
        
        
    }
    public void RenYIButton()
    {
        if (peopleName == "孔丘" && king == "齐桓公")
        {
            str = "先生不负盛名，言之有理，不过现实实行起来怕是不能如先生所愿";
            List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;
            foreach (CountryInfo coun in countries)
            {
                if (coun.state == country)
                {
                    coun.thoughtsRatio[0] += 2;
                    coun.thoughtsRatio[3] -= 2;
                }
            }

        }
        if (peopleName == "孔丘"&&king =="鲁昭公")
        {
            str = "先生说的有道理，寡人会认真考虑";
            List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;
            foreach (CountryInfo coun in countries)
            {
                if (coun.state == country)
                {
                    coun.thoughtsRatio[0] += 2;
                    coun.thoughtsRatio[3] -= 2;
                }
            }
            if (peopleName == "子贡"){
                str = "先生所言并非无理";
            }
        } 
        text.text = "";
        PlayText();
    }
    public void jianaiButton()
    {
        if (peopleName == "孔丘" && king == "齐桓公")
        {
            str = "先生可和我的相国管仲谈论一下";
            List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;

        }
        if (peopleName == "孔丘"&& king == "鲁昭公")
        {
            str = "先生竟然会说出这样的逻辑，简直不可理喻";
            List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;

        }
        if (peopleName == "子贡"&& king == "鲁昭公")
        {
            str = "这是孔丘的弟子...你可以被逐出师门了";
        }
        text.text = "";
        PlayText();
    }
    public void FaButton()
    {
        if (peopleName == "孔丘"&& king == "鲁昭公")
        {
            str = "没想到先生竟会崇尚刑法，真是活久见";
            List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;

        }
        if (peopleName == "孔丘" && king == "齐桓公"){
            str = "久闻先生大名，说是崇尚仁义，今天倒是让寡人意外了";
            List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;
            
        }
        if (peopleName == "子贡"&& king == "鲁昭公")
        {
            str = "你最好走远点";
        }
        text.text = "";
        PlayText();
    }
    public void DaoButton()
    {
        if (peopleName == "孔丘" && king == "齐桓公")
        {
            str = "久闻先生大名，先生远道而来，说什么寡人都洗耳恭听";
            List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;

        }
        if(peopleName == "孔丘"&& king == "鲁昭公")
        {
            str = "听说先生曾师从老子，那今天说出这样的话也就不足为奇了";
            List<CountryInfo> countries = ChineseMap.transform.GetComponent<CountryManager>().countries;
        }
        if (peopleName == "子贡"&& king == "鲁昭公")
        {
            str = "来人...轰出去";
        }
        text.text = "";
        PlayText();
    }
    private void PlayText()
    {
        Debug.Log(str.Length);
        StartCoroutine(ShowText(str.Length));
    }

    IEnumerator ShowText(int strLength)
    {
        s = "";
        int i = 0;
        while (i < strLength)
        {
            yield return new WaitForSeconds(0.05f);
            s += str[i].ToString();
            text.text = s;
            i += 1;
        }
        //显示完成，停止所有协成
        StopAllCoroutines();
    }

    void Update()
    {
        
    }
}
