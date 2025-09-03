using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Candle : MonoBehaviour
{
    public GameObject candleFlame;
    private AudioSource fireAudio;
    private bool isFire = false;

    void Start()
    {
        candleFlame.SetActive(false);
        fireAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Match match = other.GetComponent<Match>();
        XRGrabInteractable grab = other.GetComponent<XRGrabInteractable>();

        if (!isFire)
        {
            if ((match != null && grab != null && grab.isSelected && !match.isUsed))
            {
                candleFlame.SetActive(true);
                fireAudio.Play();
                match.Use();
                isFire = true;
                MatchManager.instance.AddLitCandle();
            }
        }
    }
}
