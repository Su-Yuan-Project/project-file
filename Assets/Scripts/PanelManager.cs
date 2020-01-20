using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{

    //保存所有面板的地址

    public void SetButtonClick()
    {
        if (GameObject.Find("GameSetPanel(Clone)") == false || GameObject.Find("GameSetPanel") == false)
        {
            Object SetObject = Resources.Load("Panel/GameSetPanel", typeof(GameObject));
            GameObject GameSetPanel = Instantiate(SetObject) as GameObject;
            GameSetPanel.transform.SetParent(this.transform, false);

        }
        else
            return;

    }
    public void ZhuHouButtonClick()
    {
        if (GameObject.Find("ZhuHouPanel(Clone)") == false || GameObject.Find("ZhuHouPanel") == false)
        {
            Object SetObject = Resources.Load("Panel/ZhuHouPanel", typeof(GameObject));
            GameObject ZhuHouPanel = Instantiate(SetObject) as GameObject;
            ZhuHouPanel.transform.SetParent(this.transform, false);

        }
        else
            return;
    }
}
