using UnityEngine;

public class Socket : MonoBehaviour
{
    [HideInInspector] public bool isFilled = false; // ���� å�� ���� �ִ���

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Book"))
        {
            isFilled = true;
            SocketManager.Instance.CheckAllSockets(); // �Ŵ������� Ȯ�� ��û
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
