using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeCountryPanel : MonoBehaviour
{
    public void dialoguePanelClose()
    {
        Destroy(GameObject.Find("dialogue(Clone)"));
        Destroy(GameObject.Find("Mission(Clone)"));
    }
}
