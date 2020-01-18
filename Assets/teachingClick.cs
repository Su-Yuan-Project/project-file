using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class teachingClick : MonoBehaviour
{
    
    public GameObject teachingPanel;
    public float time_i;
    public GameObject[] threetopic = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        teachingPanel = GameObject.Find("teaching(Clone)");
        time_i = 0;
        threetopic[0] = GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().ThreeTopic[0];
        threetopic[1] = GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().ThreeTopic[1];;
        threetopic[2] = GameObject.Find("teaching(Clone)").transform.GetComponent<teachingInitialize>().ThreeTopic[2];;
    }
	private void Update()
	{
        time_i += Time.deltaTime;
       

	}

	public void teachClick()
    {

        if (this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "谈谈你们的志向")
        {
            teachingPanel.transform.GetComponent<teachingInitialize>().QuestionTitle = "谈谈你们的志向";
            this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "倾向谁说的就点击谁...";
            teachingPanel.transform.GetComponent<teachingInitialize>().QuestionAsk = true;
            GameObject.Find("prompt").transform.GetComponent<UnityEngine.UI.Text>().text = "点击人物肖像进行互动～";
            threetopic[0].SetActive(false);
            threetopic[1].SetActive(false);
            threetopic[2].SetActive(false);

        }

        if (this.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text == "")
        {
           
        }
    }
}
