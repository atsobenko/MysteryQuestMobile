using System.Collections;
using TMPro;
using UnityEngine;

public class TextWritingSystem : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public float typingSpeed;

    public void StartWriting(string text)
    {
        StopCoroutine(Write(text));
        StartCoroutine(Write(text));
    }

    IEnumerator Write(string text)
    {
        textComponent.text = "";
        foreach (char letter in text.ToCharArray())
        {
            textComponent.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
