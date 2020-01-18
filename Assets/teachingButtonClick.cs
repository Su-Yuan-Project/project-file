using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teachingButtonClick : MonoBehaviour
{
    string missionType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void TeachingButtonClick()
    {
        missionType = this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text;
        Debug.Log(missionType);
        GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().teachingType = missionType;
        GameObject.Find("XiuShen").SetActive(false);
        GameObject.Find("QiJia").SetActive(false);
        GameObject.Find("ZhiGuo").SetActive(false);
        GameObject.Find("PingTianXia").SetActive(false);
        GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().initializePortrait();

    }
}
