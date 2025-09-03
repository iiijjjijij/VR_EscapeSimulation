using UnityEngine;

public class KnockDoor : MonoBehaviour
{
    public static KnockDoor Instance;
    private AudioSource knockAudio;
    public AudioClip knockSound;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        knockAudio = GetComponent<AudioSource>();
    }
    public void PlayKnock()
    {
        if (knockAudio != null)
        {
            knockAudio.PlayOneShot(knockSound);
            Debug.Log("Knock");
        }
    }
}
