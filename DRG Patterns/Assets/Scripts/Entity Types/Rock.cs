using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour, IHackable
{
    private EventWrapper onRockHit = new EventWrapper();

    private void Start()
    {
        ((EventManager)ServiceLocator.Instance.Get("Events")).Add("OnRockHit", onRockHit);
    }

    public void OnHit(int damage)
    {
        onRockHit.action?.Invoke();
    }
}
