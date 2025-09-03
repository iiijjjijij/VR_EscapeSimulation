using UnityEngine;

public class WomenVoice : MonoBehaviour
{
    public static WomenVoice Instance;
    private AudioSource womenAudio;

    private void Start()
    {
        womenAudio = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        womenAudio.Play();
    }
}
