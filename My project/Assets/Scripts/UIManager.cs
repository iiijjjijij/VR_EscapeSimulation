using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public GameObject optionCanvas;
    public Slider volumSlider;
    public AudioSource audio;

    public TMP_Text matchCount;
    private int match = 0;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AudioSource audio = optionCanvas.GetComponent<AudioSource>();
        if(audio != null && volumSlider != null)
        {
            volumSlider.value=audio.volume;
            volumSlider.onValueChanged.AddListener(SetVolume);
        }
    }

    public void UpdateScoreUI(int current, int total)
    {
        matchCount.text = $"{current} / {total}";
    }

    public void ToggleBGM()
    {
        if (audio != null)
        {
            if (audio.isPlaying)
                audio.Pause();
            else
                audio.Play();
        }
    }

    public void SetVolume(float value)
    {
        if (audio != null)
        {
            audio.volume = value;
        }
    }
}
