using UnityEngine;

public class Socket : MonoBehaviour
{
    [HideInInspector] public bool isFilled = false; // 현재 책이 들어와 있는지

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Book"))
        {
            isFilled = true;
            SocketManager.Instance.CheckAllSockets(); // 매니저에게 확인 요청
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Book"))
        {
            isFilled = false;
        }
    }
}
