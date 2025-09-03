using System.Collections.Generic;
using UnityEngine;

public class SocketManager : MonoBehaviour
{
    public GameObject floorDoor;
    public Animator floorDoorAnimator;
    public Collider floorDoorCollider;
    private bool isOpen = false;

    public static SocketManager Instance;
    public List<Socket> sockets;

    private void Awake()
    {
        Instance = this;
    }

    public void CheckAllSockets()
    {
        foreach (Socket socket in sockets)
        {
            if (!socket.isFilled)
                return;
        }
        OpenFloorDoor();
    }

    public void OpenFloorDoor()
    {
        if (!isOpen)
        {
            Destroy(floorDoorCollider);
            floorDoorAnimator.SetBool("IsOpen", true);
            isOpen = true;
        }
    }
}
