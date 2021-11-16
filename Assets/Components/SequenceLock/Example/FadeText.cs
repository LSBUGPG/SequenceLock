using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{
    public Text text;

    public void FadeOut()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        Color color = text.color;
        while (color.a > 0.0f)
        {
            color.a -= Time.deltaTime;
            text.color = color;
            yield return null;
        }

        color.a = 0.0f;
        text.color = color;
    }
}
