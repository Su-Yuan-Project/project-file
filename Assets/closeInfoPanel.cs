using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeInfoPanel : MonoBehaviour
{
    public void infoPanelClose()
    {
        Destroy(GameObject.Find("countryInfo(Clone)"));
    }
}
