using UnityEngine;

public static class EventManager
{
    public static void TriggerEvent(EventType type)
    {
        switch (type)
        {
            case EventType.FlickerLight:
                Debug.Log("ȭ�� ������");
                ScreenFlicker.Instance?.Flicker();
                break;
            case EventType.KnockDoor:
                Debug.Log("�� �ε帮�� �Ҹ�");
                KnockDoor.Instance?.PlayKnock();
                break;
            case EventType.DropFrame:
                Debug.Log("���� ������");
                DropFrame.Instance?.Drop();
                break;
            case EventType.WomenVoice:
                Debug.Log("�Ѽ� �Ҹ�");
                WomenVoice.Instance?.PlaySound();
                break;
        }
    }
}
