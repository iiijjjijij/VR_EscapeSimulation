using UnityEngine;

public class DropFrame : MonoBehaviour
{
    public static DropFrame Instance;
    public Rigidbody frameRigidbody;
    private AudioSource dropFrame;

    private void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        frameRigidbody = GetComponent<Rigidbody>();
        frameRigidbody.isKinematic = true;
        dropFrame = GetComponent<AudioSource>();
    }

    public void Drop()
    {
        if (frameRigidbody != null)
        {
            frameRigidbody.isKinematic = false;
            Debug.Log("Drop");
            dropFrame.Play();
        }
    }
}
