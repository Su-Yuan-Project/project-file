using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private float FadeAlpha = 0;
    private float outAlpha = 1;
    private float alphaSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = this.GetComponent<CanvasGroup>();
        canvasGroup.alpha = FadeAlpha;
    }

    // Update is called once per frame
    void Update()
    {
        if (canvasGroup == null) return;
        else if(canvasGroup.alpha != outAlpha)
            canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, outAlpha, alphaSpeed * Time.deltaTime);
        if (canvasGroup.alpha >= 0.95)
            canvasGroup.alpha = 1;
        return;
            
            
    }
}
