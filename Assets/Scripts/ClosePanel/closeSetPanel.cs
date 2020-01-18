using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeSetPanel : MonoBehaviour
{
    public void SetButtonClose()
    {
        Debug.Log("close");
        Destroy(GameObject.Find("gameSetPanel(Clone)"));
    }
    public void ExitGame()
    {
        Debug.Log("321");
//        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
