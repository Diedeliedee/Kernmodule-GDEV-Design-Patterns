using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour, IServiceItem
{
    private Dictionary<string, EventWrapper> eventPool = new Dictionary<string, EventWrapper>();
    private const string errorMessage = "Event not found within the event pool!";

    private void Awake()
    {
        ServiceLocator.Instance.Add("Events", this);
    }

    public void Add(string eventName, EventWrapper wrapper)
    {
        eventPool.Add(eventName, wrapper);
    }

    public void Remove(string eventName)
    {
        try { eventPool.Remove(eventName); }
        catch { Debug.LogWarning(errorMessage); }
    }

    public void Subscribe(string eventName, Action action)
    {
        try { eventPool[eventName].action += action; }
        catch { Debug.LogWarning(errorMessage); }
    }

    public void Unsubscribe(string eventName, Action action)
    {
        try { eventPool[eventName].action -= action; }
        catch { Debug.LogWarning(errorMessage); }
    }
}
