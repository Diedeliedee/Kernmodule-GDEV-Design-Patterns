using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour, IHackable
{
    private event System.Action onRockHit = null;

    private void Start()
    {
        ((EventManager)ServiceLocator.Instance.Get("Events")).Add("OnRockHit", ref onRockHit);
    }

    public void OnHit(int damage)
    {
        onRockHit?.Invoke();
    }
}
