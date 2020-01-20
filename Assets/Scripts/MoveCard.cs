using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class MoveCard : MonoBehaviour
{
    private int[] cardArray = new int[8];
    private int cardAdded = 0;
    //卡牌中心位置
    private float posX;//中心点位置
    private float posY;
    private float distance;//两张卡牌之间的间距
    private int cardNumber = 8; 
    public GameObject cardContainer;
    public GameObject CardGroup;
    public GameObject AddText;
    public GameObject contentText;
    public GameObject shezheChoose;
    string ZiGong;
    string ZiLU;
    string youRuo;
    string ZiXia;
    string RanYong;
    string RanGeng;
    string Yanhui;
    string Kongji;
    string HanFei;
    string Shangyang;
    string Sunbin;
    string Pangjuan;
    string SuQin;
    string Zhangyi;
    string Zhuangzi;
    string Mozi;
	public void Start()
	{
        cardArray[0] = 1;
        cardArray[1] = 0;
        cardArray[2] = 0;
        cardArray[3] = 0;
        cardArray[4] = 0;
        cardArray[5] = 0;
        cardArray[6] = 0;
        cardArray[7] = 0;
        posX = GameObject.Find("CardGroup").transform.GetChild(0).transform.position.x;
        posY = GameObject.Find("CardGroup").transform.GetChild(0).transform.position.y;
        float x = GameObject.Find("CardGroup").transform.GetChild(1).transform.position.x;
        distance = x - posX;
        ZiGong = "端木赐（BC520年－BC456年），复姓端木，字子贡），以字行。华夏族,孔门十哲之一。子贡在孔门十哲中以言语闻名，利口巧辞，善于雄辩，且有干济才，办事通达，曾任鲁国、卫国之相。他还善于经商之道，曾经经商于曹国、鲁国两国之间，富致千金，为孔子弟子中首富。";
        ZiLU = "仲由（BC542年―BC480年），字子路，又字季路，鲁国人。受儒家祭祀。仲由性情刚直，好勇尚武，曾陵暴过孔子，孔子对他启发诱导，设礼以教，子路接受孔子的劝导，请为弟子，跟随孔子周游列国，做孔子的侍卫。为人伉直，好勇力，任内开挖沟渠，救穷济贫，政绩突出，辖域大治。";
        youRuo = "有若（BC508年或前518年—？），字子有（一说字子若），世称“有子”，孔子弟子，孔门七十二贤之一，被尊为儒学圣贤。";
        ZiXia = "卜商（BC507年—BC400年），姬姓，卜氏，名商，字子夏），南阳温邑人。春秋末期思想家、教育家，孔门十哲之一,阴郁勇武，好与贤己者处。求学于孔子，以“文学”著称，名列孔门七十二贤人，是一位具有独创颇有经世倾向的思想家。";
        RanYong = "冉雍（BC522年—？），字仲弓，春秋末期鲁国人，孔子弟子。少昊之裔，周文王之子曹叔振铎数传至冉离，世居“菏泽之阳”，人称“犁牛氏”，受儒教祭祀";
        RanGeng = "冉耕（BC544年—？），字伯牛，春秋末年鲁国人，孔子弟子。为孔门四科“德行”代表人物之一，受儒教祭祀。后患恶疾，孔子亲往探望，见其垂危，深为叹惜。";
        Yanhui = "颜回（BC521年—BC481年），曹姓，颜氏，名回，字子渊，鲁国人，居陋巷尊称复圣颜子，春秋末期鲁国思想家，孔门七十二贤之首。十三岁拜孔子为师，终生师事之，是孔子最得意的门生。孔子对颜回称赞最多，赞其好学仁人。";
        Kongji = "孔伋，字子思，孔子的嫡孙、孔子之子孔鲤的儿子。大约生于周敬王三十七年（公元前483年），卒于周威烈王二十四年（公元前402年），享年82岁。中国春秋时期著名的思想家。受教于孔子的高足曾参，孔子的思想学说由曾参传子思，子思的门人再传孟子。";
        HanFei = "韩非（约BC280年—BC233年），又称韩非子，新郑人，战国时期杰出的思想家、哲学家和散文家，法家代表人物。";
        Shangyang = "商鞅辅佐秦孝公，积极实行变法，使秦国成为富裕强大的国家，史称“商鞅变法”。政治上，改革了秦国户籍、军功爵位、土地制度、行政区划、税收、度量衡以及民风民俗，并制定了严酷的法律；经济上，主张重农抑商、奖励耕战；军事上，统率秦军收复了河西之地，赐予商于十五邑，号为商君，史称为商鞅";
        Sunbin = "孙膑曾与庞涓为同窗，因受庞涓迫害遭受膑刑，身体残疾，后在齐国使者的帮助下投奔齐国，被齐威王任命为军师，辅佐齐国大将田忌两次击败庞涓，取得了桂陵之战和马陵之战的胜利，奠定了齐国的霸业。";
        Pangjuan = "庞涓，战国初期魏国名将。相传与孙膑同拜于隐士鬼谷子门下，因嫉妒孙膑的才能，恐其贤于己，因而设计把他的膝盖骨刮去。魏惠王二十八年，魏攻韩，次年齐救韩，采用孙膑策略，直趋魏都大梁，旋即退兵，诱使庞涓兼程追击，在马陵（今河南范县西南）中伏大败，涓智穷，大叹“遂叫竖子成名”，自刎而死";
        SuQin = "苏秦(?-BC284),早年投入鬼谷子门下，学习纵横之术。学成游历多年，潦倒而归。随后，刻苦攻读《阴符》，游说列国，得到燕文公赏识，出使赵国，提出“合纵”六国以抗秦的战略思想，并最终组建合纵联盟，任“从约长”，兼佩六国相印，使秦国十五年不敢出兵函谷关";
        Zhangyi = "张仪（？－BC309年），姬姓，张氏，名仪，魏国安邑人。魏国贵族后裔，战国时期著名的纵横家、外交家和谋略家。早年入于鬼谷子门下，学习纵横之术。出山之后，首创“连横”的外交策略，游说六国入秦。被秦惠王封为相国，奉命出使游说各国，以“横”破“纵”，受封为武信君。BC310年，秦武王继位。张仪出逃魏国，次年去世。";
        Zhuangzi = "庄子，战国中期思想家、哲学家、文学家。姓庄，名周，宋国蒙人 ，先祖是宋国君主宋戴公 。他是继老子之后道家学派的代表人物，创立了华夏重要的哲学学派——庄学。与老子并称“老庄”。";
        Mozi = "墨子（生卒年不详），名翟（dí），东周春秋末期战国初期宋国人，一说鲁阳人 ，一说滕国人。墨子是宋国贵族目夷的后代，生前担任宋国大夫。他是墨家学派的创始人，也是战国时期著名的思想家、教育家、科学家、军事家。";
    }
	public void Update()
	{
      
	}

	private void bigger(int id){//卡牌放大
        if (id == -1) return;
//        Debug.Log("id=" + id);
        Transform cardTransform = GameObject.Find("CardGroup").transform.GetChild(id);
        cardTransform.DOScale(new Vector3(1.3f, 1.3f, 0), 0.4f);
        cardTransform.DOMove(new Vector3(posX, posY, 0), 0.3f); 
        if (cardTransform.gameObject.name == "子贡") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = ZiGong;
        if (cardTransform.gameObject.name == "子路") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = ZiLU;
        if (cardTransform.gameObject.name == "子夏") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = ZiXia;
        if (cardTransform.gameObject.name == "孔砂") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = Kongji;
        if (cardTransform.gameObject.name == "颜回") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = Yanhui;
        if (cardTransform.gameObject.name == "冉耕") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = RanGeng;
        if (cardTransform.gameObject.name == "冉雍") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = RanYong;
        if (cardTransform.gameObject.name == "韩非") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = HanFei;
        if (cardTransform.gameObject.name == "苏秦") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = SuQin;
        if (cardTransform.gameObject.name == "张仪") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = Zhangyi;
        if (cardTransform.gameObject.name == "商鞅") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = Shangyang;
        if (cardTransform.gameObject.name == "庞涓") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = Pangjuan;
        if (cardTransform.gameObject.name == "孙膑") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = Sunbin;
        if (cardTransform.gameObject.name == "庄子") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = Zhuangzi;
        if (cardTransform.gameObject.name == "墨子") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = Mozi;
    }

    

    private void rightSmaller (int id)
    {
        Transform cardTransform = GameObject.Find("CardGroup").transform.GetChild(id);
        cardTransform.DOScale(new Vector3(0.8f, 0.8f, 0), 0.4f);
        cardTransform.DOMove(new Vector3(posX+distance,posY,0),0.3f);
    }
    private void leftSmaller (int id) 
    {
        Transform cardTransform = GameObject.Find("CardGroup").transform.GetChild(id);
        cardTransform.DOScale(new Vector3(0.8f, 0.8f, 0), 0.4f);
        cardTransform.DOMove(new Vector3(posX-distance,posY,0),0.3f);
    }

	public void OnRightClick()
    {
        foreach (int i in cardArray)
            Debug.Log(i);
        if (cardArray[cardNumber-1]!=0) {return;}
        else{
            for (int i = 0; i < cardNumber;i++){
                if(cardArray[i]==1){
                    bigger(i + 1);
                    leftSmaller(i);
                    cardArray[i] = 0;
                    cardArray[i + 1] = 1;
                   
                    break;
                }
               
            }
     
        }
    }

     public void OnLeftClick()
    {
        if (cardArray[0]!=0) return;
        else
        {
            for (int i = 0; i < cardNumber;i++)
            {
                if(cardArray[i]==1){
                    bigger(i - 1);
                    rightSmaller(i);
                    cardArray[i] = 0;
                    cardArray[i - 1] = 1;
                    break;
                }
            }
        }
    }
    public void AddCard()
    {
       
        if (cardAdded == 6) return;

        else
        {
            for (int i = 0; i < cardNumber;i++)
            {
                
                if(cardArray[i]==1)
                {
                    
                 
//                    Debug.Log("i123 = " + i);
                    Transform cardTransform = GameObject.Find("CardGroup").transform.GetChild(i).transform;
                    cardTransform.DOMove(new Vector3(cardTransform.position.x, cardTransform.position.y, 0), 0.3f);
                   // cardTransform.SetParent(cardContainer.transform);
                    //卡牌的目的位置
                    Transform objPlace = cardContainer.transform.GetChild(cardAdded);
                    Debug.Log("cardContainer="+cardAdded);
                    //移动卡牌
                    cardTransform.DOMove(new Vector3(objPlace.position.x, objPlace.position.y, 0), 0.3f);
                    cardTransform.DOScale(new Vector3(1f, 1f, 0), 0.4f);
                  //  if (cardTransform.gameObject.name == "子贡") contentText.transform.GetComponent<UnityEngine.UI.Text>().text = ZiGong;
                    if (i == cardNumber - 1)
                        bigger(i - 1);
                    else
                        bigger(i + 1);
                    //更改父物体
                    cardTransform.SetParent(cardContainer.transform);
                    //初始化数组
                    cardNumber--;
                    cardAdded++;
                   // Debug.Log(cardAdded);
                    cardArray = new int[cardNumber];
                    for (int j = 0; j < cardArray.Length; j++) cardArray[j] = 0;
//                    Debug.Log("i="+i);
               
                    if (cardNumber == 0) {
                        AddText.GetComponent<UnityEngine.UI.Text>().text = "已添加6/6";
                        shezheChoose.transform.GetComponent<UnityEngine.UI.Text>().text = "进入游戏";
                    
                    }

                    else
                    {
                        if (i == cardNumber ) { cardArray[i - 1] = 1; }
                        else  cardArray[i] = 1; 
                    }
                    if(cardAdded==6)
                    {
                        AddText.GetComponent<UnityEngine.UI.Text>().text = "已添加6/6";
                        shezheChoose.transform.GetChild(0).transform.GetComponent<UnityEngine.UI.Text>().text = "进入游戏";

                    }
                    else
                    AddText.GetComponent<UnityEngine.UI.Text>().text = "已添加"+cardAdded.ToString()+"/6";
                    break;


                }
            }
        }
    }
  
}
