using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zhushu : MonoBehaviour
{
    public string Name;
    public float time;
	private void Start()
	{
        time = 0;

	}
    private void Update()
    {
        time += Time.deltaTime;
        if (time > 3) Destroy(this.gameObject);
    }
	public void ZhuShu()
    {
        Debug.Log("789");
        Object SetObject = Resources.Load("MakeBook", typeof(GameObject));
        GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
        GameSetPanel.transform.SetParent(GameObject.Find("Canvas").transform, false);
        Destroy(GameObject.Find("chooseWritten(Clone)")); 
    }
    public void DoNotWrite()
    {
        Destroy(this.gameObject); 
    }
}
