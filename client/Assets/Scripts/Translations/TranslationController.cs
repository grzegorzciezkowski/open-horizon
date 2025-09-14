using UnityEngine;

public class TranslationController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Language Controller");
    }

    public void ApplyTranslations()
    {
        foreach (var loc in FindObjectsByType<LocalizedText>(FindObjectsInactive.Exclude, FindObjectsSortMode.None))
        {
            loc.UpdateText();
        }
    }
}
