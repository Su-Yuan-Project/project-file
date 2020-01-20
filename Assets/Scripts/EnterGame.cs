using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Transform[] cardFrame = new Transform[6];
    public GameObject cardContainer;
    // Start is called before the first frame update
    void Start()
    {
        cardFrame[0] = GameObject.Find("Frame2").transform;
        cardFrame[1] = GameObject.Find("Frame3").transform;
        cardFrame[2] = GameObject.Find("Frame4").transform;
        cardFrame[3] = GameObject.Find("Frame5").transform;
        cardFrame[4] = GameObject.Find("Frame6").transform;
        cardFrame[5] = GameObject.Find("Frame7").transform;
    }
    public void Enter500()
    {
        Object SetObject = Resources.Load("chooseCard500", typeof(GameObject));
        GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
        GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
        Destroy(GameObject.Find("ChooseAge(Clone)"));
        Destroy(GameObject.Find("Start"));
        Destroy(GameObject.Find("Start(Clone)"));
    }
    public void Enter200()
    {
        Object SetObject = Resources.Load("chooseCard200", typeof(GameObject));
        GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
        GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
        Destroy(GameObject.Find("ChooseAge(Clone)"));
        Destroy(GameObject.Find("Start"));
        Destroy(GameObject.Find("Start(Clone)"));
    }
    public void newGame()
    {
        Object SetObject = Resources.Load("ChooseAge", typeof(GameObject));
        GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
        GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
    }
    public void enter()
    {
        Destroy(GameObject.Find("chooseCard500(Clone)").gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
