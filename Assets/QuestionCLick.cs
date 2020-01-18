using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class QuestionCLick : MonoBehaviour
{
    // Start is called before the first frame update
    public string Name;
    public GameObject teachingPanel;
    void Start()
    {
        teachingPanel = GameObject.Find("teaching(Clone)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuestionClick()
    {
        Destroy(GameObject.Find("Q1").transform.GetChild(0).gameObject);
        Destroy(GameObject.Find("Q2").transform.GetChild(0).gameObject);
        if(this.transform.GetChild(0).transform.GetComponent<UnityEngine.UI.Text>().text=="赞同颜回")
        {
            Object SetObject = Resources.Load("bubble", typeof(GameObject));
            GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
            GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
            GameSetPanel.transform.position = GameObject.Find("颜回btn(Clone)").transform.GetChild(1).transform.position;
            GameSetPanel.transform.DOPunchPosition(new Vector3(0, 8, 0), 1, 30, 0.001f);
            GameSetPanel.transform.GetChild(0).transform.GetComponent<UnityEngine.UI.Text>().text = "天下大同,便不再需子路的勇气";
            //3秒后触发
            GameObject.Find("子贡btn(Clone)").GetComponent<darkle>().time_speaking(3, "颜回师兄可堪敬佩");
            GameObject.Find("仲由btn(Clone)").GetComponent<darkle>().time_speaking(6, "人生志向用好坏来论定未免偏颇");
            GameObject.Find("冉雍btn(Clone)").GetComponent<darkle>().time_speaking(9,"请问老师难道经商致富就是不义的吗？");
            GameObject.Find("冉雍btn(Clone)").GetComponent<darkle>().button_pop(12,2,"商人重利轻义!","经商未尝不可");
            Destroy(GameObject.Find("Q0").transform.GetChild(0).gameObject);
        }
        if (this.transform.GetChild(0).transform.GetComponent<UnityEngine.UI.Text>().text == "商人重利轻义!")
        {
            GameObject.Find("子贡btn(Clone)").GetComponent<darkle>().time_speaking(0, "商业也未必没有益处...");
            GameObject.Find("仲由btn(Clone)").GetComponent<darkle>().time_speaking(0, "商人大多为钻营取巧之徒");
            GameObject.Find("冉雍btn(Clone)").GetComponent<darkle>().time_speaking(3, "难道我和子贡也是钻营之徒吗?");
            GameObject.Find("冉耕btn(Clone)").GetComponent<darkle>().time_speaking(6, "你们的见识过于浅薄...");
            GameObject.Find("仲由btn(Clone)").GetComponent<darkle>().time_speaking(9, "你是在挑衅？");
            GameObject.Find("颜回btn(Clone)").GetComponent<darkle>().time_speaking(12, "大家不要吵架...和为贵");
            GameObject.Find("孔及btn(Clone)").GetComponent<darkle>().time_speaking(15, "萌新瑟瑟发抖...");
            Destroy(GameObject.Find("Q1").transform.GetChild(0).gameObject);
            Destroy(GameObject.Find("Q2").transform.GetChild(0).gameObject);
        }
        if (this.transform.parent == GameObject.Find("Q1"))
        {

        }
        if (this.transform.parent == GameObject.Find("Q2"))
        {

        }
    }
}
