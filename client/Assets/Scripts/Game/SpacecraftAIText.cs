using System;
using TMPro;
using UnityEngine;

public class SpacecraftAIText : MonoBehaviour
{
    [Range(0f, 1f)] public float maxAlpha = 0.8f;
    public float fadeDuration = 2f;
    public float displayTime = 3f;

    private TextMeshProUGUI m_textMsg;
    private Coroutine m_coroutine;

    void Start()
    {
        m_textMsg = GetComponent<TextMeshProUGUI>();
    }

    public void ShowMessage(string message, Action onClose)
    {
        if (m_coroutine != null)
            StopCoroutine(m_coroutine);

        m_coroutine = StartCoroutine(ShowAndHide(message, onClose));
    }

    private System.Collections.IEnumerator ShowAndHide(string message, Action onClose)
    {
        m_textMsg.text = message;

        // FADE IN
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            float alpha = Mathf.Clamp01(elapsed / fadeDuration);
            m_textMsg.alpha = alpha * maxAlpha;
            yield return null;
        }

        // Czekaj okreœlony czas
        yield return new WaitForSeconds(displayTime);

        // FADE OUT
        elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            float alpha = Mathf.Clamp01(1 - (elapsed / fadeDuration));
            m_textMsg.alpha = alpha * maxAlpha;
            yield return null;
        }

        m_textMsg.text = "";
        m_coroutine = null;

        onClose?.Invoke();
    }
}
