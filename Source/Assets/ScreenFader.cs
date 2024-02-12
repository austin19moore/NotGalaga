using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] Color fadeColor = Color.black;
    [SerializeField] float fadeTime = 1;
    void Start()
    {
        fadeImage = this.GetComponent<Image>();
        Fade();
    }

    void Fade() {
        fadeImage.color = fadeColor;
        StartCoroutine(FadeToClear());
        IEnumerator FadeToClear() {
            float timer = 0;
            while (timer < fadeTime) {
                yield return null;
                timer += Time.deltaTime;
                fadeImage.color = new Color(fadeColor.r, fadeColor.g, fadeColor.b, 1f - (timer / fadeTime));
            }
            fadeImage.color = Color.clear;
        }
    }


}
