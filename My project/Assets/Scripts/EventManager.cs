using UnityEngine;

public static class EventManager
{
    public static void TriggerEvent(EventType type)
    {
        switch (type)
        {
            case EventType.FlickerLight:
                Debug.Log("È­¸é ±ôºýÀÓ");
                ScreenFlicker.Instance?.Flicker();
                break;
            case EventType.KnockDoor:
                Debug.Log("¹® µÎµå¸®´Â ¼Ò¸®");
                KnockDoor.Instance?.PlayKnock();
                break;
            case EventType.DropFrame:
                Debug.Log("¾×ÀÚ ¶³¾îÁü");
                DropFrame.Instance?.Drop();
                break;
            case EventType.WomenVoice:
                Debug.Log("ÇÑ¼û ¼Ò¸®");
                WomenVoice.Instance?.PlaySound();
                break;
        }
    }
}
