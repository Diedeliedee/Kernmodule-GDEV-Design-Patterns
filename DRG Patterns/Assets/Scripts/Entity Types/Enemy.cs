using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHackable, IShootable
{
    private event System.Action onEnemyHit = null;

    private void Start()
    {
        ((EventManager)ServiceLocator.Instance.Get("Events")).Add("OnEnemyHit", ref onEnemyHit);
    }

    public void OnHit(int damage)
    {
        onEnemyHit?.Invoke();
    }
}
