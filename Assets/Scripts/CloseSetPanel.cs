using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSetPanel : MonoBehaviour
{
    public void ClosePanel()
    {
        Debug.Log("123");
        Destroy(GameObject.Find("GameSetPanel(Clone)"));
        Destroy(GameObject.Find("GameSetPanel"));


    }
}
