using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGameAndGoBack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cardContainer;
    public Transform []cardFrame = new Transform[6];
    float timer = 0 ;
    float k;
    float p;
    void Start()
    {
        cardFrame[0] = GameObject.Find("Frame2").transform;
        cardFrame[1] = GameObject.Find("Frame3").transform;
        cardFrame[2] = GameObject.Find("Frame4").transform;
        cardFrame[3] = GameObject.Find("Frame5").transform;
        cardFrame[4] = GameObject.Find("Frame6").transform;
        cardFrame[5] = GameObject.Find("Frame7").transform;
    }
	
	public void goBacktoMainMenu()
    {
        Object SetObject = Resources.Load("Start", typeof(GameObject));
        GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
        GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
        Destroy(this.gameObject);
    }
    public void EnterGame()
    {
       // Destroy(this.gameObject);
    }
	public void Enter()
	{
        Destroy(this.gameObject);
        Object SetObject = Resources.Load("loading", typeof(GameObject));
        GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
        GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);

	}
	// Update is called once per frame
	void Update()
    {
        timer += Time.deltaTime;
    }
}
