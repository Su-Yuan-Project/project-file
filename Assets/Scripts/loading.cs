using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private float FadeAlpha = 1;
    private float outAlpha = 0;
    private float alphaSpeed = 2f;
    private float mtime;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = this.GetComponent<CanvasGroup>();
        canvasGroup.alpha = FadeAlpha;
        mtime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mtime += Time.deltaTime;
        Debug.Log(mtime);
        if (mtime > 2)
        {
            if (canvasGroup == null) return;
            else if (canvasGroup.alpha != outAlpha)
                canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, outAlpha, alphaSpeed * Time.deltaTime);
            if (canvasGroup.alpha <= 0.05)
            {
              
                Object MissionPanel2 = Resources.Load("Reel", typeof(GameObject));
                GameObject missionPanel2 = Instantiate(MissionPanel2) as GameObject;
                missionPanel2.transform.SetParent(GameObject.Find("Canvas").transform, false);
               Destroy(GameObject.Find("loading(Clone)"));
            }
            return;
        }
       

    }
}
