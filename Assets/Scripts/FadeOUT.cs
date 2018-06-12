using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOUT : MonoBehaviour
{
    [SerializeField]
    private Image imageToUse;
    [SerializeField]
    private bool useThisImage = false;
    [SerializeField]
    private bool fadeOnStart = false;
    [SerializeField]
    private float timeMultiplier;

    private void Start()
    {
        if (useThisImage)
        {
            imageToUse = GetComponent<Image>();
        }
        if (fadeOnStart)
        {
            StartCoroutine(FadeOutText(timeMultiplier, imageToUse));
        }
    }
    private IEnumerator FadeOutText(float timeSpeed, Image text)
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
        while (text.color.a > 0.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - (Time.deltaTime * timeSpeed));
            yield return null;
        }
    }
    public void FadeOutText(float timeSpeed = -1.0f)
    {
        if (timeSpeed <= 0.0f)
        {
            timeSpeed = timeMultiplier;
        }
        StartCoroutine(FadeOutText(timeSpeed, imageToUse));
    }
}