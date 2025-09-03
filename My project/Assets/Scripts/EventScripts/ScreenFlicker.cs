using UnityEngine;
using UnityEngine.UI;

public class ScreenFlicker : MonoBehaviour
{
    public static ScreenFlicker Instance;
    public Image screenImage;

    private void Awake()
    {
        Instance = this;
    }

    public void Flicker()
    {
        StartCoroutine(FlickerCoroutine());
    }

    System.Collections.IEnumerator FlickerCoroutine()
    {
        Color color = screenImage.color;

        for (int i = 0; i < 3; i++)
        {
            color.a = 1f;
            screenImage.color = color;
            yield return new WaitForSeconds(0.1f);

            color.a = 0f;
            screenImage.color = color;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
