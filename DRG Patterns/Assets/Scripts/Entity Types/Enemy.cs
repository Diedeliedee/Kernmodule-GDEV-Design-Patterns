using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHackable, IShootable
{
    private EventWrapper onEnemyHit = new EventWrapper();

    private void Start()
    {
        ((EventManager)ServiceLocator.Instance.Get("Events")).Add("OnEnemyHit", onEnemyHit);
    }

    public void OnHit(int damage)
    {
        onEnemyHit.action?.Invoke();
    }
}
