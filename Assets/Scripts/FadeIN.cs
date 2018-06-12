using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIN : MonoBehaviour
{
    private int TimeCount;
    public int ToStart;
    

    [SerializeField]
    private Image imageToUse;
    [SerializeField]
    private bool useThisImage = false;
    [SerializeField]
    private bool fadeInStart = false;
    [SerializeField]
    private float timeMultiplier;

    private void Start()
    {
        if (useThisImage)
        {
            imageToUse = GetComponent<Image>();
        }
    }

    private void Update()
    {
        TimeCount += 1;

        if (TimeCount >= ToStart && fadeInStart)
        {
            StartCoroutine(FadeInText(timeMultiplier, imageToUse));
        }
    }
    private IEnumerator FadeInText(float timeSpeed, Image text)
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.deltaTime * timeSpeed));
            yield return null;
        }
    }
    public void FadeInText(float timeSpeed = -1.0f)
    {
        if (timeSpeed <= 0.0f)
        {
            timeSpeed = timeMultiplier;
        }
        StartCoroutine(FadeInText(timeSpeed, imageToUse));
    }
}