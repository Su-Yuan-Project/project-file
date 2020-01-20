using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PanelController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject chineseMap;
    public GameObject MainCamera;
    public void SetButtonClick()
    {
        if (GameObject.Find("gameSetPanel(Clone)") == false )
        {
            Debug.Log("1345");
            Object SetObject = Resources.Load("gameSetPanel", typeof(GameObject));
            GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
            GameSetPanel.transform.SetParent(this.transform, false);

        }
        else if(GameObject.Find("gameSetPanel(Clone)")==true)
        {
            Destroy(GameObject.Find("gameSetPanel(Clone)"));
        }
            return;
    }
    public void countryButtonClick()
    {
        if (GameObject.Find("countryPanel(Clone)") == false)
        {
            Debug.Log("345");
            Object countryObject = Resources.Load("countryPanel", typeof(GameObject));
            GameObject countryPanel = Instantiate(countryObject) as GameObject;
            countryPanel.transform.SetParent(this.transform, false);
        }
        else if(GameObject.Find("countryPanel(Clone)") == true)
        {
            Destroy(GameObject.Find("countryPanel(Clone)"));
        }
            return;
        //generate data

    }
    public void ZhuZiButtonClick()
    {
        if (GameObject.Find("ZhuZi(Clone)") == false)
        {
            Debug.Log("1234556");
            Object ZhuZiObject = Resources.Load("ZhuZi",typeof(GameObject));
            GameObject ZhuZiPanel = Instantiate(ZhuZiObject) as GameObject;
            ZhuZiPanel.transform.SetParent(this.transform,false);
        }
        GameObject.Find("ZhuZi(Clone)").transform.GetComponent<ZhuziPanelController>().InitializeData();
    }
	public void Update()
	{
        //获取鼠标的屏幕坐标
       
        if (Input.mousePosition.x < 50&&MainCamera.transform.position.x>-15)
        {
            double temp_X = MainCamera.transform.position.x - 0.15;
            MainCamera.transform.position = new Vector3((float)temp_X, MainCamera.transform.position.y, MainCamera.transform.position.z);
        }
        if(Input.mousePosition.x>2500&&MainCamera.transform.position.x<13)
        {
            double temp_X = MainCamera.transform.position.x + 0.15;
            MainCamera.transform.position = new Vector3((float)temp_X, MainCamera.transform.position.y, MainCamera.transform.position.z);
        }
        if(Input.mousePosition.y<30&&MainCamera.transform.position.y>-27)
        {
            double temp_y = MainCamera.transform.position.y - 0.15;
            MainCamera.transform.position = new Vector3(MainCamera.transform.position.x, (float)temp_y, MainCamera.transform.position.z);

        }
        if(Input.mousePosition.y>1500&&MainCamera.transform.position.y<-9)
        {
            double temp_y = MainCamera.transform.position.y + 0.15;
            MainCamera.transform.position = new Vector3(MainCamera.transform.position.x, (float)temp_y, MainCamera.transform.position.z);
        }
      
       /* if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.fieldOfView <= 100)
                Camera.main.fieldOfView += 0.1f;
            if (Camera.main.orthographicSize <= 20)
                Camera.main.orthographicSize += 0.1F;
        }
        //Zoom in
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (Camera.main.fieldOfView > 2)
                Camera.main.fieldOfView -= 0.1f;
            if (Camera.main.orthographicSize >= 1)
                Camera.main.orthographicSize -= 0.1F;
        }*/
	}


}
