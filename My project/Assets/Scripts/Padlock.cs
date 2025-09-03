using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Padlock : MonoBehaviour
{
    public GameObject padlock;
    public GameObject key;

    public Animator RightDoor;
    public Animator LeftDoor;
    public Animator LatchRoot;

    private bool isOpen = false;

    public void OpenDoor()
    {
        if (!isOpen)
        {
            Destroy(padlock);
            Destroy(key);
            RightDoor.SetBool("IsOpen", true);
            LeftDoor.SetBool("IsOpen", true);
            LatchRoot.SetBool("IsOpen", true);

            isOpen = true;
        }
    }
}
