using UnityEngine;

public class Match : MonoBehaviour
{
    public bool isUsed = false;
    public EventType eventType = EventType.None;

    public void Use()
    {
        isUsed = true;
        EventManager.TriggerEvent(eventType);
        Destroy(gameObject);
    }
}
